using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ForestLevelGenerator : MonoBehaviour
{
	public static ForestLevelGenerator generator;
	public event System.Action OnLevelRefresh;
	public ForestTile wallObj;
	public ForestTile floorObj;
	[SerializeField] private Animator transitionAnimator = null;
	[SerializeField] private Transform heroPos = null;
	[SerializeField] private CinemachineVirtualCamera cam = null;
	[SerializeField] private Transform fire = null;
	private enum GridSpace { Empty, Floor, Wall };
	private GridSpace[,] _grid;
	private int _roomHeight, _roomWidth;
	[SerializeField] private Vector2 roomSizeWorldUnits = new Vector2(30, 30);
	[SerializeField] private float worldUnitsInOneGridCell = 1;
	struct Walker
	{
		public Vector2 dir;
		public Vector2 pos;
    }
    private List<Walker> _walkers;
    float chanceWalkerChangeDir = 0.5f, chanceWalkerSpawn = 0.05f;
    float chanceWalkerDestoy = 0.05f;
    int maxWalkers = 10;
    [SerializeField] private float percentToFill = 0.2f;
	
	public void CreateLevel()
    {
		transitionAnimator.SetTrigger("Transition");
		DeleteAllObjects();
		Setup();
		CreateFloors();
		CreateWalls();
		SpawnLevel();
		SetHeroInitialPosition();
		SetFirePosition();
	}
    private void Awake()
    {
		generator = this;
    }

    void Start()
	{
		CreateLevel();
	}
	void Setup()
	{
		_roomHeight = Mathf.RoundToInt(roomSizeWorldUnits.x / worldUnitsInOneGridCell);
		_roomWidth = Mathf.RoundToInt(roomSizeWorldUnits.y / worldUnitsInOneGridCell);
		_grid = new GridSpace[_roomWidth, _roomHeight];
		for (int x = 0; x < _roomWidth - 1; x++)
		{
			for (int y = 0; y < _roomHeight - 1; y++)
			{
				_grid[x, y] = GridSpace.Empty;
			}
		}
        _walkers = new List<Walker>();
        Walker newWalker = new Walker();
        newWalker.dir = RandomDirection();
        Vector2 spawnPos = new Vector2(Mathf.RoundToInt(_roomWidth / 2.0f),Mathf.RoundToInt(_roomHeight / 2.0f));
		newWalker.pos = spawnPos;
		_walkers.Add(newWalker);
    }
    private void CreateFloors()
	{
		int iterations = 0;
		do
		{
			foreach (Walker myWalker in _walkers)
				_grid[(int)myWalker.pos.x, (int)myWalker.pos.y] = GridSpace.Floor;
			int numberChecks = _walkers.Count; 
			for (int i = 0; i < numberChecks; i++)
			{
				if (Random.value < chanceWalkerDestoy && _walkers.Count > 1)
				{
					_walkers.RemoveAt(i);
					break;
				}
			}
			for (int i = 0; i < _walkers.Count; i++)
			{
				if (Random.value < chanceWalkerChangeDir)
				{
					Walker currentWalker = _walkers[i];
					currentWalker.dir = RandomDirection();
					_walkers[i] = currentWalker;
				}
			}
			numberChecks = _walkers.Count;
			for (int i = 0; i < numberChecks; i++)
			{
				if (Random.value < chanceWalkerSpawn && _walkers.Count < maxWalkers)
				{
					Walker newWalker = new Walker();
					newWalker.dir = RandomDirection();
					newWalker.pos = _walkers[i].pos;
					_walkers.Add(newWalker);
				}
			}
			for (int i = 0; i < _walkers.Count; i++)
			{
				Walker thisWalker = _walkers[i];
				thisWalker.pos += thisWalker.dir;
				_walkers[i] = thisWalker;
			}
			for (int i = 0; i < _walkers.Count; i++)
			{
				Walker thisWalker = _walkers[i];
				thisWalker.pos.x = Mathf.Clamp(thisWalker.pos.x, 1, _roomWidth - 2);
				thisWalker.pos.y = Mathf.Clamp(thisWalker.pos.y, 1, _roomHeight - 2);
				_walkers[i] = thisWalker;
			}
			if ((float)GetNumberOfFloors() / _grid.Length > percentToFill)
				break;
			iterations++;
		} while (iterations < 100000);
	}
	private void CreateWalls()
	{
		for (int x = 0; x < _roomWidth - 1; x++)
		{
			for (int y = 0; y < _roomHeight - 1; y++)
			{
				if (_grid[x, y] == GridSpace.Floor)
				{
					if (_grid[x, y + 1] == GridSpace.Empty)
						_grid[x, y + 1] = GridSpace.Wall;
					if (_grid[x, y - 1] == GridSpace.Empty)
						_grid[x, y - 1] = GridSpace.Wall;
					if (_grid[x + 1, y] == GridSpace.Empty)
						_grid[x + 1, y] = GridSpace.Wall;
					if (_grid[x - 1, y] == GridSpace.Empty)
						_grid[x - 1, y] = GridSpace.Wall;
				}
			}
		}
	}
	private void SpawnLevel()
	{
		for (int x = 0; x < _roomWidth; x++)
		{
			for (int y = 0; y < _roomHeight; y++)
			{
				switch (_grid[x, y])
				{
					case GridSpace.Empty:
						SpawnTile(x, y, wallObj);
						break;
					case GridSpace.Floor:
						SpawnTile(x, y, floorObj);
						break;
					case GridSpace.Wall:
						SpawnTile(x, y, wallObj);
						break;
				}
			}
		}
	}
	private Vector2 RandomDirection()
	{
		int choice = Mathf.FloorToInt(Random.value * 3.99f);
		switch (choice)
		{
			case 0:
				return Vector2.down;
			case 1:
				return Vector2.left;
			case 2:
				return Vector2.up;
			default:
				return Vector2.right;
		}
	}
	private void DeleteAllObjects()
    {
        OnLevelRefresh?.Invoke();
        RemoveAllObstacles();
    }
	private void RemoveAllObstacles()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
			Destroy(transform.GetChild(i).gameObject);
        }
    }
	private void SetHeroInitialPosition() { 
		for (int x = 0; x < _roomWidth; x++)
		{
			for (int y = 0; y < _roomHeight; y++)
			{
				if (_grid[x, y] == GridSpace.Floor)
				{
					Vector2 offset = roomSizeWorldUnits / 2.0f;
					Vector2 spawnPos = new Vector2(x, y) * worldUnitsInOneGridCell - offset;
					heroPos.position = spawnPos;
					cam.transform.position = heroPos.position;
					return;
				}
				}
			}
		}

	private void SetFirePosition()
	{
		for (int x = _roomWidth-1; x > 0; x--)
		{
			for (int y = _roomHeight-1; y > 0; y--)
			{
				if (_grid[x, y] == GridSpace.Floor)
				{
					Vector2 offset = roomSizeWorldUnits / 2.0f;
					Vector2 spawnPos = new Vector2(x,y) * worldUnitsInOneGridCell - offset;
					fire.position = spawnPos;
					return;
				}
			}
		}
	}
	private int GetNumberOfFloors()
	{
		int count = 0;
		foreach (GridSpace space in _grid)
		{
			if (space == GridSpace.Floor)
				count++;
		}
		return count;
	}
	private void SpawnTile(float x, float y, ForestTile tilesPrefab)
	{
		Vector2 offset = roomSizeWorldUnits / 2.0f;
		Vector2 spawnPos = new Vector2(x, y) * worldUnitsInOneGridCell - offset;
		var tile = Instantiate(tilesPrefab.gameObject, spawnPos, Quaternion.identity);
		tile.transform.parent = transform;
	}
}

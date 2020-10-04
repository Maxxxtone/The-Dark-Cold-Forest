using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy[] enemies = null;
    [SerializeField] private Enemy[] resources = null;
    private void Spawn(Enemy[] spawnObjects)
    {
        var chance = Random.Range(0, 1f);
        foreach(var e in spawnObjects)
        {
            if(chance < e.chanceToSpawn)
            {
                Instantiate(e.gameObject, transform.position, Quaternion.identity);
                return;
            }
        }
    }
    private void Start()
    {
        Spawn(enemies);
        Spawn(resources);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroController : MonoBehaviour
{
    public static HeroController current;
    [SerializeField] private InputMaster input = null;
    [SerializeField] private float speed = 2f;
    [SerializeField] private LayerMask enemiesLayer = 6;
    [SerializeField] private float attackSphereRadius = 0.8f;
    [SerializeField] private Transform weaponHolder = null;
    private Vector2 _velVector;
    private Rigidbody2D _rb;
    private Animator _heroAnimator;
    private Weapon _currentWeapon;
    public void RefreshActiveWeapon(Weapon weapon)
    {
        _currentWeapon = weapon;
    }
    private void FlipWithCurosr()
    {
        if (CursorObject.cursor.transform.position.x > transform.position.x)
            transform.localEulerAngles = new Vector3(0, 0, 0);
        else
            transform.localEulerAngles = new Vector3(0, 180, 0);
    }
    private void Move()
    {
        if(Mathf.Abs(_velVector.x) > 0 || Mathf.Abs(_velVector.y) > 0)
            _heroAnimator.SetFloat("speed", speed);
        else
            _heroAnimator.SetFloat("speed", 0);
    }
    private void CreateAttackSphere()
    {
        var enemies = Physics2D.OverlapCircleAll(weaponHolder.position, attackSphereRadius, enemiesLayer);
        if (enemies.Length > 0) { CameraShake.current.Shake(); }//тряска камеры
        foreach (var e in enemies)
        {
            e.GetComponent<Enemy>().TakeDamage(_currentWeapon.damage);
        }
    }
    private void Attack()
    {
        _currentWeapon.Use(_heroAnimator);
    }
    private void Switch()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        var newScene = Mathf.Abs(activeScene.buildIndex-1);
        SceneManager.LoadScene(newScene);
    }
    private void Awake()
    {
        current = this;
        input = new InputMaster();
        input.Player.Attack.performed += _context => Attack();
        input.PauseMenu.Invoke.performed += _context => PauseMenu.menu.Pause();
    }
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _heroAnimator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        input.Enable();
    }
    private void OnDisable()
    {
        input.Disable();
    }
    private void Update()
    {
        _velVector = input.Player.Movement.ReadValue<Vector2>() * speed;
        Move();
        FlipWithCurosr();
    }
    private void FixedUpdate()
    {
        _rb.velocity = _velVector;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            if (input.Player.SwitchScene.triggered)
            {
                HeroResources.resources.ConvertResourcesToMoney();
                HeroStats.stats.FullHill();
                ForestLevelGenerator.generator.CreateLevel();
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(weaponHolder.position, attackSphereRadius);
    }
}

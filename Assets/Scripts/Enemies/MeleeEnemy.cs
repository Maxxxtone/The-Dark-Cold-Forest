using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{
    [SerializeField] private float visionDistance = 1f;
    [SerializeField] private float stoppingDistance = 0.3f;
    [SerializeField] private LayerMask playerLayer = 7;
    [SerializeField] private Transform weaponHolder = null;
    [SerializeField] private float attackRange = 0.2f;
    [SerializeField] private int damage = 1;
    
    private Transform _heroTransform;
    private bool _canFollow = true;

    private void CreateAttackSphere()
    {
        var hero = Physics2D.OverlapCircle(weaponHolder.position, attackRange, playerLayer);
        if (hero)
        {
            hero.GetComponent<HeroStats>().TakeDamage(damage);
        }
    }
    private IEnumerator EndOfAttack()
    {
        _canFollow = false;
        yield return new WaitForSeconds(1f);
        _canFollow = true;
    }
    private void Rotate()
    {
        if (transform.position.x < _heroTransform.position.x)
            transform.localEulerAngles = new Vector3(0, 0, 0);
        else
            transform.eulerAngles = new Vector3(0, 180, 0);
    }
    private void Start()
    {
        hp = maxHp;
        _heroTransform = GameInfo.current.heroTransform;
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Vector2.Distance(transform.position, _heroTransform.position) <= visionDistance)
        {
            Rotate();
            if (Vector2.Distance(transform.position, _heroTransform.position) >= stoppingDistance && _canFollow)
            {
                animator.SetFloat("speed", speed);
                transform.position = Vector2.MoveTowards(transform.position, _heroTransform.position, speed * Time.deltaTime);
            }
            else
            {
                if (_canFollow)
                {
                    animator.SetFloat("speed", 0);
                    animator.SetTrigger("Attack");
                    StartCoroutine(EndOfAttack());
                }
            }
        }
        else animator.SetFloat("speed", 0);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(weaponHolder.position, attackRange);
        Gizmos.DrawWireSphere(transform.position, visionDistance);
    }
}

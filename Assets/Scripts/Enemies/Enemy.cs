using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float chanceToSpawn = 0.1f;
    [SerializeField] protected int maxHp = 4;
    [SerializeField] protected float speed = 1;
    [SerializeField] private int maxMoneyCost = 1;
    [SerializeField] protected ParticleSystem deathParticles = null;
    protected Animator animator;
    protected int hp;
    private void Awake()
    {
        ForestLevelGenerator.generator.OnLevelRefresh += DestroyOnRefresh;
    }
    private void Start()
    {
        animator = GetComponent<Animator>();
        hp = maxHp;
    }
    
    public void TakeDamage(int dmg)
    {
        if(animator)
            animator.SetTrigger("GetHit");
        AudioController.controller.PlaySound();
        hp = Mathf.Clamp(hp - dmg, 0, maxHp);
        if (hp <= 0)
        {
            var particlePos = transform.position;
            particlePos.z = -10;
            Instantiate(deathParticles, particlePos, Quaternion.identity).Play();
            DropLoot();
            Destroy(gameObject);
        }
    }
    public virtual void DropLoot()
    {
        var m = Random.Range(0, maxMoneyCost);
        HeroResources.resources.UpdateResources(m, 0, 0);
    }
    private void OnDestroy()
    {
        ForestLevelGenerator.generator.OnLevelRefresh -= DestroyOnRefresh;
    }
    private void DestroyOnRefresh()
    {
        Destroy(gameObject);
    }
}

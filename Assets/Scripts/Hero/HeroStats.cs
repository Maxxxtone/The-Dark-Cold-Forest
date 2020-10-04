using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroStats : MonoBehaviour
{
    public static HeroStats stats;
    public int maxHp = 5;
    [SerializeField] private ParticleSystem deathParticles = null;
    [SerializeField] private Image hpFill = null;
    private int _hp;
    private Animator _animator;
    
    public void TakeDamage(int dmg)
    {
        _animator.SetTrigger("GetHit");
        AudioController.controller.PlaySound();
        _hp = Mathf.Clamp(_hp - dmg, 0, maxHp);
        UpdateHpUI();
        if (_hp <= 0) {
            var particlePos = transform.position;
            particlePos.z = -10;
            Instantiate(deathParticles, particlePos, Quaternion.identity).Play();
            PauseMenu.menu.RestartLevel(); 
        }
    }
    private void UpdateHpUI()
    {
        hpFill.fillAmount = (float) _hp / maxHp;
    }
    private void Awake()
    {
        stats = this;
    }
    private void Start()
    {
        _hp = maxHp;
        _animator = GetComponent<Animator>();
        UpdateHpUI();
    }
    public void FullHill()
    {
        _hp = maxHp;
        UpdateHpUI();
    }
}

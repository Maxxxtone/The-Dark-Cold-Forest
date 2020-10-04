using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : Enemy
{
    [SerializeField] private int maxTimberCost = 3;
    [SerializeField] private int maxRockCost = 3;
    [SerializeField] private Sprite[] sprites = null;

    private void SetSprite()
    {
        var rend = GetComponent<SpriteRenderer>();
        var spriteNum = Random.Range(0, sprites.Length);
        rend.sprite = sprites[spriteNum];
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        hp = maxHp;
        SetSprite();
    }
    public override void DropLoot()
    {
        var t = Random.Range(1, maxTimberCost);
        var r = Random.Range(1, maxRockCost);
        HeroResources.resources.UpdateResources(0, t, r);
    }
}

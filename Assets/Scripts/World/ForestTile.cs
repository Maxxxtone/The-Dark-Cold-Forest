using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestTile : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites = null;
    private SpriteRenderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        var spriteNumber = Random.Range(0, sprites.Length - 1);
        _renderer.sprite = sprites[spriteNumber];
    }
}

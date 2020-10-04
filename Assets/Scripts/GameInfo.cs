using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour
{
    public static GameInfo current;
    public Transform heroTransform;

    private void Awake()
    {
        current = this;
    }
    private void Start()
    {
        heroTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
}

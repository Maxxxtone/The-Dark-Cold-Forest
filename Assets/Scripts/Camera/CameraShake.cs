using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake current;
    [SerializeField] private CinemachineImpulseSource impulse = null;

    private void Awake()
    {
        current = this;
    }
    public void Shake()
    {
        impulse.GenerateImpulse();
    }
}

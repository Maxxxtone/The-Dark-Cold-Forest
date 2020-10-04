using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController controller;
    [SerializeField] private AudioClip[] clips;
    private AudioSource _audioSource;
    private void Awake()
    {
        controller = this;
    }
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    public void PlaySound()
    {
        var number = Random.Range(0, clips.Length);
        _audioSource.PlayOneShot(clips[number]);
    }
}

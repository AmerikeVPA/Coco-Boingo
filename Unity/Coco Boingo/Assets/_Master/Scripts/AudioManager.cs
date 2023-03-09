using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager obj;
    private AudioSource audioSrc;

    public AudioClip fruit;
    public AudioClip lost;
    public AudioClip damage;

    private void Awake()
    {
        obj = this;
        audioSrc = gameObject.AddComponent<AudioSource>();
    }

    public void playShot() { Playsound(fruit); }
    public void playHit() { Playsound(lost); }
    public void playDamage() { Playsound(damage); }

    public void Playsound(AudioClip clip)
    {
        audioSrc.PlayOneShot(clip);
    }
    private void OnDestroy()
    {
        obj = null;
    }
}

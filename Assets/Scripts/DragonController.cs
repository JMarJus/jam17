using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    public GameObject dragon;
    public AudioClip sniffClip;
    public AudioClip laughClip;
    public AudioClip roarClip;
    public AudioClip fireClip;
    public AudioClip biteClip;
    public AudioClip burpClip;

    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void DragonSniff()
    {
        source.clip = sniffClip;
        source.Play();
    }

    public void DragonLaugh()
    {
        source.clip = laughClip;
        source.Play();
    }

    public void DragonRoar()
    {
        source.clip = roarClip;
        source.Play();
    }

    public void DragonFire()
    {
        source.clip = fireClip;
        source.Play();
    }

    public void DragonBite()
    {
        source.clip = biteClip;
        source.Play();
    }

    public void DragonBurp()
    {
        source.clip = burpClip;
        source.Play();
    }
}

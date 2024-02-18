using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // public string name;
    public static AudioManager instance;
    public GameObject prefeb;

    public AudioClip xu;
    public AudioSource xusuoc;
    
    public AudioClip chem;
    public AudioSource chemsuoc;
    
    public AudioClip nhay;
    public AudioSource nhaysuoc;
    
    public AudioClip qvdie;
    public AudioSource qvdiesuoc;

    public AudioClip nen;
    public AudioSource nensuoc;
    private void Awake()
    {
        instance = this;
    }

    public void PlaySoud(AudioClip clip, float volum, bool islookback)
    {
        if ( clip== this.nen)
        {
            Play(clip, ref nensuoc, volum, islookback);
        }
    }

    public void PlaySoud(AudioClip clip, float volum)
    {
        if (clip==this.nhay)
        {
            Play(clip,ref nhaysuoc,volum);
            return;
        }
        if (clip==this.xu)
        {
            Play(clip,ref xusuoc,volum);
            return;
        }
        if (clip==this.chem)
        {
            Play(clip,ref chemsuoc,volum);
            return;
        }
        if (clip==this.qvdie)
        {
            Play(clip,ref qvdiesuoc,volum);
            return;
        }
        if (clip==this.nen)
        {
            Play(clip,ref nensuoc,volum);
            return;
        }
    }

    private void Play(AudioClip clip, 
        ref AudioSource audiosource, float volum, bool islookback =false)
    {
        if (audiosource !=null&& audiosource.isPlaying)
        {
            
            return;
        }

        audiosource = Instantiate(instance.prefeb).GetComponent<AudioSource>();
        audiosource.volume = volum;
        audiosource.loop = islookback;
        audiosource.clip = clip;
        audiosource.Play();
        Destroy(audiosource.gameObject,audiosource.clip.length);
        
    }

    public void stopSoud(AudioClip clip)
    {
        if (clip==this.chem)
        {
            chemsuoc?.Stop(); return;
            
        }
        if (clip==this.xu)
        {
            xusuoc?.Stop(); return;
            
        }
        if (clip==this.nhay)
        {
            nhaysuoc?.Stop(); return;
            
        }
        if (clip==this.qvdie)
        {
            qvdiesuoc?.Stop(); return;
            
        }
        if (clip==this.nen)
        {
            nensuoc?.Stop(); return;
            
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanger : MonoBehaviour
{
    // public string name;
    public static audiomanger instance;
    public GameObject prefeb;

    public AudioClip xu;
    private AudioSource xusuoc;
    
    public AudioClip chem;
    private AudioSource chemsuoc;
    
    public AudioClip nhay;
    private AudioSource nhaysuoc;
    
    public AudioClip qvdie;
    private AudioSource qvdiesuoc;

    public AudioClip nen;
    private AudioSource nensuoc;
    
    public AudioClip bosgau;
    private AudioSource bosgausuoc;
    
    public AudioClip dibo;
    private AudioSource dibosuoc;
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
        if (clip==this.bosgau)
        {
            Play(clip,ref bosgausuoc,volum);
            return;
        }
        if (clip==this.dibo)
        {
            Play(clip,ref dibosuoc,volum);
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
        if (clip == this.chem)
        {
            chemsuoc?.Stop();
            return;

        }

        if (clip == this.xu)
        {
            xusuoc?.Stop();
            return;

        }

        if (clip == this.nhay)
        {
            nhaysuoc?.Stop();
            return;

        }

        if (clip == this.qvdie)
        {
            qvdiesuoc?.Stop();
            return;

        }

        if (clip == this.nen)
        {
            nensuoc?.Stop();
            return;

        }
        if (clip == this.bosgau)
        {
            bosgausuoc?.Stop();
            return;

        }
        if (clip==this.dibo)
        {
            dibosuoc?.Stop(); return;

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


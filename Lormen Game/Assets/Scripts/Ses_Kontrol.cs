using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ses_Kontrol : MonoBehaviour
{
    public Sesler[] sesler;
    private Oyun_Mekanik Player;

    private void Awake()
    {
        foreach(var s in sesler)
        {
            Player = FindObjectOfType<Oyun_Mekanik>();
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.loop = s.loop;
        }
    }
    void Start()
    {
        Play("arkaplan");
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play(string name)
    {
        Sesler s = Array.Find(sesler, sesler => sesler.name == name);
        s.source.Play();
    }
    public void Stop(string name)
    {
        Sesler s = Array.Find(sesler, sesler => sesler.name == name);
        s.source.Stop();
    }
}

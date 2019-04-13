using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    public Sound[] sounds;

    public static AudioManager instance;

    //private void Awake()
    //{
    //    if (instance == null)
    //        instance = this;
    //
    //    foreach(Sound s in sounds)
    //    {
    //        s.source = gameObject.AddComponent<AudioSource>();
    //        s.source.clip = s.clip;
    //        s.source.volume = s.volume;
    //        s.source.pitch = s.pitch;
    //        s.source.loop = s.Loop;
    //    }
    //
    //}
    //
    //public void Play()
    //{
    //    Sound s = Array.Find(sounds, sound => sound.name == name);
    //    if (s == null)
    //    {
    //        Debug.LogWarning("Sound: " + name + " not found!");
    //        return;
    //    }
    //    else
    //    {
    //      s.source.Play();
    //    }
    //
    //   
    //}

    void Start()
    {
        for(int i = 0; i  < sounds.Length; i ++)
        {
            GameObject _soundobject = new GameObject("Sound " + i + " " + sounds[i].name);

            sounds[i].SetSource(_soundobject.AddComponent<AudioSource>());
        }
    }

    public void PlaySound(string SoundName)
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if(sounds[i].name == SoundName)
            {
                sounds[i].Play();
                return;
            }
        }

        // has not found any sound with the name
        Debug.Log("Sound not found");
    }


}

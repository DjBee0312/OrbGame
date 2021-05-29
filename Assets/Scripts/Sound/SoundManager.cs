using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Sound[] sounds;
    
    public static SoundManager instance;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        
        DontDestroyOnLoad(gameObject);
        
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.volume = s.volume;
            s.source.clip = s.clip;

            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        Play("MainTheme");
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s?.source.Play();
    }

    public void OnSoundButtonClick()
    {
        foreach (var sound in sounds)
        {
            sound.source.volume = sound.source.volume != 0f ? 0f : sound.volume;
        }
    }
}

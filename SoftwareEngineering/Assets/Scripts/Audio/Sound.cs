using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    //// name of the clip
    //public string name;
    //// the actual audio clip used
    //public AudioClip clip;
    //
    //// volume of the cound clip
    //[Range(0.0f, 1f)]
    //public float volume;
    //
    //// pitch of the sound clip
    //[Range(0.1f, 3f)]
    //public float pitch;
    //
    //public bool Loop;
    //
    //[HideInInspector]
    //public AudioSource source;

    public string name;
    public AudioClip clip;

    [Range(0f, 1f)]
    public float Volume = 0.7f;
    [Range(0f, 1f)]
    public float Pitch = 1f;




    private AudioSource source;

    public void SetSource(AudioSource _source)
    {
        source = _source;
        source.clip = clip;
    }

    public void Play()
    {
        source.volume = Volume;
        source.pitch = Pitch;
        source.Play();
    }

}

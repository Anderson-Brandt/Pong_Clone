using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource audioSource;
    public static AudioController currentAudio;

    public AudioClip points;
    public AudioClip pongPlatform;
    public AudioClip pong;

    // Start is called before the first frame update
    void Start()
    {
        currentAudio = this;

        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}

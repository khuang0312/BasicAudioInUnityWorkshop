using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Code referenced:
    // https://www.youtube.com/watch?v=8pFlnyfRfRc

    public static AudioClip jumpSound, crappyMusic, thinkingMusic;
    public static AudioSource audioSrc;

    

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        // audio clip must be located in resources folder
        jumpSound = Resources.Load<AudioClip>("jump_sound");
        crappyMusic = Resources.Load<AudioClip>("crappy_song");
        thinkingMusic = Resources.Load<AudioClip>("thinking");

        audioSrc = GetComponent<AudioSource>();
    }

    private void Start()
    {
        audioSrc.loop = true;
        audioSrc.clip = thinkingMusic;
        audioSrc.Play();
        // audioSrc.PlayOneShot(thinkingMusic);
    }

    // static so other scripts can easily access this method
    public static void playSound(string clipName)
    {
        switch (clipName)
        {
            case "jump_sound":
                audioSrc.PlayOneShot(jumpSound);
                break;
            default:
                break;
        }

    }
}

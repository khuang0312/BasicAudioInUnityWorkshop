using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    // the pause menu object must be hidden by default...

    public GameObject pauseMenu; // makes it easier to set inactive or active
    public GameObject volumeSlider; 
    public GameObject muteToggle;

    public static bool paused = false; // needed to check if game is paused


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            paused = !paused;
            pauseMenu.SetActive(paused);
        }

        Toggle mute = muteToggle.GetComponent<Toggle>();
        SoundManager.audioSrc.mute = mute.isOn;

        Slider volControl = volumeSlider.GetComponent<Slider>();
        SoundManager.audioSrc.volume = volControl.value;
    }
}

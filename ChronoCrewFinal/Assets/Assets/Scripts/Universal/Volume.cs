using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class Volume : MonoBehaviour
{

    // The following is used in conjunction with the slider in the settings menu to adjust the master volume for the game.
    public new AudioMixer audio;

    // This will set the master volume of the game so that the music will play throughout each level / menu at the same volume.
    public void SetVolume(float volume)
    {

        audio.SetFloat("mastervolume", Mathf.Log10(volume)*20);

    }

}

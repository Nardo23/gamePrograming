using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolumeValueChange : MonoBehaviour
{

    // Reference to Audio Source component
    private AudioSource audioSrc;

    private float musicVolume;

    // Music volume variable that will be modified
    // by dragging slider knob



    // Use this for initialization
    void Start()
    {

        // Assign Audio Source component to control it
        audioSrc = GetComponent<AudioSource>();
        musicVolume = PlayerPrefs.GetFloat("volume");
    }

    // Update is called once per frame
    void Update()
    {

        // Setting volume option of Audio Source to be equal to musicVolume
        audioSrc.volume = PlayerPrefs.GetFloat("volume");
    }

    // Method that is called by slider game object
    // This method takes vol value passed by slider
    // and sets it as musicValue
    public void SetVolume(float vol)
    {
        PlayerPrefs.SetFloat("volume", vol);
        musicVolume = PlayerPrefs.GetFloat("volume");

    }
}

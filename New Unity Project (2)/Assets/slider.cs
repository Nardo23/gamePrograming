using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class slider : MonoBehaviour
    
{
    public float slidePosition;
    void Start()
    {
        slidePosition= PlayerPrefs.GetFloat("volume");
    }
}

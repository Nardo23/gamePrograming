using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class load_game_scene : MonoBehaviour
{
    public void gameScene()
    {
        SceneManager.LoadScene("gamescene");
    }
    
}

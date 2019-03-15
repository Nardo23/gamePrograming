using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class manager : MonoBehaviour
{
    public int score;
    public int lives;
    public Text display; 

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        display.text = "Score: " + score + "\nLives: " + lives; 
        if (lives == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}

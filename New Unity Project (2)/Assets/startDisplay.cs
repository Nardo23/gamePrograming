using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startDisplay : MonoBehaviour
{
    public Text display;
    string highScoreKey = "0";
    int highScore;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            highScoreKey = ("HighScore" + (i + 1)).ToString();

            highScore = PlayerPrefs.GetInt(highScoreKey, 0);

        }
            display.text = "High Scores" +"\n 1: " + PlayerPrefs.GetInt("HighScore1")
              + "\n 2: " + PlayerPrefs.GetInt("HighScore2")
              + "\n 3: " + PlayerPrefs.GetInt("HighScore3")
              + "\n 4: " + PlayerPrefs.GetInt("HighScore4")
              + "\n 5: " + PlayerPrefs.GetInt("HighScore5")
              + "\n 6: " + PlayerPrefs.GetInt("HighScore6")
              + "\n 7: " + PlayerPrefs.GetInt("HighScore7")
              + "\n 8: " + PlayerPrefs.GetInt("HighScore8")
              + "\n 9: " + PlayerPrefs.GetInt("HighScore9")
              + "\n 10: " + PlayerPrefs.GetInt("HighScore10");
    }

   
}

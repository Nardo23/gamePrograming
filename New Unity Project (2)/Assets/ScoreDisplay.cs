using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreDisplay : MonoBehaviour
{
    int score;
    
    public Text display;
    string highScoreKey = "0";
    int highScore;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("currentScore");

        //check highscores 


        for (int i = 0; i < 10; i++)
        {
            highScoreKey = ("HighScore" + (i + 1)).ToString();

            highScore = PlayerPrefs.GetInt(highScoreKey, 0);

            if (score > highScore)
            {
                int old = highScore;
                Debug.Log("slot "+(i+1).ToString() +":  "+old.ToString());

                PlayerPrefs.SetInt(highScoreKey, score);

                score = old;
                Debug.Log(score.ToString());
            }

            

        }

        //shows score 
        score = PlayerPrefs.GetInt("currentScore");
        display.text = "Score: " + score
            + "\n 1: " + PlayerPrefs.GetInt("HighScore1")
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

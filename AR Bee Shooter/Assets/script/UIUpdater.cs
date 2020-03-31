using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIUpdater : MonoBehaviour
{
    public GameObject UI;
    public GameObject End;
    public Text scoretext;
    public Text HighScore;
    public Text Score;
    public Text Timer;

    public void setTimer(float t) {Timer.text = ((int)t).ToString(); }

    public void setScore(int s) { Score.text = s.ToString(); }


    public void EndGame() {
        if (PlayerPrefs.GetInt("score") < int.Parse(Score.text))
        {
            Debug.Log("in");
            PlayerPrefs.SetInt("score", int.Parse(Score.text));
            HighScore.text = "New Personal Best: " + PlayerPrefs.GetInt("score").ToString();

        }
        else {
            Debug.Log("out");

            HighScore.text = "Personal Best: " + PlayerPrefs.GetInt("score").ToString();
        }
        UI.SetActive(false);
        End.SetActive(true);
        scoretext.text = "Score: " + Score.text;
    }
}

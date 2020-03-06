using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIUpdater : MonoBehaviour
{
    public GameObject UI;
    public GameObject End;
    public Text scoretext;
    public Text Score;
    public Text Timer;

    public void setTimer(float t) {Timer.text = ((int)t).ToString(); }

    public void setScore(int s) { Score.text = s.ToString(); }


    public void EndGame() {
        UI.SetActive(false);
        End.SetActive(true);
        scoretext.text = "Score: " + Score.text;
    }
}

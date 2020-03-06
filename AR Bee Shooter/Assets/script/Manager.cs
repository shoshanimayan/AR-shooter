using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{



    private float timer =60f;
    private int score = 0;
    private UIUpdater UI;
    public bool playing;
    public Text scoretext;
    //public GameObject EndCanvas;
    //public GameObject UICanvas;
    // Start is called before the first frame update
    void Awake()
    {
        UI = GetComponent<UIUpdater>();
        UI.setScore(score);
        UI.setTimer(timer);
        playing = true;
    }

    public void IncreaseScore() {
        score += 1;
        UI.setScore(score);

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 0)
        {
            playing = false;
            //EndCanvas.SetActive(true);
            //UICanvas.SetActive(false);
            //scoretext.text=
        }
        if (!playing)
            UI.EndGame();
        else {
            timer -= Time.deltaTime;
            UI.setTimer(timer);

        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour,IPointerDownHandler
{
    public enum button { end, reset }
    public button btn;
    public void OnPointerDown(PointerEventData eventData)
    {
        switch (btn)
        {
            case (button.end):
                SceneManager.LoadScene(1);
                break;
            case (button.reset):
                SceneManager.LoadScene(2);
                break;

        }
    }
}

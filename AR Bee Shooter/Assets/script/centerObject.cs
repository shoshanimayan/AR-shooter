using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class centerObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "menu") { Destroy(gameObject); }

        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetKeyDown(KeyCode.Space))
        {
            transform.parent.transform.DetachChildren();
            
            SceneManager.LoadScene(2);
        }
       //     transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 4, transform.position.z));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class preload : MonoBehaviour
{
    public GameObject session;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(session);

        SceneManager.LoadScene(1);

    }


}

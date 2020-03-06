using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class shoot : MonoBehaviour
{

    private ARSessionOrigin aROrigin;
    private ARRaycastManager m_RaycastManager;
    private Manager manager;
    private AudioManager AS;

    private void Awake()
    {
        manager = GetComponent<Manager>();
        AS = GetComponent<AudioManager>();
    }

    private void Update()
    {
        //var screenCenter = Camera.main.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        //Ray ray = Camera.main.ScreenPointToRay(screenCenter);
        RaycastHit[] hits;
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetKeyDown(KeyCode.Space)) {
            AS.play("shoot");
            hits = Physics.RaycastAll(Camera.main.transform.position, Camera.main.transform.forward, 100.0f);
            
                if (hits.Length > 0)
                {

                GameObject hit = hits[0].transform.gameObject;
                    if (hit.transform.tag == "enemy") {
                        manager.IncreaseScore();
                        hit.gameObject.GetComponent<enemyBeehavior>().kill();
                        AS.play("shoot");



}

                }
            

        }


    }


}



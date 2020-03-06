using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBeehavior : MonoBehaviour
{
    Transform arCamera;
    public Manager manage;
    public float speed;
    private Vector3 direction;
    private float timer = 0;
    public float change;
    public GameObject explode;
    // Start is called before the first frame update
    private void Awake()
    {
        manage = GameObject.Find("manager").GetComponent<Manager>();

        arCamera = Camera.main.gameObject.transform;
        change = Random.Range(.5f,3f);
        speed = Random.Range(1f,5f);
        direction = direction = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);
    }


    //if bee hits other bee, bounce in opposite direction
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "enemy") { direction = direction * -1; }
    }

//randomize movement, within certain boundry
    void UpdateDirection()
    {
        if (transform.position.y > 2)//not to high
            direction = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 0), 0);

        else if (transform.position.y < -2)// not to low
            direction = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(0f, 1), 0);
        else
            direction = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f),0);
    }

    //keep be facing and circling player
    void UpdateRatation()
    {
        // Vector3 that points from plane to camera
        Vector3 relativePos = arCamera.position - transform.position;
        // Quaternion that faces that direction
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        // Current rotation
        Quaternion current = transform.rotation;
        // Interpolate from current rotation to new rotation
        transform.rotation = Quaternion.Slerp(current, rotation, Time.deltaTime * 100);
    }

    // Update is called once per frame
    void Update()
    {
        //kill if time is over, play if not
        if (manage.playing)
        {
            UpdateRatation();
            //change direction at time
            if (timer > change)
            {
                UpdateDirection();
                timer = 0;
            }
            else
            {
                timer += Time.deltaTime*4;
            }
            transform.Translate(direction*Time.deltaTime*speed);

        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void kill() {
        gameObject.SetActive(false);
      // Instantiate(explode, transform.position, transform.rotation);
        Destroy(gameObject);
    }


    
}

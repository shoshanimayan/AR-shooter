using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    private Manager manage;
    public GameObject enemyPref;
    [SerializeField]
    public static int spawned = 0;
    public float spawnTime;
    private float timer=0;
    private Vector3 position;
    // Start is called before the first frame update
    void Awake()
    {
        timer = spawnTime;
        manage = GameObject.Find("manager").GetComponent<Manager>();
        position = new Vector3(transform.position.x, transform.position.y, transform.position.z - .7f);
    }

    // Update is called once per frame
    void Update()
    {
        if (manage.playing )
        {

            if (timer >= spawnTime && spawned <= 30)
            {
                spawn();
                timer = 0;
            }
            else
                timer += Time.deltaTime;
        }
        else
        {
            spawned = 0;
            Destroy(gameObject);
        }
    }

   

    void spawn() {
        
        Instantiate(enemyPref, position, transform.rotation);
        spawned++;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource AS;
    // Start is called before the first frame update
    private void Awake()
    {
        AS= GetComponent<AudioSource>();
    }

    public void play(string name)
    {
        AudioClip s=null;

        foreach (AudioClip sound in sounds) 
            if (sound.name == name)
                s = sound;
        if (s != null)
            AS.PlayOneShot(s);
        else
            Debug.Log("name does not exist in sound list");
    }


    private void Update()
    {
        if (spawner.spawned > 0)
            AS.Play();
        else
            AS.Pause();
    }
}

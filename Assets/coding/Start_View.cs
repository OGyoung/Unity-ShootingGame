using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_View : MonoBehaviour
{
   // private AudioSource audio_source;
   // public AudioClip start_sound;
    // Start is called before the first frame update
    void Start()
    {
      //  audio_source = gameObject.AddComponent<AudioSource>();
        //audio_source.clip = start_sound;
        //audio_source.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Game_View", LoadSceneMode.Single);
        }
    }
}

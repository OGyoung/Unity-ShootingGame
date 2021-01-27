using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_monster : MonoBehaviour
{
    public float spawn_rate = 3.0f;
    private float spawn_time = 0;
    public GameObject monster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawn_time += Time.deltaTime;
        if (spawn_time > spawn_rate)
        {
            spawn_time = 0;
            Instantiate(monster, this.transform.position, this.transform.rotation);
        }
    }
}

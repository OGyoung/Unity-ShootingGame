using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections;

public class Destroy_Self : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 4.0f);
        if (this.gameObject.tag == "explosion")
        {
            Destroy(gameObject, 1.0f);
        }
        if (this.gameObject.tag=="Player")
        {
            Destroy(gameObject, 0.5f);
        }
        if (this.gameObject.tag == "Ultimate")
        {
            Destroy(gameObject, 0.2f);
        }
        if (this.gameObject.tag == "poison")
        {
            Destroy(gameObject, 4.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

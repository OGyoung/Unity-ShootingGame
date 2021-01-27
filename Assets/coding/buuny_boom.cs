using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buuny_boom : MonoBehaviour
{
    public Transform boom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Target")
        {
            Instantiate(boom, this.transform.position, this.transform.rotation);
        }
    }
}

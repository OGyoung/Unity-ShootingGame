using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_move : MonoBehaviour
{
    private float target_speed = 30.0f;
    private float rot_speed = 120.0f;
    //public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.LookAt(target);

        float distance_per_frame = target_speed * Time.deltaTime;
        float degrees_per_frame = rot_speed * Time.deltaTime;

        float moving_velocity = Input.GetAxis("Vertical");
        float target_angle = Input.GetAxis("Horizontal");

        this.transform.Translate(Vector3.forward * moving_velocity * distance_per_frame);
        this.transform.Rotate(0.0f, target_angle * degrees_per_frame, 0.0f);
    }
}

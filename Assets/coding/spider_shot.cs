using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spider_shot : MonoBehaviour
{
    [SerializeField]
    private float power1 = 500.0f;
    private float power2 = 1000.0f;
    private float elapsed_time = 0.0f;
    public float fire_interval = 0.1f;
    public Transform bullet1;
    public Transform bullet2;   
    public Transform sp_point1;
    public Transform sp_point2;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //감지선 낮추는 작업
        Vector3 sp_position = sp_point1.transform.position;
        Vector3 Ray = new Vector3(sp_position.x, 0.7f, sp_position.z);

        this.transform.LookAt(target);   
        elapsed_time += Time.deltaTime;
        RaycastHit hit;

        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        Debug.DrawRay(Ray, fwd * 150, Color.green);

        if (Physics.Raycast(Ray, fwd, out hit, 1000) == false
            || hit.collider.gameObject.tag != "Target"
            || elapsed_time < fire_interval)
        {
            return;
        }  
        
        Debug.Log(hit.collider.gameObject.name);     
        Transform enemy_bullet1 = Instantiate(bullet1, Ray, Quaternion.identity);        
        enemy_bullet1.GetComponent<Rigidbody>().AddForce(fwd * power1);

        Transform enemy_bullet2 = Instantiate(bullet2, sp_point2.transform.position, Quaternion.identity);
        enemy_bullet2.GetComponent<Rigidbody>().AddForce(fwd * power2);
        elapsed_time = 0.0f;
    }
}

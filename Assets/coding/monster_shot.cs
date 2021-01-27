using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_shot : MonoBehaviour
{
    [SerializeField]
    private float power = 1200.0f;
    private float elapsed_time = 0.0f;
    public float fire_interval = 2.0f;
    public Transform bullet;
    public GameObject target;
    public Transform sp_point;



    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player Variant");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(target.transform);
        elapsed_time += Time.deltaTime;

        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        Debug.DrawRay(sp_point.transform.position, fwd * 20, Color.green);

        if (Physics.Raycast(sp_point.transform.position, fwd, out hit, 20) == false
            || hit.collider.gameObject.tag != "Target"
            || elapsed_time < fire_interval)
            return;

        Debug.Log(hit.collider.gameObject.name);

        Transform enemy_bullet = Instantiate(bullet, sp_point.transform.position, Quaternion.identity);
        enemy_bullet.GetComponent<Rigidbody>().AddForce(fwd * power);
        elapsed_time = 0.0f;

    }
}
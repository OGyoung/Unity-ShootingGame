using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class monster_move : MonoBehaviour
{
    public float rot_angle = 15.0f;
    public UnityEngine.AI.NavMeshAgent agent;
    public GameObject target;

    void Start()
    {
        target = GameObject.Find("Player Variant");
    }

    void Update()
    {
        MoveToTarget();

    }
    void MoveToTarget()
    {
        agent.SetDestination(target.transform.position);
    }
}

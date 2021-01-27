using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 총알에 맞았을때 생기는 이펙트
public class bullet_effect : MonoBehaviour
{
    
    public Transform explosion;
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
        //유저가 맞을때 몬스터가 사용할 부분
        if (this.gameObject.tag=="bullet")
        {
            if (other.gameObject.tag == "Target")
            {
                Instantiate(explosion, this.transform.position, this.transform.rotation);
            }

        }
        //몬스터가 맞을때 유저가 사용할 부분
        if(this.gameObject.tag=="player_bullet")
        {
            if (other.gameObject.tag == "Spider" || other.gameObject.tag == "Enemy"
            || other.gameObject.tag == "bullet")
            {
                Instantiate(explosion, this.transform.position, this.transform.rotation);
            }
        }
        
    }
}

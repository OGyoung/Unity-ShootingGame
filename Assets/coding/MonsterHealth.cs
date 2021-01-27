using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHealth : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;
    private float curHp = 3;
    public float monster_health = 3;

    float imsi;

    private AudioSource audio_source;
    public AudioClip hurt_clip;
    // Start is called before the first frame update
    void Start()
    {
        audio_source = this.GetComponent<AudioSource>();
        audio_source.clip = hurt_clip;
        hpbar.value = (float)curHp / (float)monster_health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player_bullet")
        {
            audio_source.Play();

            if (curHp > 0)
            {
                Destroy(other.gameObject);
                curHp -= 1;
            }
            else
            {
                Destroy(this.gameObject);
            }
            imsi = (float)curHp / (float)monster_health;
            HandleHp();
        }

    }
    private void HandleHp()
    {
        /*
         그냥 체력바가 줄게하는 코드
        hpbar.value = (float)curHp / (float)maxHp;
        */
        //게이지가 좀 더 부드럽게 줄게 선형보간을 이용
        hpbar.value = Mathf.Lerp(hpbar.value, imsi, Time.deltaTime * 10);

    }
}

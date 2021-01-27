using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    [SerializeField]
    //Slider변수 선언
    private Slider hpbar;
    private float curHp = 500;  
    public float boss_health = 500;
    
    float imsi;
    private AudioSource audio_source;
    // Start is called before the first frame update
    void Start()
    {
        audio_source = this.GetComponent<AudioSource>();

        hpbar.value = (float)curHp / (float)boss_health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // GameObject.Find("Player Variant");
    void OnTriggerEnter(Collider other)
    {
       

        if (other.gameObject.tag == "player_bullet")
        {
            audio_source.Play();
            if (curHp > 0)
            {
                Destroy(other.gameObject);
                curHp -= 10;
            }
            else
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene("Win_View", LoadSceneMode.Single);
            }
            imsi = (float)curHp / (float)boss_health;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerStat : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;
    [SerializeField]
    private Slider shieldbar;

    public float max_hp = 5;
    public float curHp = 5;

    public int max_shield = 5;
    public int curShield = 5;

    public bool ultimate = true;
    public bool ultimate_on = false;
    public float charging_time;
    public float shield_fix;

    public float bullet_power = 2000.0f;
    public Transform bullet;
    public GameObject barrel;
    public GameObject ultimate_effect;
    


    private float fire_time = 0.0f;
    private float reload_time = 0.2f;

    public AudioClip hurt;
    private AudioSource audio_source;


    // Start is called before the first frame update
    void Start()
    {
        audio_source = this.GetComponent<AudioSource>();
        hpbar.value = (float)curHp / (float)max_hp;
        shieldbar.value = (float)curShield / (float)max_shield;
        ultimate_effect.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (ultimate)
            {
                ultimate = false;
                ultimate_on = true;

                //ultimate_effect.gameObject.SetActive(true);
                
                if(ultimate_on == true)
                {
                    ultimate_effect.gameObject.SetActive(true);
                }                       
                reload_time = 0.1f;
                charging_time = 0.0f;
            }
        }
        //ultimate_effect.gameObject.SetActive(false);

        charging_time += Time.deltaTime;

        if (!ultimate)
        {
            if (charging_time >= 3)
            {
                reload_time = 0.2f;
                ultimate_on = false;
                ultimate_effect.gameObject.SetActive(false);
            }
            if (charging_time >= 5)
            {
                ultimate = true;
            }
        }

        //shield
        if (shield_fix >= 3)
        {
            if (curShield < 5)
            {
                curShield++;
                shield_fix = 0;
                HandleShield();
            }
        }
        shield_fix += Time.deltaTime;

        fire_time += Time.deltaTime;
        if (Input.GetButton("Fire1") && fire_time > reload_time)
        {
            GameObject spawn_point = GameObject.Find("GunBarrelEnd");
            spawn_point.GetComponent<AudioSource>().Play();
            Transform prefab_bullet = Instantiate(bullet, spawn_point.transform.position, spawn_point.transform.rotation);
            prefab_bullet.GetComponent<Rigidbody>().AddForce(barrel.transform.forward * bullet_power);
            fire_time = 0.0f;
        }
    }

    private void OnGUI()
    {
        if (ultimate) GUI.Label(new Rect(10, Screen.height - 90, 128, 32), "Ultimate Ready");
        else GUI.Label(new Rect(10, Screen.height - 90, 128, 32), "Ultimate Charging");

        if (ultimate_on) GUI.Label(new Rect(10, Screen.height - 120, 128, 32), "Invincible: " + (3.0f - charging_time).ToString());

    }

    void OnTriggerEnter(Collider other)
    {
        //총알 삭제 및 bunny 자폭
        if (other.gameObject.tag == "bullet")
        {
            Destroy(other.gameObject);
            if (ultimate_on) return;
            audio_source.Play();

            if (curShield > 0)
            {
                curShield--;
                shield_fix = 0;
            }
            else
            {
                curHp--;
            }


            HandleHp();
            HandleShield();
        }
        // 충돌시 실드 및 체력 낮추기
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Spider")
        {
            if (ultimate_on) return;

            audio_source.Play();

            if (curShield > 0)
            {
                curShield--;
                shield_fix = 0;
            }
            else
            {
                curHp--;
            }
            HandleHp();
            HandleShield();
        }

        if (curHp <= 0)
        {
            SceneManager.LoadScene("Lose-View", LoadSceneMode.Single);
        }

    }

    private void HandleHp()
    {
        hpbar.value = (float)curHp / (float)max_hp;
    }

    private void HandleShield()
    {
        shieldbar.value = (float)curShield / (float)max_shield;
    }
}
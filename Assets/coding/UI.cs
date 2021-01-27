using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    //Slider변수 선언
    private Slider hpbar;
    private float maxHp = 100;
    private float curHp = 100;
    float imsi;
    // Start is called before the first frame update
    void Start()
    {
      hpbar.value= (float)curHp / (float)maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(curHp>0)
            {
                curHp -= 10; 
            }
            else
            {
                curHp = 0;
            }
            imsi = (float)curHp / (float)maxHp;
        }
        HandleHp();
    }

    private void HandleHp()
    {
        /*
         그냥 체력바가 줄게하는 코드
        hpbar.value = (float)curHp / (float)maxHp;
        */
        //게이지가 좀 더 부드럽게 줄게 선형보간을 이용
        hpbar.value = Mathf.Lerp(hpbar.value, imsi, Time.deltaTime*10);
        
    }
}

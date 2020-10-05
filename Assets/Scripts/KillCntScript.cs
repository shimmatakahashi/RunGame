using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCntScript : MonoBehaviour
{
    public Text killCnt;
    public static int killValue = 0;
    Text cnt;
    // Start is called before the first frame update
    void Start()
    {
        cnt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        cnt.text = "Kill" + killValue;
    }
}

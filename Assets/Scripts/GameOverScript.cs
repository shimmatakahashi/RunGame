using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    int heartNum;
    GameObject[] HeartObj;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        HeartObj = GameObject.FindGameObjectsWithTag("HeartTag");
        heartNum = HeartObj.Length;

        if (heartNum == 0)
        {
            this.gameObject.GetComponent<Text>().enabled = true;

        }
    }

      
}

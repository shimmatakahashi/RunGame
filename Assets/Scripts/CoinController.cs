using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    int heartNum;
    GameObject[] HeartObj;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5);
        HeartObj = GameObject.FindGameObjectsWithTag("HeartTag");
        heartNum = HeartObj.Length;

        if(heartNum == 0)
        {
            this.gameObject.SetActive(false);
        }



    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        

        if(collision.gameObject.tag == "PlayerTag")
        {
            
            Destroy(gameObject);
            ScoreScript.scoreValue += 10;

            AudioSource.PlayClipAtPoint(audioClip, transform.position);
            
        }

    }
   
}

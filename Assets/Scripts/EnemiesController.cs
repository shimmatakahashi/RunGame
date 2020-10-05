using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
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
        HeartObj = GameObject.FindGameObjectsWithTag("HeartTag");
        heartNum = HeartObj.Length;

        if (this.gameObject.transform.position.y < -7)
        {
            Destroy(gameObject);
        }

        

        if(heartNum == 0)
        {
            this.gameObject.SetActive(false);
        }



    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BulletTag")
        {
            Destroy(this.gameObject);
            KillCntScript.killValue += 1;

            AudioSource.PlayClipAtPoint(audioClip, transform.position);
           
        }

        if(collision.gameObject.tag == "PlayerTag")
        {
            Destroy(gameObject);
        }
    }
}

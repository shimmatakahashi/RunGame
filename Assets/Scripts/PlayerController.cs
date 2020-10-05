using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    
    private new Rigidbody2D rigidbody2D;
    private BoxCollider2D boxCollider2D;

    public float flap;
    public Vector2 SPEED = new Vector2(0.08f, 0.08f);
    private float movableRange = 12f;
    private bool isJumping = false;

    int heartNum;
    GameObject[]HeartObj;

    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && isJumping == false)
        {
            rigidbody2D.AddForce(Vector2.up * flap);
            isJumping = true;
        }

        Move();

        
    }

    void Move()
    {
        Vector2 Position = transform.position;

        if (Input.GetKey(KeyCode.LeftArrow) && -this.movableRange < this.transform.position.x)
        {

            Position.x -= SPEED.x;

        } else if (Input.GetKey(KeyCode.RightArrow) && this.movableRange > this.transform.position.x)
        
        {
          
            Position.x += SPEED.x;

        }

        transform.position = Position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("GroundTag"))
        {
            isJumping = false;
        }

        HeartObj = GameObject.FindGameObjectsWithTag("HeartTag");
        heartNum = HeartObj.Length;

        if (collision.gameObject.CompareTag("EnemyTag") && heartNum == 3)
            
                {
                    Destroy(GameObject.Find("Heart1"));
                }

        if (collision.gameObject.CompareTag("EnemyTag") && heartNum == 2)

        {
            Destroy(GameObject.Find("Heart2"));
        }

        if (collision.gameObject.CompareTag("EnemyTag") && heartNum == 1)

        {
            Destroy(GameObject.Find("Heart3"));
            this.gameObject.SetActive(false);
        }

        if(collision.gameObject.CompareTag("EnemyTag"))
        {
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
        }
    }


}

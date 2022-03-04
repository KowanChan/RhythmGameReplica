using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fowardMovement : MonoBehaviour
{
    public bool hit;
    public BoxCollider2D bc;
    public Rigidbody2D rb2d;
    private bool TopDown = false;
    private bool BotDown = false;
    public float TopTimer = 0.0f;
    public float BotTimer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        hit = false;
    }

    void Update()
    {
        if(hit == false)
        {
            rb2d.velocity = new Vector2(-5.0f, 0.0f);
        }

        if (Input.GetKeyDown("e"))
        {
            BotDown = true;
            BotTimer = 0.1f;
        }

        if (Input.GetKeyDown("i"))
        {
            TopDown = true;
            TopTimer = 0.1f;
        }
           
        if (TopTimer <= 0)
        {
            TopDown = false;
        }

        if (BotTimer <= 0)
        {
            BotDown = false;
        }

        BotTimer -= Time.deltaTime;
        TopTimer -= Time.deltaTime;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!hit)
        {
            if (gameObject.tag == "BotTarget" && BotDown)
            {
                hit = true;
                rb2d.gravityScale = 1;
                rb2d.AddForce(new Vector2(0.0f, 4.0f), ForceMode2D.Impulse);
                rb2d.AddTorque(200.0f);
                bc.isTrigger = true;
            }

            if (gameObject.tag == "TopTarget" && TopDown)
            {
                hit = true;
                rb2d.gravityScale = 1;
                rb2d.AddForce(new Vector2(0.0f, 4.0f), ForceMode2D.Impulse);
                rb2d.AddTorque(200.0f);
                bc.isTrigger = true;
            }
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

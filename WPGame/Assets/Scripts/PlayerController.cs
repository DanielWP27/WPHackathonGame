using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    public string xAxis;
    public string yAxis;
    Rigidbody2D player;
    SpriteRenderer playerRend;
    public static float speed = 5;
    private int playerDirection;
    private Sprite[] sprites;

    // Use this for initialization
    void Start()
    {

        player = GetComponent<Rigidbody2D>();
        playerRend = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        playerRend.flipX = false;
  
        playerDirection = 0;
        sprites = Resources.LoadAll<Sprite>("Sprites");

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float x = Input.GetAxis(xAxis);
        float y = Input.GetAxis(yAxis);

        player.velocity = new Vector2(x * speed, y * speed);

        if (Mathf.Abs(player.velocity.x) > 0 || Mathf.Abs(player.velocity.y) > 0)
        {
            //animator.SetBool("Walking", true);
        }
        else
        {
            //animator.SetBool("Walking", false);
        }

        if (Mathf.Abs(player.velocity.x) > Mathf.Abs(player.velocity.y))
        {
            if (player.velocity.x > 0)
            {
                playerDirection = 0;
                animator.SetInteger("Direction", 3);
                //playerRend.sprite = Resources.Load<Sprite>("Sprites/RagerRight");
            }
            else if (player.velocity.x < 0)
            {
                playerDirection = 1;
                animator.SetInteger("Direction", 1);
                //playerRend.sprite = Resources.Load<Sprite>("Sprites/RagerLeft");
            }
        }
        else if (Mathf.Abs(player.velocity.x) < Mathf.Abs(player.velocity.y))
        {
            if (player.velocity.y > 0)
            {
                playerDirection = 2;
                animator.SetInteger("Direction", 2);
                //playerRend.sprite = Resources.Load<Sprite>("Sprites/RagerBack");
            }
            else if (player.velocity.y < 0)
            {
                playerDirection = 3;
                animator.SetInteger("Direction", 0);
                //playerRend.sprite = Resources.Load<Sprite>("Sprites/Rager");
            }
        }


       // if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 0"))


    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    public string xAxis;
    public string yAxis;
    Rigidbody2D player;
    public static float speed = 5;
    private int playerDirection;
    GameObject[] computers;
    GameObject[] exclamations;

    // Use this for initialization
    void Start()
    {

        player = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerDirection = 0;
        computers = GameObject.FindGameObjectsWithTag("Computer");

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        exclamations = GameObject.FindGameObjectsWithTag("Exclamation");

        Vector3 position = transform.position;
        foreach(GameObject exc in exclamations)
        {
            foreach (GameObject pc in computers)
            { 
                float diff = Vector3.Distance(pc.transform.position, position);
                float exc_dist = Vector3.Distance(exc.transform.position, position);
                if (diff < 1 && exc_dist < 3)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        print("SELECTED!");
                    }
                }
            }
        }

        float x = Input.GetAxis(xAxis);
        float y = Input.GetAxis(yAxis);

        player.velocity = new Vector2(x * speed, y * speed);

       /*if (Mathf.Abs(player.velocity.x) > 0 || Mathf.Abs(player.velocity.y) > 0)
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }*/

        if (Mathf.Abs(player.velocity.x) > Mathf.Abs(player.velocity.y))
        {
            if (player.velocity.x > 0)
            {
                playerDirection = 0;
                animator.SetInteger("Direction", 3);
            }
            else if (player.velocity.x < 0)
            {
                playerDirection = 1;
                animator.SetInteger("Direction", 1);
            }
        }
        else if (Mathf.Abs(player.velocity.x) < Mathf.Abs(player.velocity.y))
        {
            if (player.velocity.y > 0)
            {
                playerDirection = 2;
                animator.SetInteger("Direction", 2);
            }
            else if (player.velocity.y < 0)
            {
                playerDirection = 3;
                animator.SetInteger("Direction", 0);
            }
        }


       // if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 0"))


    }

}

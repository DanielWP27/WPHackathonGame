using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject backgroundOffice;
    public GameObject player1;
    public GameObject player2;
    public GameObject computer;
    // Use this for initialization
    void Start()
    {

    }

    public void LevelInit()
    {
        Instantiate((backgroundOffice), new Vector2(0.1F, -0.68F), new Quaternion());
        Instantiate((player1), new Vector2(-3.79785F, -0.3743634F), new Quaternion());
        Instantiate((player2), new Vector2(3.665133F, -0.3743634F), new Quaternion());
        Instantiate((computer), new Vector2(3.7F, 2.45F), new Quaternion());
        Instantiate((computer), new Vector2(3.7F, -3.25F), Quaternion.Euler(0,0,180));
        Instantiate((computer), new Vector2(6.7F, -0.5F), Quaternion.Euler(0, 0, 270));
        Instantiate((computer), new Vector2(0.6F, -0.5F), Quaternion.Euler(0, 0, 90));
        Instantiate((computer), new Vector2(-1.24F, -0.5F), Quaternion.Euler(0, 0, 270));
        Instantiate((computer), new Vector2(-6.35F, -0.5F), Quaternion.Euler(0, 0, 90));
        Instantiate((computer), new Vector2(-3.7F, 2.45F), Quaternion.Euler(0, 0, 0));
        Instantiate((computer), new Vector2(-3.7F, -3.25F), Quaternion.Euler(0, 0, 180));
    }

    // Update is called once per frame
    void Update()
    {

    }
}

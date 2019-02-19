using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject backgroundOffice;
    public GameObject player1;
    public GameObject player2;
    // Use this for initialization
    void Start()
    {

    }

    public void LevelInit()
    {
        Instantiate((backgroundOffice), new Vector2(0.1F, -0.68F), new Quaternion());
        Instantiate((player1), new Vector2(-3.79785F, -0.3743634F), new Quaternion());
        Instantiate((player2), new Vector2(3.665133F, -0.3743634F), new Quaternion());
    }

    // Update is called once per frame
    void Update()
    {

    }
}

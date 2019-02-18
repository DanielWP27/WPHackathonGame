using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    private LevelManager levelScript;

    // Use this for initialization
    void Start()
    {

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        levelScript = GetComponent<LevelManager>();

        InitGame();
    }

    void InitGame()
    {
        levelScript.LevelInit();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

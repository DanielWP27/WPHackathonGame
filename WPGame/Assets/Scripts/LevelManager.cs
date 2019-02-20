using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //background
    public GameObject backgroundOffice;
    //floor
    public GameObject computer;
    //player
    public GameObject player1;
    public GameObject player2;
    //overlay
    public GameObject exclamation;
    float timer = 5F;

    List<Exclamation> exclamations = new List<Exclamation>();

    class Exclamation
    {
        public float x, y;
        public int z;
        public Exclamation(float x, float y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    // Use this for initialization
    void Start()
    {
        exclamations.Add(new Exclamation(7.2F, 0.5F, 0));
        exclamations.Add(new Exclamation(0F, 0.5F, 0));
        exclamations.Add(new Exclamation(3.67F, 4F, 0));
        exclamations.Add(new Exclamation(3.75F, -4.8F, 180));

        exclamations.Add(new Exclamation(-0.75F, 0.5F, 0));
        exclamations.Add(new Exclamation(-7F, 0.5F, 0));
        exclamations.Add(new Exclamation(-3.74F, 4F, 0));
        exclamations.Add(new Exclamation(-3.65F, -4.8F, 180));
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

        ////These are positions for later use for where the exclamations go////
        ////Right Support Room
        //Instantiate((exclamation), new Vector2(7.2F, 0.5F), Quaternion.Euler(0, 0, 0));
        ////Left Support Room
        //Instantiate((exclamation), new Vector2(0F, 0.5F), Quaternion.Euler(0, 0, 0));
        ////Top Support Room
        //Instantiate((exclamation), new Vector2(3.67F, 4F), Quaternion.Euler(0, 0, 0));
        ////Bottom Support Room
        //Instantiate((exclamation), new Vector2(3.75F, -4.8F), Quaternion.Euler(0, 0, 180));

        ////Right R&D Room
        //Instantiate((exclamation), new Vector2(-0.75F, 0.5F), Quaternion.Euler(0, 0, 0));
        ////Left R&D Room
        //Instantiate((exclamation), new Vector2(-7F, 0.5F), Quaternion.Euler(0, 0, 0));
        ////Top R&D Room
        //Instantiate((exclamation), new Vector2(-3.74F, 4F), Quaternion.Euler(0, 0, 0));
        ////Bottom R&D Room
        //Instantiate((exclamation), new Vector2(-3.65F, -4.8F), Quaternion.Euler(0, 0, 180));

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            RandomExclamation();
            timer = 5F;
        }
    }

    void RandomExclamation()
    {
        int exclamation_random = Random.Range(1, 16);
        if(exclamation_random >= 8)
        {
            int choice = exclamation_random - 8;

            float x = exclamations[choice].x;
            float y = exclamations[choice].y;
            int z = exclamations[choice].z;

            Instantiate((exclamation), new Vector2(x, y), Quaternion.Euler(0, 0, z));
        }
    }

    public GameObject DestroyAndStoreExclamation(GameObject exc)
    {
        GameObject result = exc;
        Destroy(exc);
        return result;
    }
}

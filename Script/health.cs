using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{

    public int health_=100;

    public Animator ainm;

    public GameObject restart_menu;
    public GameObject joystick;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (health_ <= 0)
        {
            ainm.Play("dead");

            player_dead();
            Destroy(gameObject, 3f);
        }
    }


   void player_dead()
    {
        if(gameObject.name == "Player")
        {
            joystick.SetActive(false);
            restart_menu.SetActive(true);
        }
    }
    
}

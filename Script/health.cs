using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{

    public int health_=100;

    public Animator ainm;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health_ <= 0)
        {
            ainm.Play("dead");
            Destroy(gameObject, 3f);
        }
    }

    
}

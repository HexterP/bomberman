using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    Transform player;              
    public float enemyHealth;
    NavMeshAgent nav; 


    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
     
        nav = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        transform.LookAt(player);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    Transform player;              
    public float enemyHealth;
    NavMeshAgent nav;
    public Animator anim;
    public Transform fire_point;
    public GameObject Grenades;
    public float speed_Grenades = 1.0f;
    public float dealy_Grenades = 2.0f;
    public float attack_distance = 10.0f;
    bool attack=false;
    float currentTime = 0;

    void Start()
    {
        currentTime = Time.time + dealy_Grenades;
    }

    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
        StartCoroutine(InfiniteLoop());
    }


    void Update()
    {
        transform.LookAt(player);


    }

    IEnumerator create_Grenades()
    {
        yield return new WaitForSeconds(0.7f);
        GameObject Grenades_ = Instantiate(Grenades, fire_point.position, fire_point.rotation);
        Grenades_.GetComponent<Rigidbody>().velocity = transform.forward * speed_Grenades;
    }


    private IEnumerator InfiniteLoop()
    {
        WaitForSeconds waitTime = new WaitForSeconds(dealy_Grenades);
        while (true)
        {
            if(player != null)
            {
                float dist = Vector3.Distance(transform.position, player.position);
                if (dist <= attack_distance)
                {
                    anim.Play("grenade");
                    StartCoroutine(create_Grenades());
                    Debug.Log("grenade.");
                    yield return waitTime;
                }
            }
        }
    }
}

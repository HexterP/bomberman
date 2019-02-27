using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenades : MonoBehaviour
{
    public float targetTime = 60.0f;
    public GameObject explode;
    public GameObject wave;
    public float blastRadius = 10.0f;
    public float explosionForce = 700.0f;
    void Update()
    {

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        Instantiate(explode, transform.position, transform.rotation);
        //Instantiate(wave, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, blastRadius);

        foreach(Collider nearby in colliders)
        {
            Rigidbody rb = nearby.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(explosionForce,transform.position, blastRadius);
            }

            health health_actor = nearby.GetComponent<health>();
            if(health_actor != null)
            {
                health_actor.health_ -= 50;
            }
            Debug.Log(nearby.gameObject.name);
        }
        Destroy(gameObject);
    }
}

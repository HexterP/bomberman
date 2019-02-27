using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenades : MonoBehaviour
{
    public float targetTime = 60.0f;
    public GameObject explode;

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
        Destroy(gameObject);
    }
}

using System.Collections;
using UnityEngine;


public class Player3DExample : MonoBehaviour {

    public float moveSpeed = 8f;
    public Joystick joystick;
    public Transform fire_point;
    public GameObject Grenades;
    public Animator anim;
    public float speed_Grenades = 1.0f;

    int idleHash = Animator.StringToHash("idle");
    int grenadeHash = Animator.StringToHash("grenade");
    int runHash = Animator.StringToHash("run");
    bool fire=true;

	void Update () 
	{
        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);

        if (moveVector != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveVector);
            transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
            anim.Play("run");
            fire = false;
        }
        else
        {
            if (fire == false)
            {
                Debug.Log("grenade");
                fire = true;
                anim.Play("grenade");
                StartCoroutine(create_Grenades());
            }
            else
            {
             //   anim.Play("idle");
            }
        }

    }

    IEnumerator create_Grenades()
    {
        yield return new WaitForSeconds(0.7f);
        GameObject Grenades_ = Instantiate(Grenades, fire_point.position, fire_point.rotation);
        Grenades_.GetComponent<Rigidbody>().velocity = transform.forward * speed_Grenades;
    }

}
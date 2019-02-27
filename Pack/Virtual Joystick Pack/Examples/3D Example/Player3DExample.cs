using UnityEngine;

public class Player3DExample : MonoBehaviour {

    public float moveSpeed = 8f;
    public Joystick joystick;
    public Transform fire_point;
    public GameObject Grenades;
    public Animator anim;

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
                Debug.Log("fire");
                Instantiate(Grenades, fire_point.position, fire_point.rotation);
                fire = true;

                anim.Play("grenade");
            }
            else
            {
             //   anim.Play("idle");
            }
        }
	}
}
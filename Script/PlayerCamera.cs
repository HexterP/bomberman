using UnityEngine;
using System.Collections;

[AddComponentMenu("Camera/3RDPerson Camera")]
public class PlayerCamera : MonoBehaviour
{

    public GameObject objectToFollow;

    public float speed = 2.0f;
    public float height = 2.0f;
    public float z_offset = -2.0f;

    private void Update()
    {
        
    }
    void FixedUpdate()
    {
        float interpolation = speed * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.y = height;
        position.x = Mathf.Lerp(this.transform.position.x, objectToFollow.transform.position.x, interpolation);
        position.z = Mathf.Lerp((this.transform.position.z- z_offset), objectToFollow.transform.position.z, interpolation);

        this.transform.position = position;
       // this.transform.LookAt(objectToFollow.transform);
    }


}
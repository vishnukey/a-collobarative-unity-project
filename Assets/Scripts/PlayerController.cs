using System.Collections;
using System.Collections.Generic;
using /*import*/ UnityEngine;

public class PlayerController : /*extends*/ MonoBehaviour
{
    /*
     * public
     * private (default)
     * protected
     */

    public float speed;
    public float height;
    public float rotationSpeed;
    public LayerMask groundMask;

    // Start is called before the first frame update
    void Start()
    {
        /*GetComponent<COMPONET_TYPE>()*/
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit data; 

        if(Physics.Raycast(transform.position, -transform.up, out data, Mathf.Infinity,groundMask))
        {
            print(data.normal);
            //transform.Rotate(Quaternion.FromToRotation(transform.up, data.normal).eulerAngles);
            transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation * Quaternion.FromToRotation(transform.up, data.normal), Time.deltaTime*rotationSpeed);
            
            transform.position += transform.up * (height - data.distance);
                //transform.position = Vector3.Slerp(transform.position, transform.up, t);

            
        }

        if (Input.GetKey("w"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            transform.position += -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position += -transform.right * speed * Time.deltaTime;
        }
    }
}

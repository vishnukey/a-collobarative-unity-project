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

    // Start is called before the first frame update
    void Start()
    {
        /*GetComponent<COMPONET_TYPE>()*/
    }

    // Update is called once per frame
    void Update()
    {
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

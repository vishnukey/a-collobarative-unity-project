using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    Material mat;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;    

    }

    private void OnTriggerEnter(Collider other)
    {
        i++;
        if(other.CompareTag("Ball") || other.CompareTag("Pin"))
        {
            Destroy(other.gameObject);
            //mat.color = Color.green;

            if (i > 3)
            {
                // You can re-use this block between calls rather than constructing a new one each time.
                var block = new MaterialPropertyBlock();

                // You can look up the property by ID instead of the string to be more efficient.
                block.SetColor("_BaseColor", Color.green);

                // You can cache a reference to the renderer to avoid searching for it.
                GetComponent<Renderer>().SetPropertyBlock(block);
            }
        }
    }

}

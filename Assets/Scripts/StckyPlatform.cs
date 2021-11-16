using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StckyPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.parent = transform;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.parent = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

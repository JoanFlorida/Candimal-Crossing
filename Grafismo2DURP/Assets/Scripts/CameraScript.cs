using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public float        camSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate( Vector3.left * camSpeed * Time.deltaTime);
        }
        if ( Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate( Vector3.right * camSpeed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            transform.position = new Vector3(0, 0.1f, 0);
            transform.rotation = Quaternion.Euler(Vector3.forward * 0.2f);
        }
    }
}

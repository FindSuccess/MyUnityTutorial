using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement(); 
    }

    void Movement()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        if(x != 0)
        {
            gameObject.transform.position += Vector3.right * x;
        }

        if(y != 0)
        {
            gameObject.transform.position += Vector3.up * y;
        }
    }
}

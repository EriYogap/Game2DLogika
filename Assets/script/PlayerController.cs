using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int inputID;
    float horizontalInput;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        if (horizontalInput != 0)
        {
            Vector3 movment = Vector3.right * Time.deltaTime * horizontalInput * 10;
            if (transform.position.x <= -8.2 && horizontalInput < 0)
            {
                movment = Vector3.zero;
            }
            if (transform.position.x >= 8.2 && horizontalInput > 0)
            {
                movment = Vector3.zero;
            }
            transform.Translate(movment);
        }
        
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed = 10.0f;

    [SerializeField]
    private float rotateSpeed = 10.0f;
        
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.right * moveSpeed * Time.deltaTime;    
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += -transform.right * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * -rotateSpeed, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * rotateSpeed, Space.World);
        }
    }
}

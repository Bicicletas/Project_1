using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed = 70.0f;
    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        //transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
    }

}

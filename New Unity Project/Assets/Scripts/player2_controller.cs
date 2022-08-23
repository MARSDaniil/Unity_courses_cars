using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2_controller : MonoBehaviour
{
    private float speed = 10f;
    private float turn_speed = 10f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal2");
        forwardInput = Input.GetAxis("Vertical2");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turn_speed * horizontalInput * Time.deltaTime);

    }
}


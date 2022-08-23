using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1_controller : MonoBehaviour
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
        horizontalInput = Input.GetAxis("Horizontal1");
        forwardInput = Input.GetAxis("Vertical1");
        transform.Translate(Vector3.forward*Time.deltaTime*speed* forwardInput);
        transform.Rotate(Vector3.up, turn_speed*horizontalInput*Time.deltaTime);

    }
}

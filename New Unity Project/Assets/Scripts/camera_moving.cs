using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_moving : MonoBehaviour
{
    public GameObject player;
    private Vector3 view1 = new Vector3(0, 5, -7);
    private Vector3 view2 = new Vector3(0, 5, 0);

    private bool switch_camera = true; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            switch_camera = !switch_camera;
        }
        if (switch_camera == false)
        {
            transform.position = player.transform.position + view2;
        }
        else
        {
            transform.position = player.transform.position + view1;
        }
    }
}

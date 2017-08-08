using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 0;
    public float recoverspeed = 0;
    public float speed_limit= 0;
    private Rigidbody rb;
    private float control_limit = 0.1f;
    private float current_speed;
    private float RightHorizontal,RightVertical,LeftHorizontal,LeftVertical;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update () {
        // get input data from xbox360 controller
        // float LeftHorizontal = Input.GetAxis("Left X");
        // float LeftVertical = Input.GetAxis("Left Y");
        // float RightHorizontal = Input.GetAxis("Right X");
        // float RightVertical = Input.GetAxis("Right Y");
        LeftHorizontal = 0f;
        LeftVertical = 0f;
        RightHorizontal= 0f;
        RightVertical = 0f;

        if (Input.GetKey(KeyCode.UpArrow)) RightVertical = 1f;
        if (Input.GetKey(KeyCode.DownArrow)) RightVertical = -1f;
        if (Input.GetKey(KeyCode.LeftArrow)) RightHorizontal= -1f;
        if (Input.GetKey(KeyCode.RightArrow)) RightHorizontal= 1f;       

        if (Input.GetKey(KeyCode.L)) LeftHorizontal = 1f;
        if (Input.GetKey(KeyCode.J)) LeftHorizontal = -1f;
        if (Input.GetKey(KeyCode.W)) LeftVertical = 1f;
        if (Input.GetKey(KeyCode.S)) LeftVertical = -1f;
        Debug.Log(LeftHorizontal);

        // get speed
        current_speed = rb.velocity.magnitude;
        // Debug.Log(current_speed);
        // Left Controller
        if (Mathf.Abs(LeftVertical) > control_limit && current_speed < speed_limit) 
        {
            rb.AddForce(Vector3.up * LeftVertical * speed * Time.deltaTime, ForceMode.Acceleration);
            rb.AddTorque(Vector3.up * LeftHorizontal * 100 * speed * Time.deltaTime, ForceMode.Acceleration);
            // Debug.Log("LeftVer"); Debug.Log(LeftVertical);
            Debug.Log("LeftHor"+LeftHorizontal);
        }

        // Right Controller
        rb.AddForce(Vector3.forward * RightVertical * speed * Time.deltaTime, ForceMode.Acceleration);

        // if pull right or left
        if (Mathf.Abs(RightHorizontal) > control_limit && current_speed < speed_limit) 
        {
            // add right dir force to the plane to move right
            Vector3 right = transform.right - Vector3.Dot(Vector3.up, transform.right) * Vector3.up;
            right = right/right.magnitude;
            rb.AddForce(right * RightHorizontal * speed * Time.deltaTime, ForceMode.Acceleration);
            rb.AddTorque(transform.forward * (-1) * RightHorizontal * Time.deltaTime, ForceMode.Acceleration);
        }
        // recover the lean of plane
        else if (Vector3.Dot(transform.right, Vector3.up) < 0)
        {
            rb.AddTorque(transform.forward * Time.deltaTime * recoverspeed, ForceMode.Acceleration);
        }
        else if (Vector3.Dot(transform.right, Vector3.up) > 0) 
        {
            rb.AddTorque(transform.forward * (-1) * Time.deltaTime * recoverspeed, ForceMode.Acceleration);
        }


        // if pull up or down
        if (Mathf.Abs(RightVertical) > control_limit && current_speed < speed_limit) 
        {
            Vector3 forward = transform.forward - Vector3.Dot(Vector3.up, transform.right) * Vector3.up;
            forward = forward / forward.magnitude;
            rb.AddForce(forward * RightVertical * speed * Time.deltaTime, ForceMode.Acceleration);
            rb.AddTorque(transform.right * RightHorizontal * Time.deltaTime, ForceMode.Acceleration);
        }
        // recover the lean of plane
        else if (Vector3.Dot(transform.forward, Vector3.up) < 0)
        {
            rb.AddTorque(transform.right * (-1) * Time.deltaTime * recoverspeed, ForceMode.Acceleration);
        }
        else if (Vector3.Dot(transform.forward, Vector3.up) > 0)
        {
            rb.AddTorque(transform.right * Time.deltaTime * recoverspeed, ForceMode.Acceleration);
        }

    }
}
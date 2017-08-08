using UnityEngine;
using System.Collections;

public class BasicControll : MonoBehaviour {
    public int speed = 0;
    public Rigidbody rb;
    public Transform tf;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
        gameObject.AddComponent<GlobalVariable>();
	}

	// Update is called once per frame
	void Update () {
        GlobalVariable now = GetComponent<GlobalVariable>();
        // now.test();

        if (!now.myQuadCtlnColDetection())
        {
            float moveHori = Input.GetAxis("Horizontal");
            float moveVert = Input.GetAxis("Vertical");
            now.myUpdate(rb, tf, moveHori, moveVert, speed);
        }
	}
}

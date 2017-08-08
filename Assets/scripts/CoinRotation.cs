using UnityEngine;
using System.Collections;

public class CoinRotation : MonoBehaviour {

    public float scale = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float z = (Time.time/scale - Mathf.Floor(Time.time/scale)) * 360.0f;
        gameObject.GetComponent<Transform>().eulerAngles = new Vector3(90, 0, z);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour {

	// Use this for initialization
	Image win;
	void Start () {
		gameObject.AddComponent<GlobalVariable>();
		// win=GameObject.Find("Win");
		win=GetComponentInChildren<Image>();
		win.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		bool isEnd=gameObject.GetComponent<GlobalVariable>().returnIsGameEnd();
		if (isEnd==true) win.enabled=true;
	}
}

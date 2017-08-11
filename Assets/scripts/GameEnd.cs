using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour {

	// Use this for initialization
	// Image win;
	public GameObject sBoard;
	public GameObject reStart;
	private string str="No.";
	void Start () {
		gameObject.AddComponent<GlobalVariable>();
		// sBoard = GameObject.Find("scoreBoard");
		// win=GameObject.Find("Win");
		// win=GetComponentInChildren<Image>();
		// win.enabled = false;
		sBoard.SetActive(false);
		reStart.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		bool isEnd=gameObject.GetComponent<GlobalVariable>().returnIsGameEnd();
		if (isEnd==true) 
		{
			// win.enabled=true;
			sBoard.SetActive(true);
			reStart.SetActive(true);
		}
		else 
		{
			sBoard.SetActive(false);
			reStart.SetActive(false);
			// Debug.Log("AAAAA");
		}
	}
}

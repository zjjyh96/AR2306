using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getScore : MonoBehaviour {

private Text[] txt;
	// Update is called once per frame
	void Update () {
		txt=GetComponentsInChildren<Text>();
		txt[0].text=GetComponent<GlobalVariable>().returnScore().ToString();
	}
}

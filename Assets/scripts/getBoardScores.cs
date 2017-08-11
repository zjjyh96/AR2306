using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getBoardScores : MonoBehaviour {

	public GameObject n1,n2,n3,n4,n5;
	private Text t1,t2,t3,t4,t5;

	// Use this for initialization
	void Start () {
		t1=n1.GetComponent<Text>();
		t2=n2.GetComponent<Text>();
		t3=n3.GetComponent<Text>();
		t4=n4.GetComponent<Text>();
		t5=n5.GetComponent<Text>();
		gameObject.AddComponent<GlobalVariable>();
		
	}
	
	// Update is called once per frame
	void Update () {
		changeForm(t1,gameObject.GetComponent<GlobalVariable>().returnTimeRecords(0));
		changeForm(t2,gameObject.GetComponent<GlobalVariable>().returnTimeRecords(1));
		changeForm(t3,gameObject.GetComponent<GlobalVariable>().returnTimeRecords(2));
		changeForm(t4,gameObject.GetComponent<GlobalVariable>().returnTimeRecords(3));
		changeForm(t5,gameObject.GetComponent<GlobalVariable>().returnTimeRecords(4));

	}

	void changeForm(Text t, double timeSpend)
	{
		// if (timeSpend==0) 
		// {
		// 	t.text = "";
		// 	return;
		// }
		if (timeSpend==gameObject.GetComponent<GlobalVariable>().returnPlayTime())
		{
			t.color = Color.blue;
		}
		else t.color = Color.black;
		int hour = (int)timeSpend / 3600;  
        int minute = ((int)timeSpend - hour * 3600) / 60;  
        int second = (int)timeSpend - hour * 3600 - minute * 60;  
    	int millisecond = (int)((timeSpend - (int)timeSpend) * 1000);  
        // text_timeSpend.text = string.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", hour, minute, second, millisecond); 

		t.text = string.Format("{0:D2}:{1:D2}.{2:D3}", minute, second, millisecond);
	}

}

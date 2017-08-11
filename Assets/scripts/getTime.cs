using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class getTime : MonoBehaviour {
	int hour,minute,second,millisecond;  
  	double timeSpend;
    Text text_timeSpend;  

    // Use this for initialization  
    void Start () {  
		gameObject.AddComponent<GlobalVariable>();
		gameObject.GetComponent<GlobalVariable>().initPlayTime();
        text_timeSpend = GetComponent<Text>();  
    }  
      
    // Update is called once per frame  
    void Update () {  
		timeSpend=gameObject.GetComponent<GlobalVariable>().returnPlayTime();
        // GlobalSetting.timeSpent = timeSpend;  
        hour = (int)timeSpend / 3600;  
        minute = ((int)timeSpend - hour * 3600) / 60;  
        second = (int)timeSpend - hour * 3600 - minute * 60;  
        millisecond = (int)((timeSpend - (int)timeSpend) * 1000);  
        // text_timeSpend.text = string.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", hour, minute, second, millisecond);  
		text_timeSpend.text = string.Format("{0:D2}:{1:D2}.{2:D3}", minute, second, millisecond);  
    }  
}

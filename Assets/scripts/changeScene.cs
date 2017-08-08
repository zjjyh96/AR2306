using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class changeScene : MonoBehaviour {
	public Button yourButton;
	private Button btn;
    void Start()
    {
        btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(switchScene);
    }

    void switchScene()
    {
		Text txt;
		txt=btn.GetComponentInChildren<Text>();
		string str=txt.text.ToString();
		// Debug.Log(str);

		if (str=="Start") SceneManager.LoadScene("LevelSelection");
		else if (str=="Level 1") SceneManager.LoadScene("Main");
		else if (str=="Level 2") SceneManager.LoadScene("LV2");
		else if (str=="Restart") SceneManager.LoadScene("Main");
		
		// else if (txt.text=="Setting") SceneManager.LoadScene("LevelSelection");
		// else if (txt.text=="Records") SceneManager.LoadScene("scoreBoard");

    }
}


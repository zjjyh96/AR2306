using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	public Animator anim;
	
		
	void Start () {
		anim = gameObject.GetComponent<Animator>();
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			anim.SetTrigger("open");
		}
		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			anim.SetTrigger("close");
		}		
		}
		
	}
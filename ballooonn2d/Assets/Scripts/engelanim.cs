using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelanim : MonoBehaviour {
	
	public Animator animengel;


	void OnTriggerEnter2D(Collider2D info)
	{
		if (info.tag == "Player") {

			animengel.SetBool ("yakındamı", true);
		} 
	}

	void OnTriggerExit2D(Collider2D info)
	{
		if (info.tag == "Player") {

			animengel.SetBool ("yakındamı", false);
		} 
	}

}


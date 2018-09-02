using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {

	public GameObject player;
	public Transform cameratr;
	public AnimationCurve acr;



	private Vector3 fark;


	void Start () {

		fark = transform.position - player.transform.position;
	}



	// Update is called once per frame
	void FixedUpdate () {
		


		transform.position = Vector3.Lerp(transform.position, (player.transform.position + fark),acr.Evaluate(Time.deltaTime));



	}
}

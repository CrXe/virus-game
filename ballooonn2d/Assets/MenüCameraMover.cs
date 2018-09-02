using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenüCameraMover : MonoBehaviour {


	public AnimationCurve acr;
	public GameObject dummyToFallow;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = Vector3.Lerp (transform.position, dummyToFallow.transform.position, acr.Evaluate (Time.deltaTime));
		
	}


	public void SendDummyToMainMenü ()
	{
		dummyToFallow.transform.position = new Vector3 (0, 0, dummyToFallow.transform.position.z);
	}

	public void SendDummyToMutation ()
	{
		dummyToFallow.transform.position = new Vector3 (6.88f, 0, dummyToFallow.transform.position.z);
	}
}

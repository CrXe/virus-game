using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public Rigidbody2D rb;

	public string zıplamatus = "Jump";
	public string dönmetus="Horizontal";
	public Transform trplyr;
	public Vector2 yatayhız = new Vector2(100,0);
	public Vector2 dikeyhız = new Vector2 (0, 100);
	public bool abasılımı = false;
	public bool dbaslılımı= false;
	public Animator anim;

    void Start ()

	{
		abasılımı = false;
		dbaslılımı = false;

	}


	void FixedUpdate ()
	{
		rb.AddForce (yatayhız,ForceMode2D.Force);

	}


	void Update () {


		if (((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) || Input.GetButtonDown (zıplamatus))) {
			rb.AddForce (dikeyhız, ForceMode2D.Impulse);
			anim.SetBool ("zıplamabasılımı", true);
		} else {
			anim.SetBool ("zıplamabasılımı", false);
		}

		if (Input.GetKey (KeyCode.A)) {
			abasılımı = true;
		} else {
			abasılımı = false;
		}
			
		if (Input.GetKey (KeyCode.D)) {
			dbaslılımı = true;
		} else {
			dbaslılımı = false;
		}


		if (abasılımı == true) {
		trplyr.Rotate (Vector3.forward, 2);
		}

		if (dbaslılımı == true) {
		trplyr.Rotate (Vector3.forward, -2);
		}




	}
}

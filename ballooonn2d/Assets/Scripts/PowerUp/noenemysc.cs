
using UnityEngine;
using UnityEngine.UI;

public class noenemysc : MonoBehaviour {

	public SaveSc savesc;
	private float blastradius;
	public bool isblastactive;
	public CircleCollider2D circlecollider;
	public Button noenemybutton;
	public GameObject noenemybuttonga;

	private float noenemycd;

	public float[] noEnemyCdByLevel;




	void Start () {
		noenemybutton.interactable = true;
		isblastactive = false;
		circlecollider.enabled = false;


		if (savesc.noenemypr == 0) {
			noenemybutton.interactable = false;
			noenemybuttonga.SetActive (false);
		}
		else
			noenemycd = noEnemyCdByLevel[savesc.noenemypr-1];
		



		
	}
	
	// Update is called once per frame

	void FixedUpdate () {
		noenemybutton.image.fillAmount += 0.02f / noenemycd;
		}

	public void Activeblast ()
	{
		isblastactive = true;
		noenemybutton.interactable = false;
		Invoke ("Setnoenemybuttonactive", noenemycd+1);
		Invoke ("StopBlast", 1);
		circlecollider.enabled = true;


	}


	public void StopBlast()
	{
		isblastactive = false;
		circlecollider.enabled = false;
		noenemybutton.image.fillAmount = 0;
	}

	void Setnoenemybuttonactive()
	{
		noenemybutton.interactable = true;
	}


}


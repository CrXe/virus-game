using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tavanzeminreducedmg : MonoBehaviour {



	public SaveSc savesc;
	public carpma carpma;

	//0-1 arasında olmak zorunda
	public float dmgReduxlevel1=0.9f;
	public float dmgReduxlevel2=0.8f;
	public float dmgReduxlevel3=0.7f;
	public float dmgReduxlevel4=0.6f;



	void Start ()
	{

		if (savesc.dmgredux == 0) {
			carpma.tavanzemindmg = 1;
		}

		if (savesc.dmgredux == 1) {
			carpma.tavanzemindmg = 1*dmgReduxlevel1;
		}
		if (savesc.dmgredux == 2) {
			carpma.tavanzemindmg = 1*dmgReduxlevel2;
		}
		if (savesc.dmgredux == 3) {
			carpma.tavanzemindmg = 1*dmgReduxlevel3;
		}
		if (savesc.dmgredux == 4) {
			carpma.tavanzemindmg = 1*dmgReduxlevel4;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

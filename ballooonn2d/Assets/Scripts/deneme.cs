using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deneme : MonoBehaviour {

	public SaveSc savesc;
	public int protein;
	public Text text;




	// Update is called once per frame
	void Update () {

		text.text ="Protein: "+ savesc.protein.ToString ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menügm : MonoBehaviour {

	public Transform maincube;

	public bool mutasyonagit = false;
	public bool enfeksiyonagit = false;
	public bool anamenüyegit= false;
	public float MenüRotationSpeed= 0.1f;


	 void Start ()
	{
		
	}

	void Update ()
	{
		if (mutasyonagit == true) {
			maincube.rotation= Quaternion.Slerp(maincube.rotation,Quaternion.Euler(0,90,0),MenüRotationSpeed);
			enfeksiyonagit = false;
			anamenüyegit = false;
			}
		if (maincube.rotation == Quaternion.Euler(0, 90, 0)) {
			mutasyonagit = false;
		}


		if (enfeksiyonagit == true) {
			maincube.rotation= Quaternion.Slerp(maincube.rotation,Quaternion.Euler(0,-90,0),MenüRotationSpeed);
			anamenüyegit = false;
			mutasyonagit = false;

			}

		if (maincube.rotation == Quaternion.Euler(0, -90, 0)) {
			enfeksiyonagit = false;
		}


		if (anamenüyegit == true) {
			maincube.rotation= Quaternion.Slerp(maincube.rotation,Quaternion.Euler(0,0,0),MenüRotationSpeed);
			enfeksiyonagit = false;
			mutasyonagit = false;
		}
		if (maincube.rotation == Quaternion.Euler(0, 0, 0)) {
			anamenüyegit = false;
		}


	



	}

	public void Anamenü()
	{
		anamenüyegit = true;
	}



	public void EnfeksiyonMenü ()
	{
		enfeksiyonagit = true;
	}

	public void MutasyonMenü ()
	{
		mutasyonagit = true;
	}


	 void StartLevel1 ()
	{
	SceneManager.LoadScene (1);
	}


	




}

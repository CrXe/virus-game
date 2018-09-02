using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {


	public GameObject[] objeler;




	void Start () {

		int rand = Random.Range (0, objeler.Length);
		Instantiate (objeler [rand], transform.position, Quaternion.identity);
		
	}
	

}

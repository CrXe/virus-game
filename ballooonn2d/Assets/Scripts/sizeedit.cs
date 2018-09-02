using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class sizeedit : MonoBehaviour {

	public Transform playertr;
	public Slider slidersize;



	void Start () {


		
	}
	

	void Update () {
		slidersize.value = playertr.localScale.x;

		
	}
}

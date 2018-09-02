using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnetsc : MonoBehaviour {




	public CircleCollider2D circlecollider;
	public float magnetradius;
	public SaveSc savesc;

	public float level1magnetradius;
	public float level2magnetradius;
	public float level3magnetradius;
	public float level4magnetradius;



	void Start () {

		circlecollider.enabled = true;

		if (savesc.magnetpr == 0) {
			circlecollider.enabled = false;
		}

		if (savesc.magnetpr == 1) {
			magnetradius = level1magnetradius;
		}
		if (savesc.magnetpr == 2) {
			magnetradius = level2magnetradius;
		}
		if (savesc.magnetpr == 3) {
			magnetradius = level3magnetradius;
		}
		if (savesc.magnetpr == 4) {
			magnetradius = level4magnetradius;
		}

		circlecollider.radius = magnetradius;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

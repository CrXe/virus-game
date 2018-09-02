using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushersc : MonoBehaviour {


	public SaveSc savesc;
	public CircleCollider2D circlecollider;
	public float pushradius;

	public float level1pusherradius;
	public float level2pusherradius;
	public float level3pusherradius;
	public float level4pusherradius;


	void Start () {

		circlecollider.enabled = true;

		if (savesc.pusherpr == 0) {
			circlecollider.enabled = false;
		}

		if (savesc.pusherpr == 1) {
			pushradius = level1pusherradius;
		}
		if (savesc.pusherpr == 2) {
			pushradius = level2pusherradius;
		}
		if (savesc.pusherpr == 3) {
			pushradius = level3pusherradius;
		}
		if (savesc.pusherpr == 4) {
			pushradius = level4pusherradius;
		}

		circlecollider.radius = pushradius;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelcarpma : MonoBehaviour {

	public EdgeCollider2D bcengel;
	public Transform trengel;
	public bool yokol =false;
	public GameObject player;
	public GameObject sprites;
	public Animator animengelplus;





	private float engeluzunlukx;
	private float engelgenişliky;
	[Range(0,20)]
	public float engeltütle;

	public PlayerShield playershield;
	public bool yokolwithshield;
	public bool uzaklaş;
	public Vector3 uzaklaşmamiktarı;
	public ParticleSystem particleEnemy;


	void Start() {
		yokolwithshield = false;


	
		player = GameObject.FindWithTag("Player");

	}

	void Update () {
		uzaklaşmamiktarı = trengel.transform.position - player.transform.position;

		if (trengel.lossyScale.x <= 0 ) {
			tamamenyokol ();
		}

		if (yokol == true && trengel.lossyScale.x >0 ) {
			trengel.transform.localScale -= new Vector3 (1,1,1)*Time.deltaTime;
			trengel.transform.position = Vector2.Lerp (trengel.transform.position, player.transform.position, Time.deltaTime*3f);
		}

		if (yokolwithshield == true) {
			trengel.transform.localScale -= new Vector3 (1,1,1)*Time.deltaTime;
		}


		if (uzaklaş == true) {
			trengel.transform.position = Vector3.Lerp (trengel.transform.position, uzaklaşmamiktarı + trengel.transform.position, Time.deltaTime * 0.2f);
			
		}



	}


	public void Destroy ()
	{
		Destroy (gameObject);
	}

	public void tamamenyokol ()
	{
		sprites.SetActive (false);
		yokol = false;
		particleEnemy.Stop ();
		Invoke ("Destroy", 1);


	}

	void OnTriggerExit2D (Collider2D info )
	{
		if (info.tag == "pusher" && gameObject.tag == "engeldusman") {
			uzaklaş = false;

		}

	}






	void OnTriggerEnter2D (Collider2D info )
	{
		if (info.tag == "Player") {
			
			bcengel.enabled = false;
			yokol = true;
			}
		if (info.tag == "shield"  && gameObject.tag =="engeldusman") {
			engeltütle = 0;
			bcengel.enabled = false;
			yokolwithshield = true;
			particleEnemy.Play ();

			}
		if (info.tag == "shield" && gameObject.tag == "engel") {
			engeltütle = 0;
			}

		if (info.tag == "noenemy" && gameObject.tag == "engel") {
			engeltütle = 0;
			}

		if (info.tag == "magnet" && gameObject.tag == "engel") {
			
			bcengel.enabled = false;
			yokol = true;
		}

			if (info.tag == "pusher" && gameObject.tag == "engeldusman") {
				uzaklaş = true;
		}
			if (info.tag == "noenemy"  && gameObject.tag =="engeldusman") {
			engeltütle = 0;
			bcengel.enabled = false;
			yokolwithshield = true;
			particleEnemy.Play ();

			}


		if (info.tag == "takeall" && gameObject.tag == "engel") {
			
			bcengel.enabled = false;
			yokol = true;
		}
	}






}

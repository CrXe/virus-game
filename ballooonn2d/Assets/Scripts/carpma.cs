using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carpma : MonoBehaviour {

	public Rigidbody2D rb;
	public Transform playertransform;
	public Animator anim;
	private Vector2 zıplamayönü;
	public ParticleSystem particle;
	public GameObject particletransform;


	public float VirusPower;
	public float HedefVirusPower;

	public float tavanzemindmg;
	public float immunesystemdmg;

	//Slider
	public Image  PowerSlider;




	void Start()
	{
		VirusPower = 0;
		HedefVirusPower = 80;
	}



	void Update()


	{
		if (VirusPower != HedefVirusPower) {
			VirusPower = Mathf.LerpUnclamped (VirusPower , HedefVirusPower,5*(Time.deltaTime));
			PowerSlider.fillAmount = VirusPower / 100;
		}



	}
		


	void OnCollisionEnter2D (Collision2D info)
	{
		if (info.collider.tag == "immunesystem") {
	
			HedefVirusPower -=immunesystemdmg; 
			anim.SetBool ("dmgyedi", true); 

			//Bugları önlemek için maximum zıplama vektörü 7*7
			if (info.relativeVelocity.x > 10 || info.relativeVelocity.y > 10) {
				zıplamayönü = new Vector2
				((info.relativeVelocity.x / info.relativeVelocity.x) * -7, (info.relativeVelocity.y / info.relativeVelocity.y) * 7);
			} else {
				zıplamayönü = new Vector2 (-info.relativeVelocity.x+1, info.relativeVelocity.y+1);
				}

			rb.AddForce (zıplamayönü*4, ForceMode2D.Impulse);
			particle.Play(); //kan damlama animasyonu
		}
		if (info.collider.tag == "tavanzemin"  ) {

			HedefVirusPower -=tavanzemindmg;
			anim.SetBool ("dmgyedi", true); 

			//Bugları önlemek için maximum zıplama vektörü 7*7
			if (info.relativeVelocity.x > 10 || info.relativeVelocity.y > 10) {
				zıplamayönü = new Vector2 
				((info.relativeVelocity.x / info.relativeVelocity.x) * -7, (info.relativeVelocity.y / info.relativeVelocity.y) * 7);
			} else {
				zıplamayönü = new Vector2 (-info.relativeVelocity.x+1, info.relativeVelocity.y+1);
				}

			rb.AddForce (zıplamayönü*4, ForceMode2D.Impulse);

			particle.Play(); //kan damlama paticle
		}
	}




	void OnTriggerEnter2D (Collider2D info){
		if (info.tag == "engel") {

			engelcarpma eklenecekkütle = info.gameObject.GetComponent<engelcarpma> ();
			HedefVirusPower += eklenecekkütle.engeltütle;
		}	

	

		if (info.tag == "engeldusman" ) {

			engelcarpma eklenecekkütle = info.gameObject.GetComponent<engelcarpma> ();
			HedefVirusPower -= eklenecekkütle.engeltütle;

		}
		
	}

	void OnCollisionExit2D (Collision2D info){

		if (info.collider.tag == "tavanzemin"|| info.collider.tag=="immuneystem")
		{
		//anim.SetBool ("dmgyedi", false);
	
		}
	}






}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelcarpma : MonoBehaviour {

	public EdgeCollider2D bcengel;
	public Transform trengel;
	public bool yokol =false;
	public GameObject player;
	public GameObject sprites;
    public bool yokolwithshield;
    public EdgeCollider2D overlapCollider;
    public Rigidbody2D rbengel;
    public bool ispusherused;
    public carpma carpmasc;


    public float engelDmg;
	public ParticleSystem particleEnemy;


	void Start() {
        engelDmg = 5;
        ispusherused = false;
        player = GameObject.FindGameObjectWithTag("Player");
        carpmasc = player.GetComponent<carpma>();

	}



	public void TamamenYokol ()
	{
		sprites.SetActive (false);
		yokol = false;
		
        Destroy(gameObject, 1.5f);

	}

    public void SetVelocityZeroAgain ()
    {
        rbengel.velocity = new Vector2(0, 0);
    }


    void OnTriggerEnter2D (Collider2D info )
	{
		if (info.tag == "Player") {
            overlapCollider.enabled = false;
            bcengel.enabled = false;
			yokol = true;
            carpmasc.hedefVirusHp -= engelDmg;
            TamamenYokol();
            

        }

		if (info.tag == "shield") {
            overlapCollider.enabled = false;
            engelDmg = 0;
			bcengel.enabled = false;
			particleEnemy.Play ();
            TamamenYokol();
        }

		if (info.tag == "pusher" ) {

            while (!ispusherused)
            {
                Vector3 relativeforce = transform.position - player.transform.position;
                rbengel.velocity = new Vector2(relativeforce.x / 2, relativeforce.y / 2);
                
                ispusherused = true;
                Invoke("SetVelocityZeroAgain", 1);
            }
        }

        if (info.tag == "noenemy"  ) {
            overlapCollider.enabled = false;
            engelDmg = 0;
			bcengel.enabled = false;
			particleEnemy.Play ();
            TamamenYokol();

        }

       


    }






}

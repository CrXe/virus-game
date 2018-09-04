
using UnityEngine;

public class gölgemover : MonoBehaviour {



	public  GameObject player;
	public float gölgeküçülmemiktarı;
	public SpriteRenderer gölderenderer;




	void Start () {

	}

	void FixedUpdate () {

		if (player.transform.position.y > -13) {
			gölderenderer.enabled = false;
		} else {
			gölderenderer.enabled = true;
		}

		transform.position = new Vector3 (player.transform.position.x , -16, transform.position.y);



		transform.localScale = new Vector3 (player.transform.position.y+13,player.transform.position.y+13,player.transform.localScale.z);




		
	}
}

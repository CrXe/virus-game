
using UnityEngine;

public class overlapsolver : MonoBehaviour {

	// Use this for initialization
	


    public GameObject engelplusga;
    public ParticleSystem pusherDestroyParticle;
    public SpriteRenderer engelsprite;
    public EdgeCollider2D mainCollider;
	

     void OnTriggerEnter2D(Collider2D info)
    {
        

        //immune systemle carpısınca yok ediyor objeyi + ve - enemy icin de gecerli
        if (info.tag == "immunesystem")
        {
            mainCollider.enabled = false;
            engelsprite.enabled = false;
            pusherDestroyParticle.Play();

            GameObject.Destroy(engelplusga, 1);
            
        }

        if (info.tag == "tavanzemin")
        {
            mainCollider.enabled = false;
            engelsprite.enabled = false;
            pusherDestroyParticle.Play();

            GameObject.Destroy(engelplusga, 1);

        }

    }


    // Update is called once per frame
    void Update () {
		
	}
}

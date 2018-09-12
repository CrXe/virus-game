using UnityEngine;
using UnityEngine.UI;

public class carpma : MonoBehaviour {


    public SaveSc savesc;
	public Rigidbody2D rb;
	public Transform playertransform;
	public Animator anim;
	private Vector2 zıplamayönü;
	public ParticleSystem particle;
	public GameObject particletransform;
    public levelGm levelGm;


	public float virusHp;
	public float hedefVirusHp;

	public float tavanzemindmg;
	public float immunesystemdmg;

	//Slider
	public Image  PowerSlider;


    void Start()
	{
     
        virusHp = 0;
        hedefVirusHp = savesc.maxHp;
        tavanzemindmg = levelGm.tavanzemindmg;
        immunesystemdmg = levelGm.tavanzemindmg;

	}



	void Update()


	{
		if (virusHp != hedefVirusHp) {
			virusHp = Mathf.LerpUnclamped (virusHp , hedefVirusHp,5*(Time.deltaTime));
			PowerSlider.fillAmount = virusHp / 100;

            
 
           
		}

       if (hedefVirusHp<= 0)
        {
            levelGm.EndGame();

        }



	}
		


	void OnCollisionEnter2D (Collision2D info)
	{
		if (info.collider.tag == "immunesystem") {
	
			hedefVirusHp -=immunesystemdmg; 
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

			hedefVirusHp -=tavanzemindmg;
			anim.SetBool ("dmgyedi", true); 

			//Bugları önlemek için maximum zıplama vektörü 7*7
			if (info.relativeVelocity.x > 10 || info.relativeVelocity.y > 10) {
				zıplamayönü = new Vector2 
				((info.relativeVelocity.x / info.relativeVelocity.x) * -7, (info.relativeVelocity.y / info.relativeVelocity.y) * 7);
			} else {
				zıplamayönü = new Vector2 (-info.relativeVelocity.x+1, info.relativeVelocity.y+1);
				}

			rb.AddForce (zıplamayönü*20, ForceMode2D.Impulse);

			particle.Play(); //kan damlama paticle
		}
	}






	void OnCollisionExit2D (Collision2D info){

		if (info.collider.tag == "tavanzemin"|| info.collider.tag=="immuneystem")
		{
		//anim.SetBool ("dmgyedi", false);
	
		}
	}






}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShield : MonoBehaviour {

	public GameObject shield;
	public bool isshieldactive;
	private bool cooldowndamı;
	private float shieldcooldown;
	public SaveSc savesc;
	public Button Shieldbutton;
	public CircleCollider2D cccolider; 
	public GameObject shieldbuttonga;
	public Image shieldimg;
	private bool shieldcoldowndamı;
	private bool harcanıyormu;
	public GameObject shieldplayersprite;

	public float[] LevelShieldCD;

	void Start () {
		shieldplayersprite.SetActive (false);
		harcanıyormu = false;
		cccolider.enabled = false;
		shieldcoldowndamı = false;
		Shieldbutton.interactable = true;


		// geting shield lvl data from save script
		if(savesc.shieldpr == 0)
			shieldbuttonga.SetActive(false);
		else
			shieldcooldown = LevelShieldCD[savesc.shieldpr-1];
	}


	void FixedUpdate()
	{
		//seting loading bar for shield coldown
		if (shieldcoldowndamı == true) {
			shieldimg.fillAmount += 0.02f / shieldcooldown;
				}
		if (harcanıyormu==true)
			
			shieldimg.fillAmount -= 0.02f / 5;

		}

		

	//this method is triggering with in-game shield button
	public void ActivateShield ()
	{
		shieldplayersprite.SetActive (true);
		harcanıyormu = true;
		cccolider.enabled = true;
		isshieldactive = true;
		Shieldbutton.interactable = false;
		Invoke ("SetDeactiveShield", 5);
		Invoke ("butonbasılabilir",shieldcooldown+5);
	}

	//this method sets shield deactive
	public void SetDeactiveShield ()
		{
		shieldplayersprite.SetActive (false);
		harcanıyormu = false;
		cccolider.enabled = false;
		isshieldactive = false;
		shieldcoldowndamı = true;
		Debug.Log ("still active");
		shieldimg.fillAmount =0 ;
		}

	//this method sets shield button pressable again
	public void butonbasılabilir (){
		Shieldbutton.interactable = true;
		shieldcoldowndamı = false;

	}
}

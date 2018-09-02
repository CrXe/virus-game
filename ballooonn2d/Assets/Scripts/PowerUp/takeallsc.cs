using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class takeallsc : MonoBehaviour {


	public SaveSc savesc;
	private float takeallradius;
	private bool istakeallactive;
	public CircleCollider2D circlecollider;
	public Button takeallbutton;
	public GameObject takeallbuttongame;
	public float takeallCooldown;
	public float takeallDuration;

	private bool takeallcoldowndamı;
	private bool harcanıyormu;
	public Image takealldimg;



	public float[] takeAllRadiusByLevel;


	void Start () {

		takeallcoldowndamı = false;
		takeallbutton.interactable = true;
		circlecollider.enabled = false;

		if (savesc.takeallpr == 0) {
			takeallbutton.interactable = false;
			takeallbuttongame.SetActive (false);
		}
		else
			circlecollider.radius = takeAllRadiusByLevel[savesc.takeallpr-1];

	}


	public void SetTakeAllActive ()
	{
		takeallbutton.interactable = false;
		circlecollider.enabled=true;
		Invoke ("SetTakeAllDeactive", takeallDuration);
		Invoke ("SetButtonActive", takeallCooldown + takeallDuration);
	}

	public void SetTakeAllDeactive ()
	{
		
		circlecollider.enabled=false;
		takeallcoldowndamı = true;
		takealldimg.fillAmount = 0;

		
	}

	public void SetButtonActive ()
	{
	takeallbutton.interactable = true;
		takeallcoldowndamı = false;
	
	}


	void FixedUpdate()
	{
		if (takeallcoldowndamı == true) {
			takealldimg.fillAmount += 0.02f / takeallCooldown;
			}
	}

	
	// Update is called once per frame

}

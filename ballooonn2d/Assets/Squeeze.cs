using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Squeeze : MonoBehaviour {

    public Transform playertransform;
    public SaveSc savesc;
    public bool issqueezeactive;
    public Button squeezeButton;
    public float squeezeCd;
    public float squeezeduration;
    public Vector3 kucukvektor;
    public Vector3 buyukvektor;
    public bool kucul;
    public bool buyu;




    // Use this for initialization
    void Start() {
        kucukvektor = new Vector3(0.5f, 0.5f, 0.5f);
        buyukvektor = new Vector3(1, 1, 1);

        issqueezeactive = false;
        squeezeButton.interactable = false;

        if (savesc.squezepr == 0)
        {
            squeezeButton.enabled = false;
            squeezeButton.gameObject.SetActive(false);
     

        }
        else
        {
            squeezeButton.enabled = true;
            squeezeButton.interactable = true;
        }
		
	}

    void FixedUpdate()
    {
        squeezeButton.image.fillAmount += 0.02f / squeezeCd;

        if (kucul == true)
        {
            playertransform.localScale = Vector3.Lerp(playertransform.localScale, kucukvektor, 10 * Time.deltaTime);
        }
        if (buyu == true)
        {
            playertransform.localScale = Vector3.Lerp(playertransform.localScale, buyukvektor, 10 * Time.deltaTime);
        }
    }



    public void SetSqueezeActive ()
    {
        kucul = true;
        squeezeButton.interactable = false;
        Invoke("StopSqueeze", squeezeduration);
        Invoke("SetSqueezeButtonEnabled", squeezeduration + squeezeCd);
    }


    public void StopSqueeze()
    {
        kucul = false;
        buyu = true;
        playertransform.localScale = Vector3.Lerp(playertransform.localScale, buyukvektor, 2 * Time.deltaTime);
        squeezeButton.image.fillAmount = 0;
    }

    void SetSqueezeButtonEnabled()
    {
        buyu = false;
        squeezeButton.interactable = true;
    }
}

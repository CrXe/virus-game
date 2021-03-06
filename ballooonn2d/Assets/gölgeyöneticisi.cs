﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gölgeyöneticisi : MonoBehaviour {


    public SpriteRenderer gölgeSprite;
    public Transform cisnminTransformu;
    public Transform gölgeninTransformu;
    public Vector3 zemininTransformu;
    public float güncelFark;




	// Use this for initialization
	void Start () {
        zemininTransformu = new Vector3(-4.8f, -15, 0);

        gölgeninTransformu.position = new Vector3(cisnminTransformu.position.x, -16, 0);

        güncelFark = cisnminTransformu.position.y - zemininTransformu.y;

        if (güncelFark <= 2)
        {
            if (güncelFark <= 1)
            {
                gölgeSprite.enabled = true;
                gölgeninTransformu.localScale = new Vector3(3 - (1 / 2), 3 - (1 / 2), 3 - (1 / 2));
                gölgeSprite.color.a.Equals(0);
            }
            else
            {
                gölgeSprite.enabled = true;
                gölgeninTransformu.localScale = new Vector3(3 - (güncelFark / 2), 3 - (güncelFark / 2), 3 - (güncelFark / 2));
                gölgeSprite.color.a.Equals(0);

            }


        }
        else
        {
            gölgeSprite.enabled = false;
        }

    }
}
	




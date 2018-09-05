using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgamechecker : MonoBehaviour {




    public levelGm levelGm;

    void OnTriggerEnter2D(Collider2D info)
    {
        if (info.tag == "endgame")
        {


            levelGm.EndGame();
        }


    }
}

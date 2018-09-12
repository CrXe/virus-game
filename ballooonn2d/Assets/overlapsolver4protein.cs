using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overlapsolver4protein : MonoBehaviour {



    public GameObject proteinGa;



    void OnTriggerEnter2D(Collider2D info)
    {
      

        //immune systemle carpısınca yok ediyor objeyi + ve - enemy icin de gecerli
        if (info.tag == "immunesystem")
        {
            GameObject.Destroy(proteinGa, 0);

        }

        //immune systemle carpısınca yok ediyor objeyi + ve - enemy icin de gecerli
        if (info.tag == "overlapsover4enemy" || info.tag == "engel")
        {
            GameObject.Destroy(proteinGa, 0);

        }




    }


    // Update is called once per frame
    void Update()
    {

    }
}

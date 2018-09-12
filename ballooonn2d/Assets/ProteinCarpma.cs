using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinCarpma : MonoBehaviour
{

    public EdgeCollider2D bcengel;
    public Transform trengel;
    public bool yokol = false;
    public GameObject player;
    public GameObject sprites;
    public Animator animengelplus;
    public CircleCollider2D overlapSolverCollider;
    public carpma carpmasc;


    public int proteinDegeri;


    void Start()
    {
       
        player = GameObject.FindGameObjectWithTag("Player");

    }




    void Update()
    {

        if (trengel.lossyScale.x <= 0)
        {
            TamamenYokol();
        }

        if (yokol == true && trengel.lossyScale.x > 0)
        {
            trengel.transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime;
            trengel.transform.position = Vector2.Lerp(trengel.transform.position, player.transform.position, Time.deltaTime * 3f);
        }


    }




    public void TamamenYokol()
    {
        sprites.SetActive(false);
        yokol = false;

        Destroy(gameObject, 1);


    }




    void OnTriggerEnter2D(Collider2D info)
    {
        if (info.tag == "Player")
        {
            overlapSolverCollider.enabled = false;
            bcengel.enabled = false;
            yokol = true;
            carpmasc.hedefVirusHp += proteinDegeri;

        }

        if (info.tag == "magnet")
        {
            overlapSolverCollider.enabled = false;
            bcengel.enabled = false;
            yokol = true;
        }

        if (info.tag == "takeall")
        {
            overlapSolverCollider.enabled = false;
            bcengel.enabled = false;
            yokol = true;
        }


    }

}
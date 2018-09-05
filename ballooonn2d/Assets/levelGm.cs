
using UnityEngine;

public class levelGm : MonoBehaviour
{


    public GameObject endgamebuttons;
    public GameObject ingamebuttons;






    void Awake()
    {

        ingamebuttons.SetActive(true);
        endgamebuttons.SetActive(false);


    }


    public void EndGame()
    {
        Debug.Log("bitiriyorum beyler son siparişler");

        endgamebuttons.SetActive(true);
        ingamebuttons.SetActive(false);

    }

 
}

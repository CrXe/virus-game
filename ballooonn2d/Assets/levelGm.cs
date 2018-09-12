
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class levelGm : MonoBehaviour
{
    public SaveSc saveSc;
    public Text proteinCount;
    public GameObject endgamebuttons;
    public GameObject ingamebuttons;
    public Rigidbody2D rbPlayer;

    //Level Optimization

    public float immunedmg;
    public float tavanzemindmg;


     void Awake()
    {
        Application.targetFrameRate = 60;
        
        
        ingamebuttons.SetActive(true);
        endgamebuttons.SetActive(false);
    }

    public void TekrarOyna ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        saveSc.Save();
    }



    public void Update()
    {
        proteinCount.text = saveSc.protein.ToString();
    }

    public void EndGame()
    {

        endgamebuttons.SetActive(true);
        ingamebuttons.SetActive(false);
        rbPlayer.bodyType = RigidbodyType2D.Static;
    }


   

 

    public void GoToMainMenu ()

        
    {
        saveSc.Save();
        SceneManager.LoadScene(0);
    }
}


using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
        ingamebuttons.SetActive(true);
        endgamebuttons.SetActive(false);
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


    public void TekrarOyna ()
    {
        int activescene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activescene, LoadSceneMode.Single);
        saveSc.Save();
    }

 

    public void GoToMainMenu ()

        
    {
        saveSc.Save();
        SceneManager.LoadScene(0);
    }
}

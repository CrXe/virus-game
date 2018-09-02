using UnityEngine.SceneManagement;
using UnityEngine;

public class menuorg : MonoBehaviour {

	public void StartGame(){
		SceneManager.LoadScene ("level1");	
	}


	public void QuitGame(){
	
		Application.Quit();
		Debug.Log ("çıktık reis");
	

	}


}


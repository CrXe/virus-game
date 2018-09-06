
using UnityEngine;
using UnityEngine.SceneManagement;


public class _gmmenü : MonoBehaviour {


    public AnimationCurve acr;
    public GameObject dummyToFallow;
    public GameObject mainCamera;



    void Update()
    {

        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, dummyToFallow.transform.position, acr.Evaluate(Time.deltaTime));

    }

    public void SendDummyToMainMenü()
    {
        dummyToFallow.transform.position = new Vector3(0, 0, dummyToFallow.transform.position.z);
    }

    public void SendDummyToMutation()
    {
        dummyToFallow.transform.position = new Vector3(6.88f, 0, dummyToFallow.transform.position.z);
    }

    public void StartLevelOne()

    {
        SceneManager.LoadScene(1);
    }



    void Start () {
		
	}
	
	

}

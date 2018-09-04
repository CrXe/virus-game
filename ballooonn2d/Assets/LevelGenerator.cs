using UnityEngine;

public class LevelGenerator : MonoBehaviour {


    public GameObject[] objects;



	// Use this for initialization
	void Start () {

        int random = Random.Range(0, objects.Length);
        Instantiate(objects[random],transform.position,Quaternion.identity);



		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using UnityEngine;

public class plusenemySpawner : MonoBehaviour
{


    public GameObject[] objects;



    // Use this for initialization
    void Start()
    {


       
      
     Instantiate(objects[0], new Vector3
     (transform.position.x , transform.position.y, transform.position.z), Quaternion.identity);
                



    }

    // Update is called once per frame
    void Update()
    {

    }
}

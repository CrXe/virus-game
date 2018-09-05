using UnityEngine;

public class plusenemySpawner : MonoBehaviour
{


    public GameObject[] objects;



    // Use this for initialization
    void Start()
    {

        int random = Random.Range(0, objects.Length);
        Instantiate(objects[random], new Vector3(transform.position.x - 3, transform.position.y, transform.position.z), Quaternion.identity);
        Instantiate(objects[random], new Vector3(transform.position.x - 0.75f, transform.position.y, transform.position.z), Quaternion.identity);
        Instantiate(objects[random], new Vector3(transform.position.x + 0, transform.position.y, transform.position.z), Quaternion.identity);
        Instantiate(objects[random], new Vector3(transform.position.x + 0.75f, transform.position.y, transform.position.z), Quaternion.identity);
        Instantiate(objects[random], new Vector3(transform.position.x + 3, transform.position.y, transform.position.z), Quaternion.identity);




    }

    // Update is called once per frame
    void Update()
    {

    }
}

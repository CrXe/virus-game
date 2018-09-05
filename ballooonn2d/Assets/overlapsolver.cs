
using UnityEngine;

public class overlapsolver : MonoBehaviour {

	// Use this for initialization
	


        public GameObject engelplusga;
	

     void OnTriggerStay2D(Collider2D info)
    {
        if (info.tag == "immunesystem" && gameObject.tag == "overlapsolver")
        {
        GameObject.Destroy(engelplusga, 0);

        }

    }


    // Update is called once per frame
    void Update () {
		
	}
}

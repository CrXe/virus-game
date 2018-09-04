
using UnityEngine;

public class SpawnerSpawner : MonoBehaviour {

    

    public GameObject spawnerspawner;
    public float levelLength;
    public Vector3[] immunePositions;
    public Vector3 hedefpozisyon;
    public Vector3 kullanılanPozisyon;

    public float yatayAralık =10;
    public float dikeyAralık= 10;




     
    //Level Generator
	void Awake () {
         hedefpozisyon = new Vector3(10, -11, 0); 
        

        for (int x = 0; x < immunePositions.Length; x++) {

            kullanılanPozisyon = hedefpozisyon;
            int randx = Random.Range(-2, 4);
            int randy = Random.Range(-2, 4);

            

            // random faktörleri /engellerin pozisyonları random ama kisiki bağlı
            kullanılanPozisyon.y = kullanılanPozisyon.y + randy;
            kullanılanPozisyon.x = kullanılanPozisyon.x + randx;

            //zemıne carpmaması ıcın mınımum yukseklık
            if (kullanılanPozisyon.y < -13)
            {
                kullanılanPozisyon.y = -13;
            }

            //tavana carpmaması ıcın maksımum yukseklık
            if (kullanılanPozisyon.y+ dikeyAralık > 2)
            {
                kullanılanPozisyon.y =2-dikeyAralık;
            }
            
          



             //alttaki engel
            Instantiate(spawnerspawner, kullanılanPozisyon, Quaternion.identity);
            //üstteki engel
            Instantiate(spawnerspawner, new Vector3
            (kullanılanPozisyon.x, kullanılanPozisyon.y+ dikeyAralık, kullanılanPozisyon.z), Quaternion.identity);



            hedefpozisyon += new Vector3(yatayAralık, 0,0);

           


        }

        
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

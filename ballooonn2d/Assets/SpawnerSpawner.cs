
using UnityEngine;

public class SpawnerSpawner : MonoBehaviour {

    

    public GameObject immuneSpawnerSpawner;
    public GameObject proteinSpawnerSpawner;
    public Vector3[] immunePositions;
    public Vector3 hedefpozisyon;
    public Vector3 kullanılanPozisyon;
     

    public float yatayAralık =10;
    public float dikeyAralık= 10;






     void Awake()
    {

        immunePositions[0] = new Vector3(0,-5, 0);
        for (int x = 2; x < immunePositions.Length; x++)
        {
            int caseSwitch = Random.Range(1, 3);

            

            switch (caseSwitch)
            {
                //ikili spawn
                case 1:
                    immunePositions[x].x += yatayAralık * x;

                    int randomYükseklik = Random.Range(-2, 3);

                    immunePositions[x].y = -12 + randomYükseklik;
                    //alt gel spawner
                    Instantiate(immuneSpawnerSpawner, immunePositions[x], Quaternion.identity);
                    //üst el spawner
                    Instantiate(immuneSpawnerSpawner, new Vector3
                    (immunePositions[x].x, immunePositions[x].y + dikeyAralık, immunePositions[x].z), Quaternion.identity);

                    break;

                //tekli spawn
                case 2:
                    immunePositions[x].x += yatayAralık * x;

                    int randomYükseklik2 = Random.Range(-2, 4);
                    immunePositions[x].y = -7+ randomYükseklik2;


                    Instantiate(immuneSpawnerSpawner, new Vector3
                    (immunePositions[x].x, immunePositions[x].y, immunePositions[x].z), Quaternion.identity);
                    break;
            }


            



            int randomProtein = Random.Range(1, 3);
            switch(randomProtein)
            {

                //iki engelin tam ortasına protein spawn kodu;
                case 1:
                 float ikiEngelOrtasıx = (immunePositions[x - 1].x + immunePositions[x].x) / 2;
                 float ikiEngelOrtasıy = (immunePositions[x - 1].y + immunePositions[x].y) / 2;

                    int ikiEngelArasıRndy = Random.Range(-4,4);//y ekseninde kullanmak için random y+- degerı yaratıyorum
                    if (ikiEngelOrtasıy< -10) { ikiEngelArasıRndy = Random.Range(0, 4); }//yere çarpmasın diye random değeri sınırlıyorum
                    Instantiate(proteinSpawnerSpawner, new Vector3(ikiEngelOrtasıx, ikiEngelOrtasıy+ ikiEngelArasıRndy, 0), Quaternion.identity);

                    break;
                //alttaki engelin üstüne protein spawn kodu;
                case 2:
                     Instantiate(proteinSpawnerSpawner, new Vector3(immunePositions[x].x, immunePositions[x].y+5, 0), Quaternion.identity);
                    break;


            }



            
   
        }

    }


    /*
     * Level Generetar Deneme1
     * 
    
   //Level Generator
   void Awake () {
        hedefpozisyon = new Vector3(10, -11, 0); 


       for (int x = 0; x < immunePositions.Length; x++) {

           kullanılanPozisyon = hedefpozisyon;
           int randx = Random.Range(-2, 4);
           int randy = Random.Range(-2, 4);



           // random faktörleri /engellerin pozisyonları random ama ikisi bağlı
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


           if (immunePositions[x].x - immunePositions[x-1]<5)
           { 
                   }


            //alttaki engel
           Instantiate(spawnerspawner, kullanılanPozisyon, Quaternion.identity);
           //üstteki engel
           Instantiate(spawnerspawner, new Vector3
           (kullanılanPozisyon.x, kullanılanPozisyon.y+ dikeyAralık, kullanılanPozisyon.z), Quaternion.identity);



           hedefpozisyon += new Vector3(yatayAralık, 0,0);




       }



   }

   *///level generator deneme1


    // Update is called once per frame
    void Update () {
		
	}
}

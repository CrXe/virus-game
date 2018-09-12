
using UnityEngine;

public class SpawnerSpawner : MonoBehaviour {

    

    public GameObject immuneSpawnerSpawner;
    public GameObject proteinSpawnerSpawner;
    public GameObject engelSpawnerSpawner; 
    public Vector3[] anchorpositions;
  
    public Vector3 hedefpozisyon;
    public Vector3 kullanılanPozisyon;

    public int[] proteinYanYana;//bunun uzunluğu yan yana spawn olan proteinlerin max sayısını belirliyor 
     

    public float yatayAralık =10;
    public float dikeyAralık= 10;
    





     void Awake(){
        anchorpositions[0] = new Vector3(0,-5, 0);
        for (int x = 1; x < anchorpositions.Length; x++)
        {
            bool engelTeklimi = false;
            yatayAralık -= 0.05f;
            //immune Spawner
            int caseSwitch = Random.Range(0, 2);
            switch (caseSwitch)
            {
                //ikili immune spawn
                case 0:
                    anchorpositions[x].x += yatayAralık * x;
                    int randomYükseklik = Random.Range(-2, 3);
                    anchorpositions[x].y = -12 + randomYükseklik;
                    //alt gel spawner
                    Instantiate(immuneSpawnerSpawner, anchorpositions[x], Quaternion.identity);
                    //üst el spawner
                    Instantiate(immuneSpawnerSpawner, new Vector3
                    (anchorpositions[x].x, anchorpositions[x].y + dikeyAralık, anchorpositions[x].z), Quaternion.identity);
                    engelTeklimi = false;
                    break;

                //tekli immune spawn
                case 1:
                    anchorpositions[x].x += yatayAralık * x;
                    int randomYükseklik2 = Random.Range(-2, 4);
                    anchorpositions[x].y = -7 + randomYükseklik2;
                    Instantiate(immuneSpawnerSpawner, new Vector3
                    (anchorpositions[x].x, anchorpositions[x].y, anchorpositions[x].z), Quaternion.identity);
                    engelTeklimi = true;
                    break;
            }
            //alttaki engelin üstüne protein spawner
            int yboşluk = Random.Range(4, 7);
            float proteinlerArasıBoşluk;
            bool boslukSwitch = false;
            for (int y = 0; y < proteinYanYana.Length; y++) {
                //bunun sayesinde proteinleri tek noktanın sağına ve soluna dağıtabiliyorum
                if (!boslukSwitch)
                {
                    proteinlerArasıBoşluk = -y / 2;
                    boslukSwitch = true;
                } else {
                    proteinlerArasıBoşluk = y / 2;
                    boslukSwitch = false;
                }
                float randomSpreat = Random.Range(-2, 2);
                if (y * 3 <= x)// bu da proteinlerin giderek artmasını sağlıyor.
                {
                    Instantiate(proteinSpawnerSpawner
                    , new Vector3(anchorpositions[x].x + proteinlerArasıBoşluk, anchorpositions[x].y + yboşluk + randomSpreat, anchorpositions[x].z)
                    , Quaternion.identity);
                }
            }

            //alttaki engelin üstüne protein spawner
            int xboşluk2 = Random.Range(4, 6);
            float proteinlerArasıBoşluk2;
            bool boslukSwitch2 = false;
            for (int y = 0; y < proteinYanYana.Length; y++)
            {
                //bunun sayesinde proteinleri tek noktanın sağına ve soluna dağıtabiliyorum
                if (!boslukSwitch2)
                {
                    proteinlerArasıBoşluk2 = -y / 2;
                    boslukSwitch2 = true;
                }
                else
                {
                    proteinlerArasıBoşluk2 = y / 2;
                    boslukSwitch2 = false;
                }
                float randomSpreat2 = Random.Range(-2, 2);
                // bu da proteinlerin giderek artmasını sağlıyor.
                if (y * 6 <= x)
                {
                    Instantiate(proteinSpawnerSpawner
                    , new Vector3(anchorpositions[x].x + xboşluk2 + randomSpreat2, anchorpositions[x].y + proteinlerArasıBoşluk2, anchorpositions[x].z)
                    , Quaternion.identity);
                }
            }

            //üstteki engelin soluna protein spawner(engel teklilse spawn etmiyor)

            if (!engelTeklimi)
            {
                int xboşluk3 = Random.Range(4, 7);
                float proteinlerArasıBoşluk3;
                bool boslukSwitch3 = false;
                for (int y = 0; y < proteinYanYana.Length; y++)
                {
                    //bunun sayesinde proteinleri tek noktanın sağına ve soluna dağıtabiliyorum
                    if (!boslukSwitch3)
                    {
                        proteinlerArasıBoşluk3 = -y / 2;
                        boslukSwitch3 = true;
                    }
                    else
                    {
                        proteinlerArasıBoşluk3 = y / 2;
                        boslukSwitch3 = false;
                    }
                    float randomSpreat2 = Random.Range(-2, 2);
                    // bu da proteinlerin giderek artmasını sağlıyor.
                    if (y * 6 <= x)
                    {
                        Instantiate(proteinSpawnerSpawner
                        , new Vector3(anchorpositions[x].x - xboşluk3, anchorpositions[x].y + dikeyAralık + proteinlerArasıBoşluk3, anchorpositions[x].z)
                        , Quaternion.identity);
                    }
                }
            }


            //immunelar arası engel spawner

            // eski alt engelle yeni alt engel ortası
            Vector3 immunelararasıAltAlt = (anchorpositions[x] + anchorpositions[x - 1]) / 2;

            //eski alt engelle yeni üst engel ortası

            Vector3 immunelararasıAltÜst = (anchorpositions[x - 1] + new Vector3(anchorpositions[x].x, anchorpositions[x].y+ dikeyAralık, anchorpositions[x].z) )/ 2;


            //immunelerin ortası ya da teklinin üstü

            Vector3 immunelerortası = (anchorpositions[x] + new Vector3(anchorpositions[x].x, anchorpositions[x].y + dikeyAralık, anchorpositions[x].z)) / 2;




            switch (Mathf.RoundToInt((x / 30f) * 2f))

            {
                case 0:
                    float randomcase1 = Random.Range(-2, 2);
                    Instantiate(engelSpawnerSpawner, new Vector3(immunelararasıAltÜst.x + randomcase1, immunelararasıAltÜst.y, immunelararasıAltÜst.z), Quaternion.identity);
                    break;

                case 1:
                    float randomcase2 = Random.Range(-2, 2);
                    float randomcase22 = Random.Range(-3, 3);
                    Instantiate(engelSpawnerSpawner, new Vector3(immunelararasıAltAlt.x, immunelararasıAltAlt.y + randomcase2, immunelararasıAltAlt.z), Quaternion.identity);
                    Instantiate(engelSpawnerSpawner, new Vector3(immunelararasıAltÜst.x + randomcase22, immunelararasıAltÜst.y, immunelararasıAltÜst.z), Quaternion.identity);
                    break;

                case 2:
                    int case2random = Random.Range(0, 2);
                    switch (case2random)
                    {
                        case 1:
                            float randomcase3 = Random.Range(-2, 2);
                            float randomcase32 = Random.Range(-3, 3);
                            float rancomcase33 = Random.Range(-2, 2);
                            Instantiate(engelSpawnerSpawner, new Vector3(immunelararasıAltAlt.x, immunelararasıAltAlt.y + randomcase3, immunelararasıAltAlt.z), Quaternion.identity);
                            Instantiate(engelSpawnerSpawner, new Vector3(immunelararasıAltÜst.x + randomcase32, immunelararasıAltÜst.y, immunelararasıAltÜst.z), Quaternion.identity);
                            Instantiate(engelSpawnerSpawner, new Vector3(immunelerortası.x, immunelerortası.y + rancomcase33, immunelerortası.z), Quaternion.identity);
                            break;

                        case 2:

                             float randomcase33 = Random.Range(-2, 2);
                            float randomcase323 = Random.Range(-3, 3);
                    ;
                            Instantiate(engelSpawnerSpawner, new Vector3(immunelararasıAltAlt.x, immunelararasıAltAlt.y + randomcase33, immunelararasıAltAlt.z), Quaternion.identity);
                            Instantiate(engelSpawnerSpawner, new Vector3(immunelararasıAltÜst.x + randomcase323, immunelararasıAltÜst.y, immunelararasıAltÜst.z), Quaternion.identity);
                      
                            break;

                            ;
                    }


                    break;

           
            }








        }

    }


    void Update () {
        

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;

public class SaveSc : MonoBehaviour {

	public string Name="NONAME";
	public int level;
	//Mutasyon dataları for save
	public float protein;
	public int shieldpr;
	public int magnetpr;
	public int pusherpr;
	public int dmgredux;
	public int squeezepr;
	public int dash;
	public int noenemypr;
	public int takeallpr;
    public int maxHp;

	void Awake ()
	{

        if (File.Exists(Application.persistentDataPath + "/PlayerSave.json") == false)
        {
            JSONObject playerJson = new JSONObject();

            playerJson.Add("Name", Name);
            playerJson.Add("level", level);
            playerJson.Add("maxHp", 100);
            playerJson.Add("protein", 10);
            playerJson.Add("shieldpr", shieldpr);
            playerJson.Add("magnetpr", magnetpr);
            playerJson.Add("pusherpr", pusherpr);
            playerJson.Add("dmgredux", dmgredux);
            playerJson.Add("squeeze", squeezepr);
            playerJson.Add("dash", dash);
            playerJson.Add("noenemypr", noenemypr);
            playerJson.Add("takeallpr", takeallpr);

            string path = Application.persistentDataPath + "/PlayerSave.json";
            File.WriteAllText(path, playerJson.ToString());
            Load();

          
        }
        else
        {
            Load();
        }



            
	}



	//json kaydet komutu
	public void Save ()
	{
		JSONObject playerJson = new JSONObject();
        
		playerJson.Add ("Name", Name);
		playerJson.Add ("level", level);
        playerJson.Add ("maxHp", maxHp);
        playerJson.Add ("protein", protein);
		playerJson.Add ("shieldpr", shieldpr);
		playerJson.Add ("magnetpr", magnetpr);
		playerJson.Add ("pusherpr", pusherpr);
		playerJson.Add ("dmgredux", dmgredux);
		playerJson.Add ("squeeze", squeezepr);
		playerJson.Add ("dash", dash);
		playerJson.Add ("noenemypr", noenemypr);
		playerJson.Add ("takeallpr", takeallpr);




		string path = Application.persistentDataPath + "/PlayerSave.json";
		File.WriteAllText(path, playerJson.ToString());
    
    }

	public void Load ()
	{
		string path = Application.persistentDataPath + "/PlayerSave.json";
		string jsonString = File.ReadAllText(path);
		JSONObject playerJson = (JSONObject)JSON.Parse(jsonString);


        maxHp = playerJson["maxHp"];
        Name = playerJson ["Name"];
		level = playerJson ["level"];
		protein = playerJson ["protein"];
		shieldpr = playerJson ["shieldpr"];
		magnetpr = playerJson ["magnetpr"];
		pusherpr = playerJson ["pusherpr"];
		dmgredux = playerJson ["dmgredux"];
        squeezepr = playerJson ["squeeze"];
		dash = playerJson ["dash"];
		noenemypr = playerJson ["noenemypr"];
		takeallpr = playerJson ["takeallpr"];
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.Space)) {
			Save ();
		}

	}
}

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
	public int squezepr;
	public int movelvl1pr;
	public int movelvl2pr;
	public int noenemypr;
	public int takeallpr;
    public int maxHp;

	void Awake ()
	{
		
		Load ();
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
		playerJson.Add ("squezepr", squezepr);
		playerJson.Add ("movelvl1pr", movelvl1pr);
		playerJson.Add ("movelvl2pr", movelvl2pr);
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
		squezepr = playerJson ["squezepr"];
		movelvl1pr = playerJson ["movelvl1pr"];
		movelvl2pr = playerJson ["movelvl2pr"];
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

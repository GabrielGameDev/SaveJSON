using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;



public class GameManager : MonoBehaviour
{
	[System.Serializable]
	class SaveData
	{
		public Color color;
		public int amount;	
		
	}

    public static GameManager instance;

	public Color color;
	public int amount;
	

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public void Save()
	{
		SaveData data = new SaveData
		{
			color = color,
			amount = amount,			
		};

		string json = JsonUtility.ToJson(data);

		File.WriteAllText(Application.persistentDataPath + "/save.json", json);
		Debug.Log(Application.persistentDataPath + "/save.json");
	}

	public void Load()
	{
		string path = Application.persistentDataPath + "/save.json";

		if (File.Exists(path))
		{
			string json = File.ReadAllText(path);
			Debug.Log(json);
			SaveData data = JsonUtility.FromJson<SaveData>(json);

			color = data.color;
			amount = data.amount;
			
			
		}
	}

}

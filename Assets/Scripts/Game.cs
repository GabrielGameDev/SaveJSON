using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        if(GameManager.instance != null)
        {
			for (int i = 0; i < GameManager.instance.amount; i++)
			{
				Instantiate(prefab, new Vector3(Random.Range(-1f,1f), 0, Random.Range(-1f,1f)), Quaternion.identity);
				yield return new WaitForSeconds(0.1f);
			}
		}
        
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        if(GameManager.instance != null)
        {
			meshRenderer.material.color = GameManager.instance.color;
		}
    }

   
}

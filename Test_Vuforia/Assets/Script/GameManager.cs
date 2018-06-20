using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{


	void Start () 
	{
		
	}
	
	void Update () 
	{
        RaycastHit hit;
        Ray ray;

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(" you clicked on " + hit.collider.gameObject.name);

            if (hit.collider.gameObject.name == "Your 3D Model Name")
            {
                // Write things you want to do when you click.
            }
        }

	}
}

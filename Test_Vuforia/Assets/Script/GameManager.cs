using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text t;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(" you clicked on " + hit.collider.gameObject.name);

                if (hit.collider.gameObject.tag == "Item")
                {
                    t.text = "click";
                    Destroy(hit.collider.gameObject);
                    // Write things you want to do when you click.
                }
            }
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBehaviours : MonoBehaviour
{
    public Camera cam;
    public bool destructable = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "tile" && destructable)
                {
                    Destroy(hit.transform.gameObject, 0f);
                }
            }
        }
    }

}

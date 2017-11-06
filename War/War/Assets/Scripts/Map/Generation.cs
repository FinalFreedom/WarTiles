using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Generation : MonoBehaviour {
    public GameObject tile1;
    public GameObject tile2;
    public GameObject tile3;
    public GameObject tile4;
    private Transform startPosition;
    // Use this for initialization
    void Start ()
    {
        createMap();
	}
    private void createMap()
    {
       float height = tile1.GetComponent<Collider>().bounds.size.y;
       float width = tile1.GetComponent<Collider>().bounds.size.x;
       float length = tile1.GetComponent<Collider>().bounds.size.z;
        //Place tiles in a hexagonal 
        //for(int y = 0; y<5;y++)
        //{
            for (int x = 0; x < 21; x++)
            {
                for (int z = 0; z < 20; z++)
                {
                float zPos = 0;
                    if (x % 2 == 0)//Even x tiles
                    {
                        zPos =z * length;
                    }
                    else //Odd x tiles
                    {
                        zPos =(z - 0.5f) * length;
                    }
                Instantiate(tile1, new Vector3(width * x, tile1.transform.localPosition.y, zPos), new Quaternion(0, 0, 0, 0));
                Instantiate(tile2, new Vector3(width * x, tile2.transform.localPosition.y, zPos), new Quaternion(0, 0, 0, 0));
                Instantiate(tile3, new Vector3(width * x, tile3.transform.localPosition.y, zPos), new Quaternion(0, 0, 0, 0));
                Instantiate(tile4, new Vector3(width * x, tile4.transform.localPosition.y, zPos), new Quaternion(0, 0, 0, 0));
            }
            }
        //}
        
    }
	// Update is called once per frame
	void Update ()
    {
		
	}
}

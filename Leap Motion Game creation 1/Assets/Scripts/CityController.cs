using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityController : MonoBehaviour {

    public GameObject[] cities;
    public GameObject currentCity;
    public int index;
    /*public string cityTag = "City";
    public ArrayList cities = new ArrayList();*/
	// Use this for initialization
	void Start () {

        

        /*for (int i = 0; i < UnityEditorInternal.InternalEditorUtility.tags.Length; i++)
        {
            if (UnityEditorInternal.InternalEditorUtility.tags[i].Contains(cityTag))
            {
                
                cities.Add(GameObject.FindGameObjectsWithTag("City"));
            }
        }*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter(Collision collision)
    {
        
    }

    public GameObject CreateQuest()
    {

        cities = GameObject.FindGameObjectsWithTag("City");
        index = Random.Range(0, cities.Length);
        currentCity = cities[index];

        Debug.Log("Go to " + currentCity + "to pick up the new packages.");
        return currentCity;
    }
}

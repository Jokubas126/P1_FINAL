using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Citynames : MonoBehaviour
{

    public GameObject TextName;

    // Use this for initialization
    void Start()
    {
		TextName.GetComponent<TextMesh>().text = TextName.name;
	}

    // Update is called once per frame
    void Update()
    {
        
        TextName.transform.LookAt(Camera.main.transform.position);
        TextName.transform.Rotate(0, 180, 0);
    }
}
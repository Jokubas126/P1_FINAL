using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PackageController : MonoBehaviour {

    //System.Random rnd = new System.Random();

    

    public int numberOfPackages;
    public int packageToDrop;
    public List<int> packages = new List<int>();
    public bool quest;
    public bool dropPackage;
    public Vector3 distance;
    public int distanceFromTopToBottomMap;

    public int newstars;
    public int currentstars;

    //public TimeSpan timer = TimeSpan.FromSeconds(1);
    float timeLeft = 360.0f;

    public int timerInInt;
    public int setNewTimer;
    GameObject cityEntered;

    // Use this for initialization
    void Start () {
        packages.Add(3);
        
	}
	
	// Update is called once per frame
	void Update () {

        Timer();
        Debug.Log("Timer " +timeLeft);
        Debug.Log("You have " + currentstars + " starts");
        Debug.Log("You have " + packages + " packages");
	}
    
    public void OnTriggerExit(Collider other)
    {
        numberOfPackages = 3;
        if (quest == true)
        {
            //Quest(Collider other);
                      
            Debug.Log(other.name + "You just got " + numberOfPackages + " packages.");
        }
        else
        {
            Debug.Log(other.name + " Null.");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        distanceFromTopToBottomMap = 360;
        packageToDrop = 1;
        float bonustime = 15.0f;
        if (dropPackage == true && distanceFromTopToBottomMap <= timeLeft)
        {
            packages.Remove(packageToDrop);

            newstars = currentstars + 3;

            Debug.Log(other.name + "You dropped " + packageToDrop + "package and you dellivered the page whithin " + timerInInt + "seconds and you get " + 3 + " stars.");

        }
        else if (dropPackage == true && distanceFromTopToBottomMap <= (timeLeft + bonustime))
        {
            packages.Remove(packageToDrop);

            newstars = currentstars + 2;

            Debug.Log(other.name + "You dropped " + packageToDrop + "package and you dellivered the page whithin " + timerInInt + "seconds and you get " + 2 + " stars.");

        }
        else if (dropPackage == true && distanceFromTopToBottomMap > (timeLeft + bonustime))
        {
            packages.Remove(packageToDrop);

            newstars = currentstars + 1;

            Debug.Log(other.name + "You dropped " + packageToDrop + "package and you dellivered the page whithin " + timerInInt + "seconds and you get " + 1 + " stars.");

        }
        else
        {
            Debug.Log(other.name + " Null");
        }

        currentstars = newstars;
    }



    public void Quest(Collider other)
    {
        if (quest = true && numberOfPackages == 0 && currentcity == cityEntered)
        {
            other.GetComponent<CityController>().CreateQuest();
            
            packages.Add(numberOfPackages);
            
            
        }
        else
        {
            Debug.Log("Null");
        }
    }

    public void Timer()
    {
        timeLeft -= Time.deltaTime;
    }
}

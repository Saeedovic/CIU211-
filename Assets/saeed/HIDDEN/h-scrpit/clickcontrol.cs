﻿using UnityEngine;
using System.Collections;

public class clickcontrol : MonoBehaviour {

	public static string nameofobj;
	public GameObject objnametext;
	public Transform objnametextPos;
	public Transform sucessclick;
    public static int totalScore =0;
    public static float timeBonus =90;
    public static int remainItems = 7;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()

	{
		nameofobj = gameObject.name;
		//Debug.Log (nameofobj);
		Destroy (gameObject);
		Destroy (objnametext);
        remainItems -= 1;
		trackingclicks.totalclicks = 0;
		Instantiate (sucessclick, objnametextPos.position, sucessclick.rotation);
	}
}

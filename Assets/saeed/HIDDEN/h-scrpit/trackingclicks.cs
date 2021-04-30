using UnityEngine;
using System.Collections;

public class trackingclicks : MonoBehaviour {

	public static int totalclicks=0;
	public KeyCode mouseclick;

    public Transform scoreObj;
    public GameObject Box;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        clickcontrol.timeBonus -= Time.deltaTime;


        if (clickcontrol.remainItems == 0)
        {

            clickcontrol.totalScore += (70 + (Mathf.RoundToInt(clickcontrol.timeBonus)));
            scoreObj.GetComponent<TextMesh>().text = "Score : " + clickcontrol.totalScore;
            clickcontrol.remainItems = -1;
            Box.SetActive(true);

        }

		if (Input.GetKeyDown (mouseclick))
		{
			totalclicks += 1;


		}

		if (totalclicks >= 5) 
		{
			Debug.Log ("FAIL!!!");
			totalclicks = 0;
		}
	
	}
}

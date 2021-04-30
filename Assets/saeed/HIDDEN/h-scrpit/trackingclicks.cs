using UnityEngine;
using System.Collections;

public class trackingclicks : MonoBehaviour {

	public static int totalclicks=0;
	public KeyCode mouseclick;

    public Transform scoreObj;
    public GameObject Box;
    public Transform ClicksRemaining;
    public int RemainingClicks;
    public GameObject Lose;
    public GameObject Music;

	// Use this for initialization
	void Start () {
        RemainingClicks = 5;

	
	}
	
	// Update is called once per frame
	void Update () {

        ClicksRemaining.GetComponent<TextMesh>().text = "Clicks Remaining : " + RemainingClicks;

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
            RemainingClicks -= 1;
            ClicksRemaining.GetComponent<TextMesh>().text = "Clicks Remaining : " + RemainingClicks;


        }

		if (totalclicks >= 5) 
		{
			Debug.Log ("FAIL!!!");
			totalclicks = 0;
            Lose.SetActive(true);
            Time.timeScale = 0f;
            Music.SetActive(false);
            ClicksRemaining.GetComponent<TextMesh>().text = "Clicks Remaining : " + 0;

        }
	
	}
}

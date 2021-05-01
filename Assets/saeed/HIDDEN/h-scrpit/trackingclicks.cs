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

    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;
    public GameObject object6;
    public GameObject object7;

    public GameObject PauseManager;

    public GameObject YouWin;
    public bool win;

    // Use this for initialization
    void Start () {
        RemainingClicks = 5;
        totalclicks = 0;
        clickcontrol.remainItems = 7;
	
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
            YouWin.SetActive(true);
            win = true;

        }

		if (Input.GetKeyDown (mouseclick))
		{
			totalclicks += 1;
            ClicksRemaining.GetComponent<TextMesh>().text = "Clicks Remaining : " + RemainingClicks;

            if(win)
            {
                PauseManager.SetActive(false);
                totalclicks = 0;
            }
        }

        if (totalclicks == 1)
        {
            RemainingClicks = 4;
        }

        if (totalclicks == 2)
        {
            RemainingClicks = 3;
        }

        if (totalclicks == 3)
        {
            RemainingClicks = 2;
        }

        if (totalclicks == 4)
        {
            RemainingClicks = 1;
        }

        if (totalclicks >= 5)
        {
            RemainingClicks = 0;
        }

        if (totalclicks >= 5) 
		{
			Debug.Log ("FAIL!!!");
            Lose.SetActive(true);
            Time.timeScale = 0f;
            Music.SetActive(false);
            ClicksRemaining.GetComponent<TextMesh>().text = "Clicks Remaining : " + 0;
            PauseManager.SetActive(false);


            object1.SetActive(false);
            object2.SetActive(false);
            object3.SetActive(false);
            object4.SetActive(false);
            object5.SetActive(false);
            object6.SetActive(false);
            object7.SetActive(false);
        }

    }
}

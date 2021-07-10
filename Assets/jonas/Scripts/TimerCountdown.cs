using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 60;
    public bool takingAway = false;

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

    private void Start()
    {
        takingAway = false;
    }


    // Update is called once per frame
    void Update()
    {
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        if(secondsLeft >= 60)
        {
            textDisplay.GetComponent<TextMesh>().text = "01:00";
        }

        if (secondsLeft > 10 && secondsLeft < 60)
        {
            textDisplay.GetComponent<TextMesh>().text = "00:" + secondsLeft;
        }

        if (secondsLeft < 10)
        {
            textDisplay.GetComponent<TextMesh>().text = "00:0" + secondsLeft;
        }


        if (secondsLeft <= 0)
        {
            Debug.Log("FAIL!!!");
            Lose.SetActive(true);
            Music.SetActive(false);
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

    // Start is called before the first frame update
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
      

        textDisplay.GetComponent<TextMesh>().text = "00:" + secondsLeft;
        takingAway = false;
    }

}

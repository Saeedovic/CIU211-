using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableClicks : MonoBehaviour
{
    public GameObject PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.activeInHierarchy == true)
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }

        if (PauseMenu.activeInHierarchy == false)
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}

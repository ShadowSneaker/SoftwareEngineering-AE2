using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestScript : MonoBehaviour
{
    public bool ToggleLevel1 = true;
    public bool ToggleLevel2 = true;


    private bool Level1On;
    private bool Level2On;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (ToggleLevel1 && Level1On)
        {
            Level1On = false;
            //SceneManager.
        }
        else if (!ToggleLevel1 && !Level1On)
        {
            Level1On = true;
        }


        if (ToggleLevel2 && Level2On)
        {
            Level1On = false;
        }
        else if (!ToggleLevel2 && !Level2On)
        {
            Level2On = true;
        }
    }
}

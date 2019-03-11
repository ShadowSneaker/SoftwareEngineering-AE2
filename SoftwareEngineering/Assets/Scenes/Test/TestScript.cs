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
        SceneManager.LoadScene("Test1", LoadSceneMode.Additive);
        SceneManager.LoadScene("Test2", LoadSceneMode.Additive);

    }

    // Update is called once per frame
    void Update ()
    {
		if (ToggleLevel1 && Level1On)
        {
            Level1On = false;
            SceneManager.LoadScene("Test1", LoadSceneMode.Additive);
            Debug.Log("Opened Test1");
        }
        else if (!ToggleLevel1 && !Level1On)
        {
            Level1On = true;
            SceneManager.UnloadSceneAsync("Test1");
            Debug.Log("Closed Test1");
        }


        if (ToggleLevel2 && Level2On)
        {
            Level2On = false;
            SceneManager.LoadScene("Test2", LoadSceneMode.Additive);
            Debug.Log("Opened Test2");
        }
        else if (!ToggleLevel2 && !Level2On)
        {
            Level2On = true;
            SceneManager.UnloadSceneAsync("Test2");
            Debug.Log("Closed Test2");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Animator CameraAnim;
    public int waitTime;
    public string BeginingScene;
    public Text StartButton;
    public Button MainButton; // the button that switches between start button and resume button

    private bool InMainMenu;

    // to check wether the player is in game or in main menu
    private void Awake()
    {
        if(SceneManager.GetActiveScene().name == "Main menu scene")
        {
            InMainMenu = true;
            StartButton.text = "Start Game";
        }
        else
        {
            InMainMenu = false;
            MainButton.gameObject.SetActive(false);
            StartButton.text = "Resume Game";

        }
    }

    //one to begin the game
    public void BeginGame()
    {
        if (InMainMenu)
        {
            //CameraAnim = FindObjectOfType<Animator>();
            CameraAnim.SetBool("BeginGame", true);

            //then the code to load the scene
            StartCoroutine(LoadScene(BeginingScene));
        }
        else if (!InMainMenu)
        {
            // this becomes the resume button

            
        }

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadScene(string SceneName)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneName);
    }

}

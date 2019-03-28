using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{
    public Image GameOverImage;
    Animation GameOverAnim;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    public void DisplayGameOver()
    {
        if (GameOverImage)
        {
            if (!GameOverAnim)
                GameOverAnim = GameOverImage.GetComponent<Animation>();

            GameOverImage.gameObject.SetActive(true);

            GameOverAnim.Play(GameOverAnim.clip.name);
            StartCoroutine(AnimDelay(true));
        }
    }


    public void QuitGame()
    {
        Application.Quit();
    }


    public void Restart()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>().Respawn();
    }


    public void OpenLevel(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }


    public void Close()
    {
        if (GameOverImage && !GameOverAnim)
            GameOverAnim.Rewind(GameOverAnim.clip.name);
        StartCoroutine(AnimDelay(false));
    }

    private IEnumerator AnimDelay(bool OnGameOver)
    {
        yield return new WaitForSeconds(GameOverAnim.clip.length);

        if (!OnGameOver)
            GameOverImage.gameObject.SetActive(false);

        Cursor.visible = OnGameOver;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{
    public Image GameOverImage;
    Animation GameOverAnim;

    private AnimationClip OnDeath;
    public AnimationClip OnRespawn;


	// Use this for initialization
	void Start ()
    {
        if (GameOverImage)
        {
            GameOverAnim = GameOverImage.GetComponent<Animation>();
            OnDeath = GameOverAnim.clip;
        }
        else
        {
            Debug.LogError("GameOverImage not set.");
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    public void DisplayGameOver()
    {
        if (GameOverImage)
        {
            GameOverImage.gameObject.SetActive(true);

            GameOverAnim.clip = OnDeath;
            GameOverAnim.Play(OnDeath.name);

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
        GameOverAnim.clip = OnRespawn;
        GameOverAnim.Play(OnRespawn.name);
        

        Cursor.visible = false;
        StartCoroutine(AnimDelay(false));
    }

    private IEnumerator AnimDelay(bool OnGameOver)
    {
        yield return new WaitForSeconds(GameOverAnim.clip.length);

        if (!OnGameOver)
            GameOverImage.gameObject.SetActive(false);

        Cursor.visible = OnGameOver;
        GameOverAnim.clip = OnDeath;
    }
}

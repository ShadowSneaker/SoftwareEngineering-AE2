using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public GameObject TheLight;

    public float Brightness;
    public Scrollbar SliderLocation;

    public Scrollbar AudioBar;

    public Image PuaseMenu;
    public Image TheInventory;

    public AudioMixer Mixer;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenInventory()
    {
        TheInventory.gameObject.SetActive(true);
        PuaseMenu.gameObject.SetActive(false);
    }

    private void Update()
    {
        Brightness = SliderLocation.value;
        //Mixer.SetFloat("MasterVol", (AudioBar.value -1));

        float oldvalue = AudioBar.value;
        float oldmin = 0f;
        float oldmax = 1f;
        float newmin = -80;
        float newmax = 20;

        float newvalue = ((oldvalue - oldmin) / (oldmax - oldmin)) * (newmax - newmin) + newmin;

        Mixer.SetFloat("MasterVol", newvalue);

        foreach(Transform child in TheLight.transform)
        {
            child.GetComponent<Light>().intensity = Brightness;
        }

    }



   

}

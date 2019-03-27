using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Settings : MonoBehaviour
{
    public GameObject TheLight;

    public float Brightness;
    public Scrollbar SliderLocation;

    public Image PuaseMenu;
    public Image TheInventory;


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


        foreach(Transform child in TheLight.transform)
        {
            child.GetComponent<Light>().intensity = Brightness;
        }

    }

   

}

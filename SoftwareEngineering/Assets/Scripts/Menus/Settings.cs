using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Settings : MonoBehaviour
{
    public GameObject TheLight;

    public float Brightness;
    public Scrollbar SliderLocation;


    public void QuitGame()
    {
        Application.Quit();
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

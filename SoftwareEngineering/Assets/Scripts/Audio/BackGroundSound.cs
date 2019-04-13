using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class BackGroundSound : MonoBehaviour
{
    public AudioMixer Mixer;

    public void Start()
    {
        //Mixer.SetFloat("Room A", -80);
    }


    public void SetRoomMusic(string roomname)
    {
        //Debug.Log("function start");
        //Debug.Log(roomname);
        //if(roomname == "Room A")
        //{
        //    Debug.Log("Double Yep");
        //    Mixer.SetFloat("Room A", 1);
        //}

        switch(roomname)
        {
            case ("Ground Room A"):
                {

                    Mixer.SetFloat("Ground Room A", 1);
                    break;
                }
            case ("Ground Room B"):
                {

                    Mixer.SetFloat("Ground Room B", 1);
                    break;
                }
            case ("Ground Room C"):
                {

                    Mixer.SetFloat("Ground Room C", 1);
                    break;
                }
            case ("Ground Room D"):
                {

                    Mixer.SetFloat("Ground Room D", 1);
                    break;
                }
            case ("Ground Room E"):
                {

                    Mixer.SetFloat("Ground Room E", 1);
                    break;
                }
            case ("Ground Room F"):
                {

                    Mixer.SetFloat("Ground Room F", 1);
                    break;
                }
            case ("Ground Room G"):
                {
                    Mixer.SetFloat("Ground Room G", 1);
                    break;
                }
            case ("Ground Room Staircase"):
                {
                    Mixer.SetFloat("Ground Room Staircase", 1);
                    break;
                }
            case ("Upper Room A"):
                {
                    Mixer.SetFloat("Upper Room A", 1);
                    break;
                }
            case ("Upper Room B"):
                {
                    Mixer.SetFloat("Upper Room B", 1);
                    break;
                }
            case ("Upper Room D"):
                {
                    Mixer.SetFloat("Upper Room D", 1);
                    break;
                }
            case ("Upper Room E"):
                {
                    Mixer.SetFloat("Upper Room E", 1);
                    break;
                }
            case ("Upper Room F"):
                {
                    Mixer.SetFloat("Upper Room F", 1);
                    break;
                }
            case ("Upper Room G"):
                {
                    Mixer.SetFloat("Upper Room G", 1);
                    break;
                }
            case ("Upper Room J"):
                {
                    Mixer.SetFloat("Upper Room J", 1);
                    break;
                }
            case ("Upper Room UpperFoyer"):
                {
                    Mixer.SetFloat("Upper Room UpperFoyer", 1);
                    break;
                }
            case ("Basement Room A"):
                {
                    Mixer.SetFloat("Basement Room A", 1);
                    break;
                }
            case ("Basement Room B"):
                {
                    Mixer.SetFloat("Basement Room B", 1);
                    break;
                }
            case ("Basement Room C"):
                {
                    Mixer.SetFloat("Basement Room C", 1);
                    break;
                }
            case ("Basement Room D"):
                {
                    Mixer.SetFloat("Basement Room D", 1);
                    break;
                }
            case ("Basement Room E"):
                {
                    Mixer.SetFloat("Basement Room E", 1);
                    break;
                }
            case ("Basement Room F"):
                {
                    Mixer.SetFloat("Basement Room F", 1);
                    break;
                }
            case ("Basement Room Landing"):
                {
                    Mixer.SetFloat("Basement Room Landing", 1);
                    break;
                }
        }

    }

    public void StopMusic(string roomname)
    {
        switch (roomname)
        {
            case ("Ground Room A"):
                {
                   
                    Mixer.SetFloat("Ground Room A", -80);
                    break;
                }
            case ("Ground Room B"):
                {
                   
                    Mixer.SetFloat("Ground Room B", -80);
                    break;
                }
            case ("Ground Room C"):
                {
                    
                    Mixer.SetFloat("Ground Room C", -80);
                    break;
                }
            case ("Ground Room D"):
                {
                   
                    Mixer.SetFloat("Ground Room D", -80);
                    break;
                }
            case ("Ground Room E"):
                {
                   
                    Mixer.SetFloat("Ground Room E", -80);
                    break;
                }
            case ("Ground Room F"):
                {
                   
                    Mixer.SetFloat("Ground Room F", -80);
                    break;
                }
            case ("Ground Room G"):
                {
                    Mixer.SetFloat("Ground Room G", -80);
                    break;
                }
            case ("Ground Room Staircase"):
                {
                    Mixer.SetFloat("Ground Room Staircase", -80);
                    break;
                }
            case ("Upper Room A"):
                {
                    Mixer.SetFloat("Upper Room A", -80);
                    break;
                }
            case ("Upper Room B"):
                {
                    Mixer.SetFloat("Upper Room B", -80);
                    break;
                }
            case ("Upper Room D"):
                {
                    Mixer.SetFloat("Upper Room D", -80);
                    break;
                }
            case ("Upper Room E"):
                {
                    Mixer.SetFloat("Upper Room E", -80);
                    break;
                }
            case ("Upper Room F"):
                {
                    Mixer.SetFloat("Upper Room F", -80);
                    break;
                }
            case ("Upper Room G"):
                {
                    Mixer.SetFloat("Upper Room G", -80);
                    break;
                }
            case ("Upper Room J"):
                {
                    Mixer.SetFloat("Upper Room J", -80);
                    break;
                }
            case ("Upper Room UpperFoyer"):
                {
                    Mixer.SetFloat("Upper Room UpperFoyer", -80);
                    break;
                }
            case ("Basement Room A"):
                {
                    Mixer.SetFloat("Basement Room A", -80);
                    break;
                }
            case ("Basement Room B"):
                {
                    Mixer.SetFloat("Basement Room B", -80);
                    break;
                }
            case ("Basement Room C"):
                {
                    Mixer.SetFloat("Basement Room C", -80);
                    break;
                }
            case ("Basement Room D"):
                {
                    Mixer.SetFloat("Basement Room D", -80);
                    break;
                }
            case ("Basement Room E"):
                {
                    Mixer.SetFloat("Basement Room E", -80);
                    break;
                }
            case ("Basement Room F"):
                {
                    Mixer.SetFloat("Basement Room F", -80);
                    break;
                }
            case ("Basement Room Landing"):
                {
                    Mixer.SetFloat("Basement Room Landing", -80);
                    break;
                }

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("yep");
        SetRoomMusic(other.name); 
    }


    private void OnTriggerExit(Collider other)
    {
        StopMusic(other.name);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCinamatic : MonoBehaviour
{
    public bool PlayOnce = true;
    
    // Cinamatic video thingie here.
    public GameObject Cinamatic;
    

    private bool Played;

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            // Play Cinamatic
            if (!Played && Cinamatic)
            {
                if (PlayOnce)
                {
                    Played = true;
                }
            }
        }
    }
}

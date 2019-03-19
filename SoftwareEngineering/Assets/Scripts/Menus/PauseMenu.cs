using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{

    public Slider HealthBar;
    public Slider SanityBar;
    public PlayerScript Player;


    void Update ()
    {
        HealthBar.value = Player.CurrentHealth / Player.MaxHealth;
        SanityBar.value = Player.Sanity / Player.MaxSanity;

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{

    public Slider HealthBar;
    public Slider SanityBar;
    public PlayerScript Player;


    public Text StrengthDisplay;
    public Text AgilityDisplay;
    public Text IntelligenceDisplay;
    public Text WillPowerDisplay;
    public Text PerceptionDisplay;
    public Text CharismaDisplay;


    void Update ()
    {
        HealthBar.value = Player.CurrentHealth / Player.MaxHealth;
        SanityBar.value = Player.Sanity / Player.MaxSanity;


        StrengthDisplay.text = PlayerStats.ModStrength.ToString();
        AgilityDisplay.text = PlayerStats.ModAgility.ToString();
        IntelligenceDisplay.text = PlayerStats.ModIntelligence.ToString();
        WillPowerDisplay.text = PlayerStats.ModWillpower.ToString();
        PerceptionDisplay.text = PlayerStats.ModPerception.ToString();
        CharismaDisplay.text = PlayerStats.ModCharisma.ToString();

        
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public float HealthBarDisplay;
    public Transform HealthBar;
    public Texture2D EmptyHealthBar;
    public Texture2D FullHealthBar;

    public float SanityBarDisplay;
    public Transform SanityBar;
    public Texture2D EmptySanityBar;
    public Texture2D FullSanityBar;

    private void OnGUI()
    {
        //draw the backgroud
        GUI.BeginGroup(new Rect(new Vector2(HealthBar.position.x, HealthBar.position.y), new Vector2(HealthBar.localScale.x, HealthBar.localScale.y)));
        GUI.Box(new Rect(new Vector2(0, 0), new Vector2(HealthBar.localScale.x, HealthBar.localScale.y)), EmptyHealthBar);

        //draw the filled in part
        GUI.BeginGroup(new Rect(new Vector2(HealthBar.position.x, HealthBar.position.y), new Vector2(HealthBar.localScale.x * HealthBarDisplay, HealthBar.localScale.y)));
        GUI.Box(new Rect(new Vector2(0, 0), new Vector2(HealthBar.localScale.x, HealthBar.localScale.y)), FullHealthBar);


        //draw the backgroud
        GUI.BeginGroup(new Rect(new Vector2(SanityBar.position.x, SanityBar.position.y), new Vector2(SanityBar.localScale.x, SanityBar.localScale.y)));
        GUI.Box(new Rect(new Vector2(0, 0), new Vector2(SanityBar.localScale.x, SanityBar.localScale.y)), EmptySanityBar);

        //draw the filled in part
        GUI.BeginGroup(new Rect(new Vector2(SanityBar.position.x, SanityBar.position.y), new Vector2(SanityBar.localScale.x * SanityBarDisplay, SanityBar.localScale.y)));
        GUI.Box(new Rect(new Vector2(0, 0), new Vector2(SanityBar.localScale.x, SanityBar.localScale.y)), FullSanityBar);


        GUI.EndGroup();
        GUI.EndGroup();
        GUI.EndGroup();
        GUI.EndGroup();
    }


    void Update ()
    {
        HealthBarDisplay = GetComponent<PlayerScript>().CurrentHealth;
	}
}

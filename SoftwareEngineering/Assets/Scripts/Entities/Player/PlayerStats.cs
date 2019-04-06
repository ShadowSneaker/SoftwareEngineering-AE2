using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats 
{
    private static int Strength = 8;
    private static int Agility = 5;
    private static int Intelligence = 2;
    private static int Willpower = 5;
    private static int Perception = 3;
    private static int Charisma = 2;


    public static int ModStrength
    {
        get
        {
            return Strength;
        }
        set
        {
            Strength = value;
        }
    }

    public static int ModAgility
    {
        get
        {
            return Agility;
        }
        set
        {
            Agility = value;
        }
    }


    public static int ModIntelligence
    {
        get
        {
            return Intelligence;
        }
        set
        {
            Intelligence = value;
        }
    }


    public static int ModWillpower
    {
        get
        {
            return Willpower;
        }
        set
        {
            Willpower = value;
        }
    }


    public static int ModPerception
    {
        get
        {
            return Perception;
        }
        set
        {
            Perception = value;
        }
    }


    public static int ModCharisma
    {
        get
        {
            return Charisma;
        }
        set
        {
            Charisma = value;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomArchive : MonoBehaviour
{
    public string[] Keys;
    public GameObject[] Values;

    private Dictionary<string, GameObject> Rooms = new Dictionary<string, GameObject>();


    private void Start()
    {
        if (Keys.Length == Values.Length)
        {
            for (int i = 0; i < Keys.Length; ++i)
            {
                Rooms.Add(Keys[i], Values[i]);
            }
        }
        else
        {
            Debug.LogError("Error: The amount of keys does not match the amount of values.");
        }
    }


    public void OpenRooms(string[] RoomList)
    {
        GameObject Room;
        for (int i = 0; i < RoomList.Length; ++i)
        {
            if (Rooms.TryGetValue(RoomList[i], out Room))
            {
                if (!Room.activeInHierarchy)
                {
                    Room.SetActive(true);
                }
            }
        }
    }

    public void CloseRooms(string[] RoomList)
    {
        GameObject Room;
        for (int i = 0; i < RoomList.Length; ++i)
        {
            if (Rooms.TryGetValue(RoomList[i], out Room))
            {
                if (Room.activeSelf)
                {
                    Room.SetActive(false);
                }
            }
        }
    }
}

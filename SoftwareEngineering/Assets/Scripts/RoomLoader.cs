using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RoomLoader : MonoBehaviour
{
    // WARNING - Only use this for the base scene, Not any other scene.
    // Creates a scene on startup.
    //public string StartRoom;

    // Unloads all open scenes in the game.
    //public bool ShouldUnloadAllRooms;

    // A list of rooms that will be opened.
    public string[] LoadRooms;

    // A list of rooms that will be closed.
    public string[] UnloadRooms;


    private RoomArchive Archive;


    /// Functions

    private void Awake()
    {
        Archive = FindObjectOfType<RoomArchive>();

        //if (StartRoom != "")
        //{
        //    SceneManager.LoadScene(StartRoom, LoadSceneMode.Additive);
        //}
    }



    //public void InitiateStream()
    //{
    //    // Load new rooms.
    //    for (int i = 0; i < LoadRooms.Length; ++i)
    //    {
    //        if (!CheckSceneLoaded(LoadRooms[i]))
    //        {
    //            SceneManager.LoadScene(LoadRooms[i], LoadSceneMode.Additive);
    //        }
    //    }
    //
    //
    //    // Unload old rooms.
    //    for (int i = 0; i < UnloadRooms.Length; ++i)
    //    {
    //        if (CheckSceneLoaded(LoadRooms[i]))
    //        {
    //            SceneManager.UnloadSceneAsync(UnloadRooms[i]);
    //            Debug.Log(UnloadRooms[i]);
    //        }
    //    }
    //}


    // Returns true if the specified scene is open.
    //protected bool CheckSceneLoaded(string Scene)
    //{
    //    for (int i = 0; i < SceneManager.sceneCount; ++i)
    //    {
    //        if (SceneManager.GetSceneAt(i).name == Scene)
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}


    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player") && Archive)
        {
            Archive.OpenRooms(LoadRooms);
            Archive.CloseRooms(UnloadRooms);
        }

        //if (ShouldUnloadAllRooms)
        //{
        //    for (int i = 0; i < SceneManager.sceneCount; ++i)
        //    {
        //        SceneManager.UnloadSceneAsync(i);
        //    }
        //}
        //else
        //{
        //    InitiateStream();
        //}
    }
}

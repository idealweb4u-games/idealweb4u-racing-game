using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;

public class OurSceneManager : MonoBehaviour
{

    

    public int sceneIndex;
    public void SceneSwitcher()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene(0);
        }
    }


    //public enum Scenes { Beach, Forest, Garage, Snow, Start }

    //public void SceneSwitch(Scenes sceneName)
    //{
    //    SceneManager.LoadScene(GetSceneName(sceneName));
    //}

    //public string GetSceneName(Scenes sceneName)
    //{
    //    switch (sceneName)
    //    {
    //        case Scenes.Beach:
    //            return "Beach";
    //        case Scenes.Forest:
    //            return "Forest";
    //        case Scenes.Garage:
    //            return "Garage";
    //        case Scenes.Snow:
    //            return "Snow";
    //        case Scenes.Start:
    //            return "Start";
    //        default:
    //            return "";
    //    }
    //}
}
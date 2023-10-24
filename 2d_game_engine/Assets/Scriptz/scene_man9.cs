using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_man9 : MonoBehaviour
{
    [SerializeField]                       //opposite of hide in inspector
    private string gameSceneName = "SampleScene";

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);        //loads scene
    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundDestruction : MonoBehaviour
{

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name != "Loading")
        {
            if (currentScene.name != "Lobby")
            {
                Destroy(gameObject);
            }
        }
    }


    void Update()
    {
        
    }
}

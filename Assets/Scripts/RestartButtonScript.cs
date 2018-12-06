using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartButtonScript : MonoBehaviour {
    public string LevelToLoad = "GameMap1";
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void restartScene()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
    

}

    

	


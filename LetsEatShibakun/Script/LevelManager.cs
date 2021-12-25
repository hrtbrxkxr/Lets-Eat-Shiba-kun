using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    
    // void Awake() 
    // {
    //     DontDestroyOnLoad(transform.gameObject);
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    // }
    public void Restart() {
        //1.Restart Scene
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
   
}

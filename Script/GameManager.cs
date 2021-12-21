using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int need;
    private int collect;
    [SerializeField] private string sceneName;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    private static GameManager instance;

    public static GameManager MyInstance
    {
        get
        {
            if(instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    public void AddFood(int _collect)
    {
        collect += _collect;
        UIManager.MyInstance.UpdateCollectUI(collect,need);
    }

    public void Finish()
    {
        if(collect >= need)
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            UIManager.MyInstance.ShowVictoryCondition(collect,need);
        }
    }
}

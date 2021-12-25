using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI collect, need;
    [SerializeField] GameObject passCondition;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else{
            DestroyImmediate(this);
        }
    }
    private static UIManager instance;

    public static UIManager MyInstance
    {
        get
        {
            if (instance == null) 
            {
                instance = new UIManager();
            }
            return instance;
        }
    }

    public void UpdateCollectUI(int _collect,int _passCondition)
    {
        collect.text = "Collectable : " + _collect + " / " +_passCondition;
    }

    public void ShowVictoryCondition(int _collect,int _passCondition)
    {
        passCondition.SetActive(true);
        need.text = "Shiba-kun need " + (_passCondition - _collect) + (" more food !");    
    }
    public void HideVictoryCondition()
    {
        passCondition.SetActive(false);
        
    }
}

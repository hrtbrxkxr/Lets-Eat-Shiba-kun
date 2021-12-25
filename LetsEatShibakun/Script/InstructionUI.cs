using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UI.Instructions 
{
    public class Instruction

    {
        public string stage;
        public string collectName;
        public string uncollectName;
        public string canCollect;
        public string cantCollect;

    }

    public class InstructionUI : MonoBehaviour
    {
        public static InstructionUI Instance;
        [SerializeField] GameObject canvas;
        [SerializeField] TextMeshProUGUI stage;
        [SerializeField] TextMeshProUGUI collectName;
        [SerializeField] TextMeshProUGUI uncollectName;
        [SerializeField] TextMeshProUGUI canCollect;
        [SerializeField] TextMeshProUGUI cantCollect;
        [SerializeField] Image collectIMG;
        [SerializeField] Image uncollectIMG;
        [SerializeField] Button closeButton;
    

        Instruction instruct = new Instruction();
        void Awake() 
        {
            Instance = this;
            closeButton.onClick.RemoveAllListeners();
            closeButton.onClick.AddListener(Hide);
        }

        public InstructionUI SetStage(string stageID)
        {
            instruct.stage = stageID;
            return Instance;
        }

        public void Show() 
        {
            stage.text = instruct.stage;
            collectName.text = instruct.collectName;
            uncollectName.text = instruct.uncollectName;
            canCollect.text = instruct.canCollect;
            cantCollect.text = instruct.canCollect;

            instruct = new Instruction();

            canvas.SetActive(true);
        }

        public void Hide() 
        {
            canvas.SetActive(false);
            instruct = new Instruction();
        }
    }

}

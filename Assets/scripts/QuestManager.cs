using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public string[] objectives;
    public string currentQuest;

    private Text questText;
    GameObject questBox;

    public int currentStep;

    public bool hasQuest = false;

    public int acceptedQuest = 0;

    private void Start()
    {
        questText = GameObject.Find("QuestText").GetComponent<Text>();
        questBox = GameObject.Find("QuestBox");
    }

    private void Update()
    {
        if (hasQuest)
        {
            questText.text = currentQuest + ": " + objectives[currentStep];
            questBox.SetActive(true);
        }
        else
        {
            questText.text = "";
            questBox.SetActive(false);
        }    
    }

    public void Accept()
    {
        acceptedQuest = 1;
    }
    public void Decline()
    {
        acceptedQuest = -1;
    }
}

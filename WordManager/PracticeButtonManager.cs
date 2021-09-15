using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeButtonManager : MonoBehaviour
{

    public GameObject selectorPanel;
    public GameObject practicePanel;

    public WordPractice wordPractice;

    public void OnAppleClick()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 0;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnBoneClick()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 1;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnCaneClicked()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 2;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnChainClicked()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 3;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnChalkClicked()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 4;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnClamClicked()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 5;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnClawClicked()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 6;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }
    public void OnCloudClick()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 7;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnFlagClicked()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 8;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnFortClicked()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 9;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnHornClicked()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 10;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnKingClicked()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 11;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnNoteClicked()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 12;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnRabbitClicked()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 13;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnSchoolClicked()
    {
        selectorPanel.SetActive(false);
        practicePanel.SetActive(true);
        wordPractice.wordIndex = 14;
        wordPractice.isInPractice = true;
        wordPractice.AddWord();
    }

    public void OnBackClicked()
    {
        selectorPanel.SetActive(true);
        practicePanel.SetActive(false);

        wordPractice.isInPractice = false;
        Destroy(GameObject.Find("Word(Clone)"));
    }
}

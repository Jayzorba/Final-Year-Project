using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Windows.Speech;
using UnityEngine;
using UnityEngine.UI;

public class WordManager : MonoBehaviour
{
    public Word activeWord;
    public List<AudioClip> wordSounds;

    public WordSpawner wordSpawner;

    public Text scoreText;
    private int score;

    public GameObject gameOverPanel;

    public Text timerText;
    private float wordDelay = 30f;
    private float nextWordTime = 0f;

    public GameObject parrotSprite;

    public AudioSource wordCompleteSound;
    public AudioSource wordNames;

    private void Start()
    {
        AddWord();
        timerText.text = wordDelay.ToString();
        scoreText.text = "Score: 0";
    }

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        activeWord = word;

        for (int i = 0; i < WordGenerator.wordList.Length; i++)
        {
            if(word.word == WordGenerator.wordList[i])
            {
                wordNames.clip = wordSounds[i];
            }
        }

        wordNames.Play();
    }

    public void TypeLetter (char letter)
    {

        if(activeWord.GetNextLetter() == letter)
        {
            activeWord.TypeLetter();
        }
        
    }

    private void Update()
    {
        timerText.text = Mathf.Ceil(wordDelay).ToString();
        wordDelay -= Time.deltaTime;
        if (wordDelay >= nextWordTime && activeWord.WordComplete())
        {
            WordCompleteSoundPlay();

            activeWord = null;

            score += 10 * (int)wordDelay/2;
            scoreText.text = "Score: " + score.ToString();

            AddWord();

            nextWordTime = 0f;
            wordDelay = 30f;
        }
        else if(wordDelay <= nextWordTime)
        {
            activeWord = null;

            gameOverPanel.SetActive(true);
            wordDelay = 0;
            Destroy(GameObject.Find("Word(Clone)"));
        }
        if(wordNames.isPlaying)
        {
            parrotSprite.SetActive(true);
        }
        else
        {
            parrotSprite.SetActive(false);
        }
    }

    public void WordCompleteSoundPlay()
    {
        wordCompleteSound.Play();
    }
}
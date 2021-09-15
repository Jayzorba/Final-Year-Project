using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Windows.Speech;
using UnityEngine;
using UnityEngine.UI;

public class WordPractice : MonoBehaviour
{
    public Word activeWord;

    public WordSpawner wordSpawner;

    public int wordIndex =0;

    public bool isInPractice = false;

    public List<Sprite> sprites;
    public Image displaySprite;


    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetPracticeWord(wordIndex), wordSpawner.SpawnWord());

        activeWord = word;

        displaySprite.sprite = sprites[wordIndex];
        
    }

    public void TypeLetter(char letter)
    {
        if (activeWord.GetNextLetter() == letter)
        {
            activeWord.TypeLetter();
        }
    }

    private void Update()
    {
        if( isInPractice)
        {
            if (activeWord.WordComplete())
            {
                activeWord = null; 

                AddWord();
            }
        }

        else if (!isInPractice)
        {
            activeWord = null;
        }
    }
}

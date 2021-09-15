using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class WordGenerator : MonoBehaviour
{
    private static string readFromFilePath = Application.streamingAssetsPath + "\\words" + ".txt";
    public static string[] wordList = File.ReadAllLines(readFromFilePath).ToArray();
    private void Start()
    {
        
    }
    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

    public static string GetPracticeWord(int wordIndex)
    {
        string practiceWord = wordList[wordIndex];

        return practiceWord;
    }
}

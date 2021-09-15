using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Linq;
using UnityEngine.Windows.Speech;

public class WordInput : MonoBehaviour
{

    public WordManager wordManager;
    private char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                                          'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
                                          'w', 'x', 'y', 'z' };

    private Dictionary<string, Action> keywordSpoken;
    private KeywordRecognizer keywordRecognizer;


    private void Start()
    {
        keywordSpoken = new Dictionary<string, Action>()
        {
            { "a", () => LetterA() },
            { "b", () => LetterB() },
            { "c", () => LetterC() },
            { "d", () => LetterD() },
            { "e", () => LetterE() },
            { "f", () => LetterF() },
            { "g", () => LetterG() },
            { "h", () => LetterH() },
            { "i", () => LetterI() },
            { "j", () => LetterJ() },
            { "k", () => LetterK() },
            { "l", () => LetterL() },
            { "m", () => LetterM() },
            { "n", () => LetterN() },
            { "o", () => LetterO() },
            { "p", () => LetterP() },
            { "q", () => LetterQ() },
            { "r", () => LetterR() },
            { "s", () => LetterS() },
            { "t", () => LetterT() },
            { "u", () => LetterU() },
            { "v", () => LetterV() },
            { "w", () => LetterW() },
            { "x", () => LetterX() },
            { "y", () => LetterY() },
            { "z", () => LetterZ() }
        };

        keywordRecognizer = new KeywordRecognizer(keywordSpoken.Keys.ToArray(), ConfidenceLevel.Low);
        keywordRecognizer.OnPhraseRecognized += RecognisedLetter;
        keywordRecognizer.Start();
    }

    private void RecognisedLetter(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        keywordSpoken[speech.text].Invoke();
    }

    public void LetterA()
    {
        wordManager.TypeLetter(letters[0]);
    }

    public void LetterB()
    {
        wordManager.TypeLetter(letters[1]);
    }

    public void LetterC()
    {
        wordManager.TypeLetter(letters[2]);
    }

    public void LetterD()
    {
        wordManager.TypeLetter(letters[3]);
    }

    public void LetterE()
    {
        wordManager.TypeLetter(letters[4]);
    }

    public void LetterF()
    {
        wordManager.TypeLetter(letters[5]);
    }

    public void LetterG()
    {
        wordManager.TypeLetter(letters[6]);
    }

    public void LetterH()
    {
        wordManager.TypeLetter(letters[7]);
    }

    public void LetterI()
    {
        wordManager.TypeLetter(letters[8]);
    }

    public void LetterJ()
    {
        wordManager.TypeLetter(letters[9]);
    }

    public void LetterK()
    {
        wordManager.TypeLetter(letters[10]);
    }

    public void LetterL()
    {
        wordManager.TypeLetter(letters[11]);
    }

    public void LetterM()
    {
        wordManager.TypeLetter(letters[12]);
    }

    public void LetterN()
    {
        wordManager.TypeLetter(letters[13]);
    }

    public void LetterO()
    {
        wordManager.TypeLetter(letters[14]);
    }

    public void LetterP()
    {
        wordManager.TypeLetter(letters[15]);
    }

    public void LetterQ()
    {
        wordManager.TypeLetter(letters[16]);
    }

    public void LetterR()
    {
        wordManager.TypeLetter(letters[17]);
    }

    public void LetterS()
    {
        wordManager.TypeLetter(letters[18]);
    }

    public void LetterT()
    {
        wordManager.TypeLetter(letters[19]);
    }

    public void LetterU()
    {
        wordManager.TypeLetter(letters[20]);
    }

    public void LetterV()
    {
        wordManager.TypeLetter(letters[21]);
    }

    public void LetterW()
    {
        wordManager.TypeLetter(letters[22]);
    }

    public void LetterX()
    {
        wordManager.TypeLetter(letters[23]);
    }

    public void LetterY()
    {
        wordManager.TypeLetter(letters[24]);
    }

    public void LetterZ()
    {
        wordManager.TypeLetter(letters[25]);
    }

}

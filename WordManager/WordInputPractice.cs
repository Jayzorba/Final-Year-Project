using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;


public class WordInputPractice : MonoBehaviour
{

    public WordPractice wordPractice;
    private char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 
                                          'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
                                          'w', 'x', 'y', 'z' };

    private Dictionary<string, Action> keywordSpoken = new Dictionary<string, Action>();
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
        keywordSpoken[speech.text].Invoke();
    }

    public void LetterA()
    {
        wordPractice.TypeLetter(letters[0]);
    }

    public void LetterB()
    {
        wordPractice.TypeLetter(letters[1]);
    }

    public void LetterC()
    {
        wordPractice.TypeLetter(letters[2]);
    }

    public void LetterD()
    {
        wordPractice.TypeLetter(letters[3]);
    }

    public void LetterE()
    {
        wordPractice.TypeLetter(letters[4]);
    }

    public void LetterF()
    {
        wordPractice.TypeLetter(letters[5]);
    }

    public void LetterG()
    {
        wordPractice.TypeLetter(letters[6]);
    }

    public void LetterH()
    {
        wordPractice.TypeLetter(letters[7]);
    }

    public void LetterI()
    {
        wordPractice.TypeLetter(letters[8]);
    }

    public void LetterJ()
    {
        wordPractice.TypeLetter(letters[9]);
    }

    public void LetterK()
    {
        wordPractice.TypeLetter(letters[10]);
    }

    public void LetterL()
    {
        wordPractice.TypeLetter(letters[11]);
    }

    public void LetterM()
    {
        wordPractice.TypeLetter(letters[12]);
    }

    public void LetterN()
    {
        wordPractice.TypeLetter(letters[13]);
    }

    public void LetterO()
    {
        wordPractice.TypeLetter(letters[14]);
    }

    public void LetterP()
    {
        wordPractice.TypeLetter(letters[15]);
    }

    public void LetterQ()
    {
        wordPractice.TypeLetter(letters[16]);
    }

    public void LetterR()
    {
        wordPractice.TypeLetter(letters[17]);
    }

    public void LetterS()
    {
        wordPractice.TypeLetter(letters[18]);
    }

    public void LetterT()
    {
        wordPractice.TypeLetter(letters[19]);
    }

    public void LetterU()
    {
        wordPractice.TypeLetter(letters[20]);
    }

    public void LetterV()
    {
        wordPractice.TypeLetter(letters[21]);
    }

    public void LetterW()
    {
        wordPractice.TypeLetter(letters[22]);
    }

    public void LetterX()
    {
        wordPractice.TypeLetter(letters[23]);
    }

    public void LetterY()
    {
        wordPractice.TypeLetter(letters[24]);
    }

    public void LetterZ()
    {
        wordPractice.TypeLetter(letters[25]);
    }

}

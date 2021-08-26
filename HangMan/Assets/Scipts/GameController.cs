using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text timeField;
    public Text wordToFindField;
    private float time;
    private string[] wordsLocal = { "TERRARIA", "MINECRAFT", "APEX LEGENDS", "FORTNITE", "GENSHIN IMPACT", "FARCRY", "KARLSON", "WARCRAFT", "SPELLBREAK", "TITANFALL", "CALL OF DUTY" };
    private string chosenWord;
    private string hiddenWord;


    // Start is called before the first frame update
    void Start()
    {
        //for(int i = 0; i < wordsLocal.Length; i++)
        //{
        //    Debug.Log(wordsLocal[i]);
        //}

        chosenWord = wordsLocal[Random.Range(0, wordsLocal.Length)];

        for (int i = 0; i < chosenWord.Length; i++)
        {
            char letter = chosenWord[i];
            if(char.IsWhiteSpace(letter))
            {
                hiddenWord += " ";
            }
            else
            {
                hiddenWord += "_ ";
            }

            
        }
        
        
        wordToFindField.text = hiddenWord;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeField.text = time.ToString();
    }
}

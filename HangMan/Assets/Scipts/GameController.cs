using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text timeField;
    public GameObject[] hangMan;
    public GameObject winText;
    public GameObject loseText;
    public Text wordToFindField;
    private float time;
    private string[] wordsLocal = { "TERRARIA", "MINECRAFT", "APEX LEGENDS", "FORTNITE", "GENSHIN IMPACT", "FARCRY", "KARLSON", "WARCRAFT", "SPELLBREAK", "TITANFALL", "CALL OF DUTY" };
    private string chosenWord;
    private string hiddenWord;
    private int fails;
    private bool gameEnd = false;


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
                hiddenWord += "-";
            }

            
        }
        
        
        wordToFindField.text = hiddenWord;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnd == false)
        {
            time += Time.deltaTime;
            timeField.text = time.ToString();
        }
    }


    private void OnGUI()
    {
        Event e = Event.current;
        if(e.type == EventType.KeyDown && e.keyCode.ToString().Length == 1)
        {
            string pressedLetter = e.keyCode.ToString();

            Debug.Log("KeyDown event has been triggered " + pressedLetter);

            if(chosenWord.Contains(pressedLetter))
            {
                int i = chosenWord.IndexOf(pressedLetter);
                while(i != -1)
                {
                    hiddenWord = hiddenWord.Substring(0, i) + pressedLetter + hiddenWord.Substring(i + 1);

                    chosenWord = chosenWord.Substring(0, i) + "-" + chosenWord.Substring(i + 1);


                    i =  chosenWord.IndexOf(pressedLetter);
                }

                wordToFindField.text = hiddenWord;

            }
            else
            {
                hangMan[fails].SetActive(true);
                fails++;
            }
            if(fails == hangMan.Length)
            {
                loseText.SetActive(true);
                gameEnd = true;
            }
            if(!hiddenWord.Contains("-"))
            {
                winText.SetActive(true);
                gameEnd = true;
            }
        }
    }

}

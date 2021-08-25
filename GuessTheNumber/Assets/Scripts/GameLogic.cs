using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public InputField userInput;
    public Text gameLabel;
    public int minValue;
    public int maxValue;
    public Button gameButton;

    private int randomNum;

    // Start is called before the first frame update
    void Start()
    {
        randomNum = GetRandomNumber(minValue, maxValue);
        gameLabel.text = "scale: " + minValue + "-" + (maxValue - 1) + ".";
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnButtonClick()
    {
        string userInputValue = userInput.text;
        if(userInputValue != "")
        {
            int answer = int.Parse(userInputValue);

            if (answer == randomNum)
            {
                gameLabel.text = "wow";
                gameButton.interactable = false;
            }
            else if (answer < randomNum)
            {
                gameLabel.text = "higha";
            }
            else if (answer > randomNum)
            {
                gameLabel.text = "lowa";
            }
        }

        else
        {
            gameLabel.text = "uuuh, im not a mind reader.";
        }
    }

    private int GetRandomNumber(int min, int max)
    {
        int random = Random.Range(min, max);
        return random;
    }

}

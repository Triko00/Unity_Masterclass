using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public InputField userInput;
    public Text gameLabel;


    public int randomNum;

    // Start is called before the first frame update
    void Start()
    {
        randomNum = 10;
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

}

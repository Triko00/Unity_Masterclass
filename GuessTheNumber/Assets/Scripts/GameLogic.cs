using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public InputField userInput;
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
        Debug.Log(userInput.text);
        Debug.Log("the totally random number is: " + randomNum + ".");
    }

}

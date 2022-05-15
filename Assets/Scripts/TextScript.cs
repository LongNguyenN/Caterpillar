using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
  Handles all the text behaviour
*/
public class TextScript : MonoBehaviour
{
  public TMP_InputField hello;
  public TextMeshProUGUI currentWord;
  public TextMeshProUGUI completed;
  public GameObject textHandler;

  //Auto generate a word upon the game starting
  public void Start() {
    currentWord.text = "Current Word:\n" + textHandler.GetComponent<TextManagerScript>().generateFirstWord();
  }

  //Once the user presses the enter button, this function checks
  //if the user input is valid and how to proceed with the game
  public void onReturnPressed() {
    string score = textHandler.GetComponent<TextManagerScript>().onSuggestionInput(hello.text);
    if(score != null) {
      currentWord.text = "Current Word:\n" + hello.text;
      completed.text = "Have Completed:\n" + score;
    }
    hello.text = "";
  }

}

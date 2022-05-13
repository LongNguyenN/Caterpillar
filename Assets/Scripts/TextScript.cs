using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
  public TMP_InputField hello;
  public TextMeshProUGUI currentWord;
  public TextMeshProUGUI completed;
  private TouchScreenKeyboard keyboard;
  private int count = 0;

  public void onReturnPressed() {
    string score = onSuggestionInput(hello.text);
    if(score != null) {
      currentWord.text = "Current Word:\n" + hello.text;
      completed.text = score;
    }
    hello.text = "";
  }

  //A user has given an input via pressing the return key
  //Returns a string which contains the completed letters list
  //Returns null if user input is invalid
  string onSuggestionInput(string userInput) {
    count++;
    return "Have Completed:\nYou have not won yet!" + count;
  }
}

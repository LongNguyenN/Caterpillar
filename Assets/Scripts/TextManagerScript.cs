using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManagerScript : MonoBehaviour
{


  //A user has given an input via pressing the return key
  //Returns a string with the bank
  //Returns null if user input is invalid
  public string onSuggestionInput(string userInput) {

    // //if word is valid
    // return bank;
    // //else if word is invalid
    return "This is working";
  }

  //return a word for the first word of the game
  public string generateFirstWord() {
    // Random rand = new Random();
    // int target_num = rand.nextInt(approved.size());
    // String target = approved.get(target_num);
    // return target;
    return "The first word!";
  }

//   // Creates the list of approved words for the game
//   ArrayList<String> approved = new ArrayList<String>();
//   Scanner scan = new Scanner( new File ("dictionary.txt"));
//   int count = 0;
//
//   // count the number of words used for a score
//   void start(){
//     while(scan.hasNext()){
//       approved.add(scan.nextLine());
//     }
//   }
//   // picks the starting word
//
//
//   String game(){
//   // the word to be linked
//
//   // The words that have been used are store in this list
//   ArrayList<String> used = new ArrayList<String>();
//   used.add(target);
//
//   // The initals of your words are stored here.
//
//   char[] bank = new char[28];
//   bank[0] = '[';
//   bank[27] = ']';
//   for(int i = 1; i < bank.length - 1; i++){
//     bank[i] = '?';
//   }
//
//   //System.out.println(bank);
//
//   // shows your bank balance
//   String test = bank.toString();
//
//   // while(test.indexOf('?') == -1 ){
//   //   count += 1;
//   //   System.out.println( "Link the word | "  + target + " ");
//   //   System.out.print ("Your word is : " );
//   //
//   //   // user's input
//   //   scan = new Scanner(System.in);
//   //   String response = scan.nextLine();
//   //
//   //   // Test if you met the rules of the game
//   //   char f_inital = response.charAt(0);
//   //   char e_inital = target.charAt(target.length() - 1 );
//   //   if (f_inital == e_inital && !used.contains(response)  && approved.contains(response)){
//   //     String alpha = "[abcdefghijklmnopqrstuvwxyz]";
//   //     // for keeping score of your bank balance
//   //     int hit = alpha.indexOf(f_inital);
//   //     bank[hit] = f_inital;
//
//
//       // System.out.println("\nGoal   =  " + alpha);
//       // System.out.print("current = ");
//       // System.out.println(bank);
//
//       // Turns your response into the word you will need to link.
//       //target = response;
//       //test = bank.toString();
//       return test;
//     // }else{
//     //   continue;
//     // }
//   }
//   scan.close();
//   System.out.println("Congrats it took " + count + " words for you to win!");
//   }
//   }
// }
}

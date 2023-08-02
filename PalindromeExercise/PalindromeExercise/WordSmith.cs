using System;


namespace PalindroneExercise
{
    public class WordSmith
    {
        public bool IsAPalindrone (string word)
        {
            //reverse the word // racecar Length -->7 --> 6
            var reversed = "";
        for (int i = word.Length -1 ; i >= 0; i--) 
            { 
            reversed += word[i];
            }
        //compared the original with the reversed
        if (reversed.ToLower() == word.ToLower()) 
            { 
            return true;
            }
            else
            { 
            return false;
            }
         //return whether they are the same

        
        }
    }
}

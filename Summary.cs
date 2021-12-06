using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Summary : MonoBehaviour
{
   public static string nameTextstr,accTextstr,dateTextstr,remarksTextstr;
    public static string  Q1Fieldstr, Q2Fieldstr, Q3Fieldstr, Q4Fieldstr, Q5Fieldstr, Q6Fieldstr, Q7Fieldstr, Q8Fieldstr, Q9Fieldstr, Q10Fieldstr, Q11Fieldstr, Q12Fieldstr ;
   
   public TMP_Text nameText, accText,dateText,remarksText;
   public TMP_Text Q1Field, Q2Field, Q3Field, Q4Field, Q5Field, Q6Field, Q7Field, Q8Field, Q9Field, Q10Field, Q11Field, Q12Field ;
    
    void Start()
    {
        nameText.text = nameTextstr;
        nameTextstr = PlayerPrefs.GetString("nameTextstrKeyName");

        accText.text = accTextstr;
        accTextstr = PlayerPrefs.GetString("accTextstrKeyName");

        dateText.text = dateTextstr;
        dateTextstr = PlayerPrefs.GetString("dateTextstrKeyName");

        remarksText.text = remarksTextstr;
        remarksTextstr = PlayerPrefs.GetString("remarksTextstrKeyName");

        Q1Field.text = Q1Fieldstr;
        Q1Fieldstr = PlayerPrefs.GetString("Q1FieldstrKeyName");

        Q2Field.text = Q2Fieldstr;
        Q2Fieldstr = PlayerPrefs.GetString("Q2FieldstrKeyName");

        Q3Field.text = Q3Fieldstr;
        Q3Fieldstr = PlayerPrefs.GetString("Q3FieldstrKeyName");

        Q4Field.text = Q4Fieldstr;
        Q4Fieldstr = PlayerPrefs.GetString("Q4FieldstrKeyName");

        Q5Field.text = Q5Fieldstr;
        Q5Fieldstr = PlayerPrefs.GetString("Q5FieldstrKeyName");

        Q6Field.text = Q6Fieldstr;
        Q6Fieldstr = PlayerPrefs.GetString("Q6FieldstrKeyName");

        Q7Field.text = Q7Fieldstr;
        Q7Fieldstr = PlayerPrefs.GetString("Q7FieldstrKeyName");

        Q8Field.text = Q8Fieldstr;
        Q8Fieldstr = PlayerPrefs.GetString("Q8FieldstrKeyName");

        Q9Field.text = Q9Fieldstr;
        Q9Fieldstr = PlayerPrefs.GetString("Q9FieldstrKeyName");

        Q10Field.text = Q10Fieldstr;
        Q10Fieldstr = PlayerPrefs.GetString("Q10FieldstrKeyName");

        Q11Field.text = Q11Fieldstr;
        Q11Fieldstr = PlayerPrefs.GetString("Q11FieldstrKeyName");

        Q12Field.text = Q12Fieldstr;
        Q12Fieldstr = PlayerPrefs.GetString("Q12FieldstrKeyName");
    }

   public void BacktoStart()
   {
       SceneManager.LoadScene("MainMenu");
   }

   public void JustSave()
   {
       nameTextstr = nameText.text;
       PlayerPrefs.SetString("nameTextstrKeyName", nameTextstr);

       accTextstr = accText.text;
       PlayerPrefs.SetString("accTextstrKeyName", accTextstr);

       dateTextstr = dateText.text;
       PlayerPrefs.SetString("dateTextstrKeyName", dateTextstr);

       remarksTextstr = remarksText.text;
       PlayerPrefs.SetString("remarksTextstrKeyName", remarksTextstr);

       Q1Fieldstr = Q1Field.text;
       PlayerPrefs.SetString("Q1FieldstrKeyName", Q1Fieldstr);

       Q2Fieldstr = Q2Field.text;
       PlayerPrefs.SetString("Q2FieldstrKeyName", Q2Fieldstr);

       Q3Fieldstr = Q3Field.text;
       PlayerPrefs.SetString("Q3FieldstrKeyName", Q3Fieldstr);

       Q4Fieldstr = Q4Field.text;
       PlayerPrefs.SetString("Q4FieldstrKeyName", Q4Fieldstr);

       Q5Fieldstr = Q5Field.text;
       PlayerPrefs.SetString("Q5FieldstrKeyName", Q5Fieldstr);

       Q6Fieldstr = Q6Field.text;
       PlayerPrefs.SetString("Q6FieldstrKeyName", Q6Fieldstr);

       Q7Fieldstr = Q7Field.text;
       PlayerPrefs.SetString("Q7FieldstrKeyName", Q7Fieldstr);

       Q8Fieldstr = Q8Field.text;
       PlayerPrefs.SetString("Q8FieldstrKeyName", Q8Fieldstr);

       Q9Fieldstr = Q9Field.text;
       PlayerPrefs.SetString("Q9FieldstrKeyName", Q9Fieldstr);

       Q10Fieldstr = Q10Field.text;
       PlayerPrefs.SetString("Q10FieldstrKeyName", Q10Fieldstr);

       Q11Fieldstr = Q11Field.text;
       PlayerPrefs.SetString("Q11FieldstrKeyName", Q11Fieldstr);

       Q12Fieldstr = Q12Field.text;
       PlayerPrefs.SetString("Q12FieldstrKeyName", Q12Fieldstr);
       
   }
}


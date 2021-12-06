using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveInputFields : MonoBehaviour

{
    
    public  TMP_InputField nameText;
    public  TMP_InputField accText;
    public  TMP_InputField dateText;
    public  TMP_InputField remarksText;
    public TMP_InputField Q1Field, Q2Field, Q3Field, Q4Field, Q5Field, Q6Field, Q7Field, Q8Field, Q9Field, Q10Field, Q11Field, Q12Field ;
    public TMP_Text errorText;

    public string nText;
    public string aText;
    public string dText;
    public string rText;
    public string text,text2,text3,text4,text5,text6,text7,text8,text9,text10,text11,text12;
    const string errorMessage = "Please answer all fields!!";

    public void Start() //to read value of input fields to be saved later
    {
        nText = PlayerPrefs.GetString("nTextKeyName");
        nameText.text = nText;

        aText = PlayerPrefs.GetString("aTextKeyName");
        accText.text = aText;

        dText = PlayerPrefs.GetString("dTextKeyName");
        dateText.text = dText;

        rText = PlayerPrefs.GetString("rTextKeyName");
        remarksText.text = rText;

        text = PlayerPrefs.GetString("textKeyName");
        Q1Field.text = text;

        text2 = PlayerPrefs.GetString("text2KeyName");
        Q2Field.text = text2;

        text3 = PlayerPrefs.GetString("text3KeyName");
        Q3Field.text = text3;

        text4 = PlayerPrefs.GetString("text4KeyName");
        Q4Field.text = text4;

        text5 = PlayerPrefs.GetString("text5KeyName");
        Q5Field.text = text5;

        text6 = PlayerPrefs.GetString("text6KeyName");
        Q6Field.text = text6;

        text7 = PlayerPrefs.GetString("text7KeyName");
        Q7Field.text = text7;

        text8 = PlayerPrefs.GetString("text8KeyName");
        Q8Field.text = text8;

        text9 = PlayerPrefs.GetString("text9KeyName");
        Q9Field.text = text9;

        text10 = PlayerPrefs.GetString("text10KeyName");
        Q10Field.text = text10;

        text11 = PlayerPrefs.GetString("text11KeyName");
        Q11Field.text = text11;

        text12 = PlayerPrefs.GetString("text12KeyName");
        Q12Field.text = text12;
    }

    public void SaveName() //to save input values
    {
         nText = nameText.text;
         PlayerPrefs.SetString("nTextKeyName", nText);

        aText = accText.text;
        PlayerPrefs.SetString("aTextKeyName", aText);

        dText = dateText.text;
        PlayerPrefs.SetString("dTextKeyName", dText);

        rText = remarksText.text;
        PlayerPrefs.SetString("rTextKeyName", rText);

        text = Q1Field.text;
        PlayerPrefs.SetString("textKeyName", text);

        text2 = Q2Field.text;
        PlayerPrefs.SetString("text2KeyName", text2);

        text3 = Q3Field.text;
        PlayerPrefs.SetString("text3KeyName", text3);

        text4 = Q4Field.text;
        PlayerPrefs.SetString("text4KeyName", text4);

        text5 = Q5Field.text;
        PlayerPrefs.SetString("text5KeyName", text5);

        text6 = Q6Field.text;
        PlayerPrefs.SetString("text6KeyName", text6);

        text7 = Q7Field.text;
        PlayerPrefs.SetString("text7KeyName", text7);

        text8 = Q8Field.text;
        PlayerPrefs.SetString("text8KeyName", text8);

        text9 = Q9Field.text;
        PlayerPrefs.SetString("text9KeyName", text9);

        text10 = Q10Field.text;
        PlayerPrefs.SetString("text10KeyName", text10);

        text11 = Q11Field.text;
        PlayerPrefs.SetString("text11KeyName", text11);

        text12 = Q12Field.text;
        PlayerPrefs.SetString("text12KeyName", text12);

    } // To read the values of Yes/No buttons. For displaying.

    public void Q1Answer(string text)
    {
         Q1Field.text = text;
    }

    public void Q2Answer(string text2)
    {
         Q2Field.text = text2;
    }

    public void Q3Answer(string text3)
    {
         Q3Field.text = text3;
    }

    public void Q4Answer(string text4)
    {
         Q4Field.text = text4;
    }

    public void Q5Answer(string text5)
    {
         Q5Field.text = text5;
    }

    public void Q6Answer(string text6)
    {
         Q6Field.text = text6;
    }

    public void Q7Answer(string text7)
    {
         Q7Field.text = text7;
    }

    public void Q8Answer(string text8)
    {
         Q8Field.text = text8;
    }

    public void Q9Answer(string text9)
    {
         Q9Field.text = text9;
    }

    public void Q10Answer(string text10)
    {
         Q10Field.text = text10;
    }

    public void Q11Answer(string text11)
    {
         Q11Field.text = text11;
    }

    public void Q12Answer(string text12)
    {
         Q12Field.text = text12;
    }

    public void BackMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ClickViewButton()
    {
        SceneManager.LoadScene("Summary Report");
    }

    public void ResetFields()
    {
         nameText.text = " ";
         accText.text = " ";
         dateText.text = " ";
         remarksText.text = " ";
         Q1Field.text = " ";
         Q2Field.text = " ";
         Q3Field.text = " ";
         Q4Field.text = " ";
         Q5Field.text = " ";
         Q6Field.text = " ";
         Q7Field.text = " ";
         Q8Field.text = " ";
         Q9Field.text = " ";
         Q10Field.text = " ";
         Q11Field.text = " ";
         Q12Field.text = " ";
    }
    
    public void LoadSumReport() //Summary Report page
    {
         Summary.nameTextstr = nameText.text;
         Summary.accTextstr = accText.text;
         Summary.dateTextstr = dateText.text;
         Summary.remarksTextstr = remarksText.text;
         Summary.Q1Fieldstr = Q1Field.text;
         Summary.Q2Fieldstr = Q2Field.text;
         Summary.Q3Fieldstr = Q3Field.text;
         Summary.Q4Fieldstr = Q4Field.text;
         Summary.Q5Fieldstr = Q5Field.text;
         Summary.Q6Fieldstr = Q6Field.text;
         Summary.Q7Fieldstr = Q7Field.text;
         Summary.Q8Fieldstr = Q8Field.text;
         Summary.Q9Fieldstr = Q9Field.text;
         Summary.Q10Fieldstr = Q10Field.text;
         Summary.Q11Fieldstr = Q11Field.text;
         Summary.Q12Fieldstr = Q12Field.text;

    }
     //Save button
     public void checkEmptyFields()
     {
          string nText = nameText.text;
          if(!string.IsNullOrWhiteSpace(nText))
          {
             string aText = accText.text;
             if(!string.IsNullOrWhiteSpace(aText))  
              {
                    string dText = dateText.text;
                    if(!string.IsNullOrWhiteSpace(dText))  
                    {
                      string rText = remarksText.text;
                      if(!string.IsNullOrWhiteSpace(rText))      
                      {
                         string text = Q1Field.text;
                         if(!string.IsNullOrWhiteSpace(text))  
                         {
                            string text2 = Q2Field.text;
                            if(!string.IsNullOrWhiteSpace(text2))   
                            {
                                 string text3 = Q3Field.text;
                                 if(!string.IsNullOrWhiteSpace(text3)) 
                                 {
                                      string text4 = Q4Field.text;
                                     if(!string.IsNullOrWhiteSpace(text4)) 
                                     {
                                          string text5 = Q5Field.text;
                                         if(!string.IsNullOrWhiteSpace(text5)) 
                                         {
                                               string text6 = Q6Field.text;
                                                if(!string.IsNullOrWhiteSpace(text6))
                                                {
                                                      string text7 = Q7Field.text;
                                                    if(!string.IsNullOrWhiteSpace(text7)) 
                                                    {
                                                          string text8 = Q8Field.text;
                                                           if(!string.IsNullOrWhiteSpace(text8)) 
                                                           {
                                                                 string text9 = Q9Field.text;
                                                                if(!string.IsNullOrWhiteSpace(text9)) 
                                                                {
                                                                      string text10 = Q10Field.text;
                                                                      if(!string.IsNullOrWhiteSpace(text10)) 
                                                                      {
                                                                              string text11 = Q11Field.text;
                                                                              if(!string.IsNullOrWhiteSpace(text11)) 
                                                                              {
                                                                                    string text12 = Q12Field.text;
                                                                                   if(!string.IsNullOrWhiteSpace(text12))
                                                                                   {
                                                                                        SceneManager.LoadScene("Summary Report");
                                                                                   }else
                                                                                   {
                                                                                       errorText.text = errorMessage;
                                                                                   } 
                                                                              }
                                                                      }
                                                                }
                                                           }
                                                    }
                                                }
                                         }
                                     }
                                 }
                            } 
                         } 
                      }                
                    }
              }
          }

     }
 
}







using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class NotepadScripts : MonoBehaviour
{
    public TMP_InputField notes;
    public string n;

    void Start()
    {
     n = PlayerPrefs.GetString("nKeyName");
     notes.text = n;
    }

    public void SaveNotes()
    {
        n = notes.text;
        PlayerPrefs.SetString("nKeyName", n);
    }

    public void goHome()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ResetNotes()
    {
        notes.text = " ";
    }
}

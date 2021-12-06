using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public void gotoLMMS()
    {
        SceneManager.LoadScene("LMMS");
    }

    public void gotoSumRep()
    {
        SceneManager.LoadScene("Summary Report");
    }

    public void gotoUG()
    {
        SceneManager.LoadScene("Users Guide");
    }

    public void gotoNotes()
    {
        SceneManager.LoadScene("Notes");
    }

    public void gotoMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

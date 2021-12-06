using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackHome : MonoBehaviour
{
    public void goToMainMen()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    public void GoToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("mainmenu");
    }
    public void GoToRollCharacterMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("rollcharacter");

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

}

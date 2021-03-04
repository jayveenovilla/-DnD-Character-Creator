using UnityEngine;

//scene managager
public class SceneManagerScript : MonoBehaviour
{
    //go to main menu scene
    public void GoToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("mainmenu");
    }
    
    //go to rollcharacter scene
    public void GoToRollCharacterMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("rollcharacter");

    }

    //go to playgame scene
    public void GoToPlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("playgame");

    }

    //quit game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

}

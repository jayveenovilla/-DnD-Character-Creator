//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    //public Text ValueTxt;

    private void Start()
    {
        //ValueTxt.text = GameManagerSingleton.Instance.Value.ToString();
    }

    public void GoToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("mainmenu");
        //GameManagerSingleton.Instance.Value++;
    }
    public void GoToRollCharacterMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("rollcharacter");
        //GameManagerSingleton.Instance.Value++;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}

using UnityEngine;
using UnityEngine.UI;

public class MainMenuEnablePlay : MonoBehaviour
{
    public Button PlayButton;

    // enable play game button once character is created
    void Update()
    {
        if (GameManagerSingleton.Instance.playerCreated == true)
        {
            PlayButton.interactable = true;
        }
        else
        {
            PlayButton.interactable = false;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

//enables play game button once player creation is complete
public class MainMenuEnablePlay : MonoBehaviour
{
    public Button PlayButton;

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

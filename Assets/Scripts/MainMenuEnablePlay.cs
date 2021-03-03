using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuEnablePlay : MonoBehaviour
{
    public Button PlayButton;
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
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

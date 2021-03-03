using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlignmentDropDownHandler : MonoBehaviour
{
    public Dropdown ddAlignment;
    public string alignment;
    // Start is called before the first frame update
    private void Start()
    {
        ddAlignment.onValueChanged.AddListener(delegate
        {
            ddAlignmentValueChanged(ddAlignment);
        });

    }

    public void ddAlignmentValueChanged(Dropdown sender)
    {
        Debug.Log("You have selected :" + sender.value);
        switch (sender.value)
        {
            case 0:
                alignment = "Chaotic Good";
                break;

            case 1:
                alignment = "Neutral Good";
                break;

            case 2:
                alignment = "Lawful Good";
                break;

            case 3:
                alignment = "Chaotic Neutral";
                break;

            case 4:
                alignment = "True Neutral";
                break;

            case 5:
                alignment = "Lawful Neutral";
                break;

            case 6:
                alignment = "Chaotic Evil";
                break;

            case 7:
                alignment = "Neutral Evil";
                break;

            case 8:
                alignment = "Lawful Evil";
                break;
        }
        GameManagerSingleton.Instance.player.alignment = alignment;
    }
}

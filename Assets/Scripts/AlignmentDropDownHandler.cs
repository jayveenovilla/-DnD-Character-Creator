using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//dropdown selection for the alignment of the player
public class AlignmentDropDownHandler : MonoBehaviour
{
    public Dropdown ddAlignment;
    public Text Textfield;
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
        Textfield.text = "";
        switch (sender.value)
        {
            case 0:
                alignment = "Chaotic Good";
                Textfield.text = "Chaotic good creatures act as their conscience directs, with little regard for what others expect.";
                break;

            case 1:
                alignment = "Neutral Good";
                Textfield.text = "Neutral good folk do the best they can to help others according to their needs. ";
                break;

            case 2:
                alignment = "Lawful Good";
                Textfield.text = "Lawful good creatures can be counted on to do the right thing as expected by society.";
                break;

            case 3:
                alignment = "Chaotic Neutral";
                Textfield.text = "Chaotic neutral creatures follow their whims, holding their personal freedom above all else.";
                break;

            case 4:
                alignment = "True Neutral";
                Textfield.text = "True Neutral is the alignment of those who prefer to steer clear of moral questions and don't take sides, doing what seems best at the time.";
                break;

            case 5:
                alignment = "Lawful Neutral";
                Textfield.text = "Lawful Neutral individuals act in accordance with law, tradition, or personal codes.";
                break;

            case 6:
                alignment = "Chaotic Evil";
                Textfield.text = "Chaotic evil creatures act with arbitrary violence, spurred by their greed, hatred, or bloodlust.";
                break;

            case 7:
                alignment = "Neutral Evil";
                Textfield.text = "Neutral evil is the alignment of those who do whatever they can get away with, without compassion or qualms.";
                break;

            case 8:
                alignment = "Lawful Evil";
                Textfield.text = "Lawful evil creatures methodically take what they want, within the limits of acode of tradition, loyalty, or order.";
                break;
        }
        Debug.Log("You have selected :" + sender.value + " " + alignment);
        GameManagerSingleton.Instance.player.alignment = alignment;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceDropDownHandler : MonoBehaviour
{
    public Dropdown ddRace;
    public string race;
    public float speedWalking;
    // Start is called before the first frame update
    private void Start()
    {
        ddRace.onValueChanged.AddListener(delegate
        {
            ddRaceValueChanged(ddRace);
        });
        
    }

    public void ddRaceValueChanged(Dropdown sender)
    {
        Debug.Log("You have selected :" + sender.value);
        switch (sender.value)
        {
            case 0: 
                race = "Dragonborn";
                speedWalking = 30;
                break;

            case 1: 
                race = "Dwarf";
                speedWalking = 25;
                break;

            case 2:
                race = "Elf";
                speedWalking = 30;
                break;

            case 3:
                race = "Gnome";
                speedWalking = 25;
                break;

            case 4:
                race = "Half-Elf";
                speedWalking = 30;
                break;

            case 5:
                race = "Half-Orc";
                speedWalking = 30;
                break;

            case 6:
                race = "Halfling";
                speedWalking = 25;
                break;

            case 7:
                race = "Human";
                speedWalking = 30;
                break;

            case 8:
                race = "Tiefling";
                speedWalking = 30;
                break;
        }
        GameManagerSingleton.Instance.race = race;
        GameManagerSingleton.Instance.speedWalking = speedWalking;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;
using UnityEngine.UI;

//dropdown selection for the race of the player. speed also determined through chosen race
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
        Debug.Log("You have selected :" + sender.value + " " + race);
        GameManagerSingleton.Instance.player.race = race;
        GameManagerSingleton.Instance.player.speedWalking = speedWalking;
    }
}

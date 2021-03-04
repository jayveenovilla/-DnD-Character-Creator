using UnityEngine;
using UnityEngine.UI;

//dropdown selection for the race of the player. speed also determined through chosen race
public class RaceDropDownHandler : MonoBehaviour
{
    public Dropdown ddRace;
    public Text Textfield;
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
        Textfield.text = "";
        switch (sender.value)
        {
            case 0: 
                race = "Dragonborn";
                speedWalking = 30;
                Textfield.text = race + ": " + "Your draconic heritage manifests in a variety of traits you share with other dragonborn.";
                break;

            case 1: 
                race = "Dwarf";
                speedWalking = 25;
                Textfield.text = race + ": " + "Your dwarf character has an assortment of in abilities, part and parcel of dwarven nature.";
                break;

            case 2:
                race = "Elf";
                speedWalking = 30;
                Textfield.text = race + ": " + "Your elf character has a variety of natural abilities, the result of thousands of years of elven refinement.";
                break;

            case 3:
                race = "Gnome";
                speedWalking = 25;
                Textfield.text = race + ": " + "Your gnome character has certain characteristics in common with all other gnomes.";
                break;

            case 4:
                race = "Half-Elf";
                speedWalking = 30;
                Textfield.text = race + ": " + "Your half-elf character has some qualities in common with elves and some that are unique to half-elves";
                break;

            case 5:
                race = "Half-Orc";
                speedWalking = 30;
                Textfield.text = race + ": " + "Your half-orc character has certain traits deriving from your orc ancestry.";
                break;

            case 6:
                race = "Halfling";
                speedWalking = 25;
                Textfield.text = race + ": " + "Your halfling character has a number of traits in common with all other halflings.";
                break;

            case 7:
                race = "Human";
                speedWalking = 30;
                Textfield.text = race + ": " + "It's hard to make generalizations about humans, but your human character has these traits.";
                break;

            case 8:
                race = "Tiefling";
                speedWalking = 30;
                Textfield.text = race + ": " + "Tieflings share certain racial traits as a result of their infernal descent.";
                break;
        }
        Debug.Log("You have selected :" + sender.value + " " + race);
        GameManagerSingleton.Instance.player.race = race;
        GameManagerSingleton.Instance.player.speedWalking = speedWalking;
    }
}

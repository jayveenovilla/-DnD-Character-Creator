using UnityEngine;
using UnityEngine.UI;


//dropdown selection for the class of the player. hitDice determined by class and is used for Health formula
public class ClassDropDownHandler : MonoBehaviour
{
    public Dropdown ddClass;
    public Text Textfield;
    public string playerClass;
    public int hitDice;
    // Start is called before the first frame update
    private void Start()
    {
        ddClass.onValueChanged.AddListener(delegate
        {
            ddClassValueChanged(ddClass);
        });

    }

    public void ddClassValueChanged(Dropdown sender)
    {
        Textfield.text = "";
        switch (sender.value)
        {
            case 0:
                playerClass = "Barbarian";
                hitDice = 12;
                Textfield.text = playerClass + ": " + "In battle, you fight with primal ferocity. For some barbarians, rage is a means to an end–that end being violence.";
                break;

            case 1:
                playerClass = "Bard";
                hitDice = 8;
                Textfield.text = playerClass + ": " + "Whether singing folk ballads in taverns or elaborate compositions in royal courts, bards use their gifts to hold audiences spellbound.";
                break;

            case 2:
                playerClass = "Cleric";
                hitDice = 8;
                Textfield.text = playerClass + ": " + "Clerics act as conduits of divine power.";
                break;

            case 3:
                playerClass = "Druid";
                hitDice = 8;
                Textfield.text = playerClass + ": " + "Druids venerate the forces of nature themselves. Druids holds certain plants and animals to be sacred, and most druids are devoted to one of the many nature deities.";
                break;

            case 4:
                playerClass = "Fighter";
                hitDice = 10;
                Textfield.text = playerClass + ": " + "Different fighters choose different approaches to perfecting their fighting prowess, but they all end up perfecting it.";
                break;

            case 5:
                playerClass = "Monk";
                hitDice = 8;
                Textfield.text = playerClass + ": " + "Coming from monasteries, monks are masters of martial arts combat and meditators with the ki living forces.";
                break;

            case 6:
                playerClass = "Paladin";
                hitDice = 10;
                Textfield.text = playerClass + ": " + "Paladins are the ideal of the knight in shining armor; they uphold ideals of justice, virtue, and order and use righteous might to meet their ends.";
                break;

            case 7:
                playerClass = "Ranger";
                hitDice = 10;
                Textfield.text = playerClass + ": " + "Acting as a bulwark between civilization and the terrors of the wilderness, rangers study, track, and hunt their favored enemies.";
                break;

            case 8:
                playerClass = "Rogue";
                hitDice = 8;
                Textfield.text = playerClass + ": " + "Rogues have many features in common, including their emphasis on perfecting their skills, their precise and deadly approach to combat, and their increasingly quick reflexes.";
                break;

            case 9:
                playerClass = "Sorcerer";
                hitDice = 6;
                Textfield.text = playerClass + ": " + "An event in your past, or in the life of a parent or ancestor, left an indelible mark on you, infusing you with arcane magic. As a sorcerer the power of your magic relies on your ability to project your will into the world.";
                break;

            case 10:
                playerClass = "Warlock";
                hitDice = 8;
                Textfield.text = playerClass + ": " + "You struck a bargain with an otherworldly being of your choice: the Archfey, the Fiend, or the Great Old One who has imbued you with mystical powers, granted you knowledge of occult lore, bestowed arcane research and magic on you and thus has given you facility with spells.";
                break;

            case 11:
                playerClass = "Wizard";
                hitDice = 6;
                Textfield.text = playerClass + ": " + "The study of wizardry is ancient, stretching back to the earliest mortal discoveries of magic. As a student of arcane magic, you have a spellbook containing spells that show glimmerings of your true power which is a catalyst for your mastery over certain spells.";
                break;
        }
        Debug.Log("You have selected :" + sender.value + " " + playerClass);
        GameManagerSingleton.Instance.player.playerClass = playerClass;
        GameManagerSingleton.Instance.player.hitDice = hitDice;
    }
}

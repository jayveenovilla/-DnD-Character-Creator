using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClassDropDownHandler : MonoBehaviour
{
    public Dropdown ddClass;
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
        Debug.Log("You have selected :" + sender.value);
        switch (sender.value)
        {
            case 0:
                playerClass = "Barbarian";
                hitDice = 12;
                break;

            case 1:
                playerClass = "Bard";
                hitDice = 8;
                break;

            case 2:
                playerClass = "Cleric";
                hitDice = 8;
                break;

            case 3:
                playerClass = "Druid";
                hitDice = 8;
                break;

            case 4:
                playerClass = "Fighter";
                hitDice = 10;
                break;

            case 5:
                playerClass = "Monk";
                hitDice = 8;
                break;

            case 6:
                playerClass = "Paladin";
                hitDice = 10;
                break;

            case 7:
                playerClass = "Ranger";
                hitDice = 10;
                break;

            case 8:
                playerClass = "Rogue";
                hitDice = 8;
                break;

            case 9:
                playerClass = "Sorcerer";
                hitDice = 6;
                break;

            case 10:
                playerClass = "Warlock";
                hitDice = 8;
                break;

            case 11:
                playerClass = "Wizard";
                hitDice = 6;
                break;
        }
        GameManagerSingleton.Instance.player.playerClass = playerClass;
        GameManagerSingleton.Instance.player.hitDice = hitDice;
    }
}

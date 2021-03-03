using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClassDropDownHandler : MonoBehaviour
{
    public Dropdown ddClass;
    public string playerClass;
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
                break;

            case 1:
                playerClass = "Bard";
                break;

            case 2:
                playerClass = "Cleric";
                break;

            case 3:
                playerClass = "Druid";
                break;

            case 4:
                playerClass = "Fighter";
                break;

            case 5:
                playerClass = "Monk";
                break;

            case 6:
                playerClass = "Paladin";
                break;

            case 7:
                playerClass = "Ranger";
                break;

            case 8:
                playerClass = "Rogue";
                break;

            case 9:
                playerClass = "Sorcerer";
                break;

            case 10:
                playerClass = "Warlock";
                break;

            case 11:
                playerClass = "Wizard";
                break;
        }
        GameManagerSingleton.Instance.playerClass = playerClass;
    }
}

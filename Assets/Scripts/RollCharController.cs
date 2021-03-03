using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class RollCharController : MonoBehaviour
{
    //GameObjects
    //protected Button RollStrength_Button;
    //public InputField userNameInput;
    //public static string username;
    //public Dropdown dropdownRace;

    public Text Textfield;
    /*
    public string characterName;
    public string race;
    public string playerClass;
    public string alignment;
    public int Ability_Strength;
    public int Ability_Dexterity;
    public int Ability_Constitution;
    public int Ability_Intelligence;
    public int Ability_Wisdom;
    public int Ability_Charisma;
    public int defaultModifier = 2;
    public int currentXP;
    public int maxXP;
    public int currentHP;
    public int maxHP ;
    public int armorClass;
    public float speedWalking;
    public float speedRunning;
    public float speedHeight;
    public List<string> ItemList;*/
    public bool playerCreated = false;

    //Roll abilities 7d4. save to gamemanager. display ui text
    public void RollStrength(string text)
    {
        GameManagerSingleton.Instance.Ability_Strength = Roll7d4() + GameManagerSingleton.Instance.defaultModifier;
        Textfield.text = GameManagerSingleton.Instance.Ability_Strength.ToString();
        //Debug.Log("str: " + Ability_Strength);
        //GameManagerSingleton.Instance.Ability_Strength = Ability_Strength;
    }

    public void RollDexterity(string text)
    {
        GameManagerSingleton.Instance.Ability_Dexterity = Roll7d4() + GameManagerSingleton.Instance.defaultModifier;
        Textfield.text = GameManagerSingleton.Instance.Ability_Dexterity.ToString();  
        //GameManagerSingleton.Instance.Ability_Dexterity = Ability_Dexterity;

    }
    public void RollConstitution(string text)
    {
        GameManagerSingleton.Instance.Ability_Constitution = Roll7d4() + GameManagerSingleton.Instance.defaultModifier;
        Textfield.text = GameManagerSingleton.Instance.Ability_Constitution.ToString();
        //GameManagerSingleton.Instance.Ability_Constitution = Ability_Constitution;
    }
    public void RollIntelligence(string text)
    {
        GameManagerSingleton.Instance.Ability_Intelligence = Roll7d4() + GameManagerSingleton.Instance.defaultModifier;
        Textfield.text = GameManagerSingleton.Instance.Ability_Intelligence.ToString();
        //GameManagerSingleton.Instance.Ability_Intelligence = Ability_Intelligence;
    }
    public void RollWisdom(string text)
    {
        GameManagerSingleton.Instance.Ability_Wisdom = Roll7d4() + GameManagerSingleton.Instance.defaultModifier;
        Textfield.text = GameManagerSingleton.Instance.Ability_Wisdom.ToString();
        //GameManagerSingleton.Instance.Ability_Wisdom = Ability_Wisdom;
    }
    public void RollCharisma(string text)
    {
        GameManagerSingleton.Instance.Ability_Charisma = Roll7d4() + GameManagerSingleton.Instance.defaultModifier;
        Textfield.text = GameManagerSingleton.Instance.Ability_Charisma.ToString();
        //GameManagerSingleton.Instance.Ability_Charisma = Ability_Charisma;
    }

    public void SetArmorClass(string newArmorClass)
    {
        GameManagerSingleton.Instance.armorClass = int.Parse(newArmorClass);
        //GameManagerSingleton.Instance.armorClass = armorClass;
    }

    public int Roll7d4()
    {
        int outVal;
        List<int> d7List = new List<int>();

        for ( int i=1; i<=7; i++)
        {
            d7List.Add(UnityEngine.Random.Range(1, 5));
        }
        d7List.Sort();
        d7List.Reverse();
        outVal = d7List[0] + d7List[1] + d7List[2];
        //Debug.Log(d7List[0]);
        //Debug.Log(d7List[1]);
        //Debug.Log(d7List[2]);
        return outVal;
    }

    //character name
    public void SaveCharName( string newName)
    {
        GameManagerSingleton.Instance.characterName = newName;
        //GameManagerSingleton.Instance.characterName = characterName;
        //Debug.Log(characterName);
    }

    //save rolled character to gamemanager variables
    public void makeCharacter()
    {
        if ((GameManagerSingleton.Instance.characterName != null) && (GameManagerSingleton.Instance.armorClass != 0) && (GameManagerSingleton.Instance.Ability_Strength != 0) && (GameManagerSingleton.Instance.Ability_Dexterity != 0) && (GameManagerSingleton.Instance.Ability_Constitution != 0) && (GameManagerSingleton.Instance.Ability_Intelligence != 0) && (GameManagerSingleton.Instance.Ability_Wisdom != 0) && (GameManagerSingleton.Instance.Ability_Charisma != 0))
        {
            GameManagerSingleton.Instance.currentXP = 0;
            GameManagerSingleton.Instance.maxXP = int.MaxValue; 
            GameManagerSingleton.Instance.currentHP = GameManagerSingleton.Instance.hitDice + GameManagerSingleton.Instance.defaultModifier;
            GameManagerSingleton.Instance.maxHP = GameManagerSingleton.Instance.hitDice + GameManagerSingleton.Instance.defaultModifier;
            GameManagerSingleton.Instance.speedJumpHeight = (3 + GameManagerSingleton.Instance.defaultModifier) / 2;
            GameManagerSingleton.Instance.speedRunning = GameManagerSingleton.Instance.speedWalking * 2;
            GameManagerSingleton.Instance.playerCreated = true;
            Debug.Log("Player Created!");
}
    }

    // Start is called before the first frame update
    public void Start()
    {
        //reset character defaults upon start
        GameManagerSingleton.Instance.characterName = "";
        GameManagerSingleton.Instance.race = "Dragonborn";
        GameManagerSingleton.Instance.playerClass = "Barbarian";
        GameManagerSingleton.Instance.alignment = "Chaotic Good";
        GameManagerSingleton.Instance.Ability_Strength = 0;
        GameManagerSingleton.Instance.Ability_Dexterity = 0;
        GameManagerSingleton.Instance.Ability_Constitution = 0;
        GameManagerSingleton.Instance.Ability_Intelligence = 0;
        GameManagerSingleton.Instance.Ability_Wisdom = 0;
        GameManagerSingleton.Instance.Ability_Charisma = 0;
        GameManagerSingleton.Instance.defaultModifier = 2;
        GameManagerSingleton.Instance.currentXP = 0;
        GameManagerSingleton.Instance.maxXP = 0;
        GameManagerSingleton.Instance.currentHP = 0;
        GameManagerSingleton.Instance.maxHP = 0;
        GameManagerSingleton.Instance.armorClass = 0;
        GameManagerSingleton.Instance.speedWalking = 30;
        GameManagerSingleton.Instance.speedRunning = GameManagerSingleton.Instance.speedWalking * 2;
        GameManagerSingleton.Instance.playerCreated = false;
        GameManagerSingleton.Instance.hitDice = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

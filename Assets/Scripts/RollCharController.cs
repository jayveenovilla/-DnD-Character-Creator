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
    /*public float speedWalking;
    public float speedRunning;
    public float speedHeight;
    public List<string> ItemList;*/
    public bool playerCreated = false;

    //Roll abilities 7d4. save to gamemanager. display ui text
    public void RollStrength(string text)
    {
        Ability_Strength = Roll7d4() + defaultModifier;
        Textfield.text = Ability_Strength.ToString();
        //Debug.Log("str: " + Ability_Strength);
        GameManagerSingleton.Instance.Ability_Strength = Ability_Strength;
    }

    public void RollDexterity(string text)
    {
        Ability_Dexterity = Roll7d4() + defaultModifier;
        Textfield.text = Ability_Dexterity.ToString();  
        GameManagerSingleton.Instance.Ability_Dexterity = Ability_Dexterity;

    }
    public void RollConstitution(string text)
    {
        Ability_Constitution = Roll7d4() + defaultModifier;
        Textfield.text = Ability_Constitution.ToString();
        GameManagerSingleton.Instance.Ability_Constitution = Ability_Constitution;
    }
    public void RollIntelligence(string text)
    {
        Ability_Intelligence = Roll7d4() + defaultModifier;
        Textfield.text = Ability_Intelligence.ToString();
        GameManagerSingleton.Instance.Ability_Intelligence = Ability_Intelligence;
    }
    public void RollWisdom(string text)
    {
        Ability_Wisdom = Roll7d4() + defaultModifier;
        Textfield.text = Ability_Wisdom.ToString();
        GameManagerSingleton.Instance.Ability_Wisdom = Ability_Wisdom;
    }
    public void RollCharisma(string text)
    {
        Ability_Charisma = Roll7d4() + defaultModifier;
        Textfield.text = Ability_Charisma.ToString();
        GameManagerSingleton.Instance.Ability_Charisma = Ability_Charisma;
    }

    public void SetArmorClass(string newArmorClass)
    {
        armorClass = int.Parse(newArmorClass);
        GameManagerSingleton.Instance.armorClass = armorClass;
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
        this.characterName = newName;
        GameManagerSingleton.Instance.characterName = characterName;
        //Debug.Log(characterName);
    }

    //save rolled character to gamemanager variables
    public void makeCharacter()
    {
        if ((GameManagerSingleton.Instance.characterName != null) && (GameManagerSingleton.Instance.armorClass != 0) && (GameManagerSingleton.Instance.Ability_Strength != 0) && (GameManagerSingleton.Instance.Ability_Dexterity != 0) && (GameManagerSingleton.Instance.Ability_Constitution != 0) && (GameManagerSingleton.Instance.Ability_Intelligence != 0) && (GameManagerSingleton.Instance.Ability_Wisdom != 0) && (GameManagerSingleton.Instance.Ability_Charisma != 0))
        {

            /*
            GameManagerSingleton.Instance.characterName = this.characterName;
            GameManagerSingleton.Instance.Ability_Strength = this.Ability_Strength;
            GameManagerSingleton.Instance.Ability_Constitution = this.Ability_Constitution;
            GameManagerSingleton.Instance.Ability_Dexterity = this.Ability_Dexterity;
            GameManagerSingleton.Instance.Ability_Intelligence = this.Ability_Intelligence;
            GameManagerSingleton.Instance.Ability_Wisdom = this.Ability_Wisdom;
            GameManagerSingleton.Instance.Ability_Charisma = this.Ability_Charisma;
            */
            GameManagerSingleton.Instance.currentXP = 0;
            GameManagerSingleton.Instance.maxXP = int.MaxValue;
            GameManagerSingleton.Instance.speedJumpHeight = (3 + defaultModifier) / 2;
            GameManagerSingleton.Instance.playerCreated = true;
            Debug.Log("Player Created!");
}
    }

    // Start is called before the first frame update
    public void Start()
    {
        //set dropdown defaults
        GameManagerSingleton.Instance.race = "Dragonborn";
        GameManagerSingleton.Instance.playerClass = "Barbarian";
        GameManagerSingleton.Instance.alignment = "Chaotic Good";
        GameManagerSingleton.Instance.speedWalking = 30;
        GameManagerSingleton.Instance.speedRunning = 30;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Roll character menu. choose character name. roll for abilities. saves to player manager singleton and outputs as JSON to a selectable input textfield
[System.Serializable]
public class RollCharController : MonoBehaviour
{
    public Text Textfield;
    public InputField TextInputField;
    public AudioSource audioData1;
    public AudioSource audioData2;
    public AudioSource audioData3;

    //Roll abilities 7d4. save to player class. display ui text. plays an audio dice roll
    public void RollStrength(string text)
    {
        GameManagerSingleton.Instance.player.Ability_Strength = Roll7d4() + GameManagerSingleton.Instance.player.defaultModifier;
        Textfield.text = GameManagerSingleton.Instance.player.Ability_Strength.ToString();
        audioData3.Play(0);
    }

    public void RollDexterity(string text)
    {
        GameManagerSingleton.Instance.player.Ability_Dexterity = Roll7d4() + GameManagerSingleton.Instance.player.defaultModifier;
        Textfield.text = GameManagerSingleton.Instance.player.Ability_Dexterity.ToString();
        audioData3.Play(0);
    }
    public void RollConstitution(string text)
    {
        GameManagerSingleton.Instance.player.Ability_Constitution = Roll7d4() + GameManagerSingleton.Instance.player.defaultModifier;
        Textfield.text = GameManagerSingleton.Instance.player.Ability_Constitution.ToString();
        audioData3.Play(0);
    }
    public void RollIntelligence(string text)
    {
        GameManagerSingleton.Instance.player.Ability_Intelligence = Roll7d4() + GameManagerSingleton.Instance.player.defaultModifier;
        Textfield.text = GameManagerSingleton.Instance.player.Ability_Intelligence.ToString();
        audioData3.Play(0);
    }
    public void RollWisdom(string text)
    {
        GameManagerSingleton.Instance.player.Ability_Wisdom = Roll7d4() + GameManagerSingleton.Instance.player.defaultModifier;
        Textfield.text = GameManagerSingleton.Instance.player.Ability_Wisdom.ToString();
        audioData3.Play(0);
    }
    public void RollCharisma(string text)
    {
        GameManagerSingleton.Instance.player.Ability_Charisma = Roll7d4() + GameManagerSingleton.Instance.player.defaultModifier;
        Textfield.text = GameManagerSingleton.Instance.player.Ability_Charisma.ToString();
        audioData3.Play(0);
    }

    //set armor class as user input of RedID, 2 digits
    public void SetArmorClass(string newArmorClass)
    {
        uint parsedId;
        if ((string.IsNullOrEmpty(newArmorClass) || (!uint.TryParse(newArmorClass, out parsedId))))
        {
            TextInputField.text = "00";
            GameManagerSingleton.Instance.player.armorClass = 0;
        }
        else
        {
            GameManagerSingleton.Instance.player.armorClass = int.Parse(newArmorClass);
        }
    }

    //roll 7 dice, 4 sided. sort and reverse. use sum of top 3 as output for player abilities
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
        return outVal;
    }

    //character name
    public void SaveCharName( string newName)
    {
        GameManagerSingleton.Instance.player.characterName = newName;
    }

    //save rolled character to player class variables
    public void makeCharacter()
    {
        if ((!string.IsNullOrEmpty(GameManagerSingleton.Instance.player.characterName)) && (GameManagerSingleton.Instance.player.Ability_Strength != 0) && (GameManagerSingleton.Instance.player.Ability_Dexterity != 0) && (GameManagerSingleton.Instance.player.Ability_Constitution != 0) && (GameManagerSingleton.Instance.player.Ability_Intelligence != 0) && (GameManagerSingleton.Instance.player.Ability_Wisdom != 0) && (GameManagerSingleton.Instance.player.Ability_Charisma != 0))
        {
            GameManagerSingleton.Instance.player.currentXP = 0;
            GameManagerSingleton.Instance.player.maxXP = int.MaxValue;
            GameManagerSingleton.Instance.player.currentHP = GameManagerSingleton.Instance.player.hitDice + GameManagerSingleton.Instance.player.defaultModifier;
            GameManagerSingleton.Instance.player.maxHP = GameManagerSingleton.Instance.player.hitDice + GameManagerSingleton.Instance.player.defaultModifier;
            GameManagerSingleton.Instance.player.speedJumpHeight = (float)((3.0 + GameManagerSingleton.Instance.player.defaultModifier) / 2.0);
            GameManagerSingleton.Instance.player.speedRunning = GameManagerSingleton.Instance.player.speedWalking * 2;
            GameManagerSingleton.Instance.playerCreated = true;
            WritePlayerJson();
            audioData1.Play(0);

            //debug
            Debug.Log("Player Created!");
            Debug.Log("Name:" + GameManagerSingleton.Instance.player.characterName);
            Debug.Log("Race:" + GameManagerSingleton.Instance.player.race);
            Debug.Log("Class:" + GameManagerSingleton.Instance.player.playerClass);
            Debug.Log("Alignment:" + GameManagerSingleton.Instance.player.alignment);
            Debug.Log("Str:" + GameManagerSingleton.Instance.player.Ability_Strength);
            Debug.Log("Dex:" + GameManagerSingleton.Instance.player.Ability_Dexterity);
            Debug.Log("Con:" + GameManagerSingleton.Instance.player.Ability_Constitution);
            Debug.Log("Int:" + GameManagerSingleton.Instance.player.Ability_Intelligence);
            Debug.Log("Wis:" + GameManagerSingleton.Instance.player.Ability_Wisdom);
            Debug.Log("Cha:" + GameManagerSingleton.Instance.player.Ability_Charisma);
            Debug.Log("HP:" + GameManagerSingleton.Instance.player.currentHP);
            Debug.Log("Armor:" + GameManagerSingleton.Instance.player.armorClass);
            Debug.Log("SpeedWalking:" + GameManagerSingleton.Instance.player.speedWalking);
            Debug.Log("SpeedRunning:" + GameManagerSingleton.Instance.player.speedRunning);
            Debug.Log("SpeedJumpHeight:" + GameManagerSingleton.Instance.player.speedJumpHeight);
            Debug.Log("Hit Dice:" + GameManagerSingleton.Instance.player.hitDice);
        }

        //play error if character creation is incomplete and display needed variables
        if ((string.IsNullOrEmpty(GameManagerSingleton.Instance.player.characterName)) || (GameManagerSingleton.Instance.player.Ability_Strength == 0) || (GameManagerSingleton.Instance.player.Ability_Dexterity == 0) || (GameManagerSingleton.Instance.player.Ability_Constitution == 0) || (GameManagerSingleton.Instance.player.Ability_Intelligence == 0) || (GameManagerSingleton.Instance.player.Ability_Wisdom == 0) || (GameManagerSingleton.Instance.player.Ability_Charisma == 0))
        {
            audioData2.Play(0);
            TextInputField.text = "Character Incomplete:";

            if (string.IsNullOrEmpty(GameManagerSingleton.Instance.player.characterName))
            {
                TextInputField.text = TextInputField.text + "\n" + "     " + "Create a Name";
            }

            if (GameManagerSingleton.Instance.player.Ability_Strength == 0)
            {
                TextInputField.text = TextInputField.text + "\n" + "     " + "Roll for Strength";
            }

            if (GameManagerSingleton.Instance.player.Ability_Dexterity == 0)
            {
                TextInputField.text = TextInputField.text + "\n" + "     " + "Roll for Dexterity";
            }

            if (GameManagerSingleton.Instance.player.Ability_Constitution == 0)
            {
                TextInputField.text = TextInputField.text + "\n" + "     " + "Roll for Constitution";
            }

            if (GameManagerSingleton.Instance.player.Ability_Intelligence == 0)
            {
                TextInputField.text = TextInputField.text + "\n" + "     " + "Roll for Intelligence";
            }

            if (GameManagerSingleton.Instance.player.Ability_Wisdom == 0)
            {
                TextInputField.text = TextInputField.text + "\n" + "     " + "Roll for Wisdom";
            }

            if (GameManagerSingleton.Instance.player.Ability_Charisma == 0)
            {
                TextInputField.text = TextInputField.text + "\n" + "     " + "Roll for Charisma";
            }
        }
    }

    //create JSON of player variables. output to selectable input textfield for further external JSON validation
    public void WritePlayerJson()
    {
        string _player = JsonUtility.ToJson(GameManagerSingleton.Instance.player,true);
        TextInputField.text = _player;
        //write player JSON to persistentDataPath
        //System.IO.File.WriteAllText(Application.persistentDataPath + "/PlayerData.json", _player);
        //Debug.Log("Persistent Data Path: " + Application.persistentDataPath);
    }

    // Start is called before the first frame update
    public void Start()
    {
        //reset character defaults upon start of rollcharacter menu
        GameManagerSingleton.Instance.player.characterName = "";
        GameManagerSingleton.Instance.player.race = "Dragonborn";
        GameManagerSingleton.Instance.player.playerClass = "Barbarian";
        GameManagerSingleton.Instance.player.alignment = "Chaotic Good";
        GameManagerSingleton.Instance.player.Ability_Strength = 0;
        GameManagerSingleton.Instance.player.Ability_Dexterity = 0;
        GameManagerSingleton.Instance.player.Ability_Constitution = 0;
        GameManagerSingleton.Instance.player.Ability_Intelligence = 0;
        GameManagerSingleton.Instance.player.Ability_Wisdom = 0;
        GameManagerSingleton.Instance.player.Ability_Charisma = 0;
        GameManagerSingleton.Instance.player.defaultModifier = 2;
        GameManagerSingleton.Instance.player.currentXP = 0;
        GameManagerSingleton.Instance.player.maxXP = 0;
        GameManagerSingleton.Instance.player.currentHP = 0;
        GameManagerSingleton.Instance.player.maxHP = 0;
        GameManagerSingleton.Instance.player.armorClass = 00;
        GameManagerSingleton.Instance.player.speedWalking = 30;
        GameManagerSingleton.Instance.player.speedRunning = GameManagerSingleton.Instance.player.speedWalking * 2;
        GameManagerSingleton.Instance.playerCreated = false;
        GameManagerSingleton.Instance.player.hitDice = 12;

        //debug on start rollchar menu
        /*
        Debug.Log("Player Reset!");
        Debug.Log("Name:" + GameManagerSingleton.Instance.player.characterName);
        Debug.Log("Race:" + GameManagerSingleton.Instance.player.race);
        Debug.Log("Class:" + GameManagerSingleton.Instance.player.playerClass);
        Debug.Log("Alignment:" + GameManagerSingleton.Instance.player.alignment);
        Debug.Log("Str:" + GameManagerSingleton.Instance.player.Ability_Strength);
        Debug.Log("Dex:" + GameManagerSingleton.Instance.player.Ability_Dexterity);
        Debug.Log("Con:" + GameManagerSingleton.Instance.player.Ability_Constitution);
        Debug.Log("Int:" + GameManagerSingleton.Instance.player.Ability_Intelligence);
        Debug.Log("Wis:" + GameManagerSingleton.Instance.player.Ability_Wisdom);
        Debug.Log("Cha:" + GameManagerSingleton.Instance.player.Ability_Charisma);
        Debug.Log("HP:" + GameManagerSingleton.Instance.player.currentHP);
        Debug.Log("Armor:" + GameManagerSingleton.Instance.player.armorClass);
        Debug.Log("Speed:" + GameManagerSingleton.Instance.player.speedWalking);
        Debug.Log("SpeedRunning:" + GameManagerSingleton.Instance.player.speedRunning);
        Debug.Log("SpeedJumpHeight:" + GameManagerSingleton.Instance.player.speedJumpHeight);
        */
    }
}

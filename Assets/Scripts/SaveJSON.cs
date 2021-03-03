using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveJSON : MonoBehaviour
{
    /*
    [SerializeField] private PlayerData _PlayerData = new PlayerData();

    public string characterName = GameManagerSingleton.Instance.characterName;
    public string race = GameManagerSingleton.Instance.race;
    public string playerClass = GameManagerSingleton.Instance.playerClass;
    public string alignment = GameManagerSingleton.Instance.alignment;
    public void SaveIntoJson()
    {
        string characterName = JsonUtility.ToJson(_PlayerData);
        string race = JsonUtility.ToJson(_PlayerData);
        string playerClass = JsonUtility.ToJson(_PlayerData);
        string alignment = JsonUtility.ToJson(_PlayerData);
        int Ability_Strength = JsonUtility.ToJson(_PlayerData);
        int Ability_Dexterity = JsonUtility.ToJson(_PlayerData);
        int Ability_Constitution = JsonUtility.ToJson(_PlayerData);
        int Ability_Intelligence = JsonUtility.ToJson(_PlayerData);
        int Ability_Wisdom = JsonUtility.ToJson(_PlayerData);
        int Ability_Charisma = JsonUtility.ToJson(_PlayerData);
        int currentXP = JsonUtility.ToJson(_PlayerData);
        int maxXP = JsonUtility.ToJson(_PlayerData);
        int currentHP = JsonUtility.ToJson(_PlayerData);
        int maxHP = JsonUtility.ToJson(_PlayerData);
        int armorClass = JsonUtility.ToJson(_PlayerData);
        float speedWalking = JsonUtility.ToJson(_PlayerData);
        float speedRunning = JsonUtility.ToJson(_PlayerData);
        float speedHeight = JsonUtility.ToJson(_PlayerData);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/PlayerData.json", GameManagerSingleton.Instance.characterName);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/PlayerData.json", GameManagerSingleton.Instance.race);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/PlayerData.json", GameManagerSingleton.Instance.playerClass);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/PlayerData.json", GameManagerSingleton.Instance.alignment);
        Debug.Log("JSON created");
        Debug.Log(Application.persistentDataPath);
    }*/
}

/*
[System.Serializable]
public class PlayerData
{
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
    public int currentXP;
    public int maxXP;
    public int currentHP;
    public int maxHP;
    public int armorClass;
    public float speedWalking;
    public float speedRunning;
    public float speedJumpHeight;
    public List<string> ItemList;

    public PlayerData(string characterName, string race, string playerClass, string alignment, string )
}*/


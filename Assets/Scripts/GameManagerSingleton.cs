//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerSingleton : MonoBehaviour
{
    public static GameManagerSingleton Instance { get; private set; }

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
    public int maxHP;
    public int armorClass;
    public float speedWalking;
    public float speedRunning;
    public float speedJumpHeight;
    public int hitDice;
    public List<string> ItemList;
    public bool playerCreated = false;
    public Button PlayButton;


    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else //if (Instance != this)
        {
            Destroy(gameObject);
        }
        Debug.Log("strength is:" + Instance.Ability_Strength);
        Debug.Log("dexterity is:" + Instance.Ability_Dexterity);
        Debug.Log("race is:" + Instance.race);
    }

    


    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}

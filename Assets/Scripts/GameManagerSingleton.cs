//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SerializeField]
public class GameManagerSingleton : MonoBehaviour
{
    public class Player
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
    }
    public static GameManagerSingleton Instance { get; private set; }

    public Player player;

    public bool playerCreated = false;
    public Button PlayButton;


    private void Awake()
    {
        
        if (Instance != null && Instance !=this)
        {
            Destroy(gameObject);
            

        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
            player = new Player();
            
        }
    }
}

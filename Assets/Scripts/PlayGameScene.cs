using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGameScene : MonoBehaviour
{
    public InputField jsonOutput;
    public void Start()
    {
        string _player = JsonUtility.ToJson(GameManagerSingleton.Instance.player, true);
        jsonOutput.text = _player;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EnterName : MonoBehaviour
{

    public void SetPlayerName(string playername)
    {
        GameManager.playerName = playername;
        StartGame();
    }

    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}

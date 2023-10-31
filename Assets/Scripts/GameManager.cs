using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Gameplay,
        Paused,
        GameOver
    }
    public GameState currentState;
    void Update()
    {
        switch (currentState)
        {
            case GameState.Gameplay:
                break;
            case GameState.Paused:
                break;
            case GameState.GameOver:
                break;
            default:
                Debug.Log("STATE DOES NOT EXIST");
                break;
        }
    }
    void TestSwitchState()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            currentState++;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            currentState--;
        }
    }
}

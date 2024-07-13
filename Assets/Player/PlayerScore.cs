using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;

    private void Start()
    {
        score = 0;
    }

    public void AddScore()
    {
        score++;
        UIManager.ins.UpdateScoreUI();
    }

    public void SubtractScore()
    {
        score -= 2;
        UIManager.ins.UpdateScoreUI();
    }

    public bool isWin()
    {
        if (score >= GamePlayManager.ins.scoreToWin)
        {
            return true;
        }
        return false;
    }
}

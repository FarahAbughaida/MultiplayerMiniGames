using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    public static GamePlayManager ins;

    [SerializeField]
    GameObject WinnerText;

    [SerializeField]
    GameObject EndPanel;

    [SerializeField]
    public int scoreToWin = 3;

    private void Awake()
    {
        if (ins == null)
        {
            ins = this;
        }
        EndPanel.SetActive(false);
        WinnerText.SetActive(false);
    }

    public void EndGame(Transform winnerPosition)
    {
        EndPanel.SetActive(true);
        WinnerText.transform.position = winnerPosition.position;
        WinnerText.SetActive(true);
    }
}

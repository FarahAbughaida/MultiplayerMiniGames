using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager ins;

    [SerializeField]
    List<TextMeshProUGUI> scorePlayers;

    [SerializeField]
    List<PlayerScore> playerScore;

    private void Awake()
    {
        if (ins == null)
        {
            ins = this;
        }
    }

    private void Start()
    {
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        int index = 0;
        foreach (PlayerScore scoreT in playerScore)
        {
            scorePlayers[index].text = scoreT.score.ToString();
            index++;
        }
    }
}

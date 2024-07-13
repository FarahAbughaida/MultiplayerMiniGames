using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerManager : MonoBehaviour
{
    public enum AvalibleKey
    {
        Space,
        KeypadEnter
    }

    [SerializeField]
    AvalibleKey avalibleKey;

    [SerializeField]
    PlayerAnimations playerAnimations;

    [SerializeField]
    Transform midPoint;

    [SerializeField]
    Transform initialPoint;

    [SerializeField]
    float timeBeforeReturnInitPoint;

    PlayerScore playerScore;

    private void Start()
    {
        playerScore = GetComponent<PlayerScore>();
    }

    private void Update()
    {
        switch (avalibleKey)
        {
            case AvalibleKey.Space:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    move();
                }
                break;
            case AvalibleKey.KeypadEnter:
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    move();
                }
                break;
        }
    }

    void move()
    {
        transform.position = midPoint.position;
        Invoke(nameof(ReturnToInit), timeBeforeReturnInitPoint);
    }

    void ReturnToInit()
    {
        transform.position = initialPoint.position;
    }

    public void CollectedFish()
    {
        Debug.Log("Player Name :" + transform.name);
        playerScore.AddScore();
        if (playerScore.isWin())
        {
            playerWin();
        }
    }

    public void CollectedTrapFish()
    {
        Debug.Log("Player Name T:" + transform.name);
        playerScore.SubtractScore();
    }

    void playerWin()
    {
        GamePlayManager.ins.EndGame(transform);
        playerAnimations.startHeadAnim();
    }

    /*    [SerializeField]
    [Range(0f, 5f)]
    float speed;*/

    /*IEnumerator MoveHand()
{
    float travelPercent = 0f;
    while (travelPercent < 1f)
    {
        travelPercent += Time.deltaTime * speed;
        transform.position = Vector3.Lerp(
            initialPoint.position,
            midPoint.position,
            travelPercent
        );
        yield return new WaitForEndOfFrame();
    }
}*/

    /*IEnumerator ReturnToInit()
    {
        float travelPercent = 0f;
        while (travelPercent < 1f)
        {
            yield return new WaitForEndOfFrame();
            travelPercent += Time.deltaTime * speed;
            transform.position = Vector3.Lerp(
                midPoint.position,
                initialPoint.position,
                travelPercent
            );
        }
    }*/
}

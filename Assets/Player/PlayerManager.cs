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
    Transform midPoint;

    [SerializeField]
    Transform initialPoint;

    [SerializeField]
    float timeBeforeReturnInitPoint;

    private void Update()
    {
        switch (avalibleKey)
        {
            case AvalibleKey.Space:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    //StartCoroutine(MoveHand());
                    //StartCoroutine(ReturnToInit());
                    transform.position = midPoint.position;
                    Invoke(nameof(ReturnToInit), timeBeforeReturnInitPoint);
                }
                break;
            case AvalibleKey.KeypadEnter:
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    //StartCoroutine(MoveHand());
                    //StartCoroutine(ReturnToInit());
                    transform.position = midPoint.position;
                    Invoke(nameof(ReturnToInit), timeBeforeReturnInitPoint);
                }
                break;
        }
    }

    void ReturnToInit()
    {
        transform.position = initialPoint.position;
    }

    public void CollectedFish()
    {
        Debug.Log("Player Name :" + transform.name);
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

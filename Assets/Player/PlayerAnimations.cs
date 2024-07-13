using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField]
    Animator HeadAnim;

    [SerializeField]
    float timeToStopAnim;

    private void Start()
    {
        HeadAnim.enabled = false;
    }

    public void startHeadAnim()
    {
        HeadAnim.enabled = true;
        Invoke(nameof(StopHeadAnim), timeToStopAnim);
    }

    void StopHeadAnim()
    {
        HeadAnim.enabled = false;
    }
}

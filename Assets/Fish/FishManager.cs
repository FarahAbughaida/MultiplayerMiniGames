using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    [SerializeField]
    float waitTimeBeforeDestroy = 1f;

    void Start()
    {
        Destroy(this.gameObject, waitTimeBeforeDestroy);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger");
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerManager>().CollectedFish();
            Destroy(this.gameObject);
        }
    }
}

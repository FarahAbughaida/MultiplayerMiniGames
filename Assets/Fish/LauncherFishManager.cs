using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class LauncherFishManager : MonoBehaviour
{
    [SerializeField]
    GameObject fishObject;

    [SerializeField]
    GameObject trapFishObject;

    [SerializeField]
    float waitTime;

    public int typeOfFish = 0;

    private void Start()
    {
        StartCoroutine(LaunchFish());
    }

    IEnumerator LaunchFish()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            CreateFish();
        }
    }

    public void CreateFish()
    {
        typeOfFish = Random.Range(0, 2);

        switch (typeOfFish)
        {
            case 0:
                Instantiate(fishObject, transform.position, Quaternion.identity);
                break;
            case 1:
                Instantiate(trapFishObject, transform.position, Quaternion.identity);
                break;
        }
    }
}

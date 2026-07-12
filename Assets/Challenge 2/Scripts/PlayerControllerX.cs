using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float countTime = 0;

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(countTime >= 2f)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                countTime = 0;
            }
        }
    }
}

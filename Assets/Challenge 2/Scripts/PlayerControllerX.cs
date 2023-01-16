using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool isLaunched = false;
    private float spawnDelay = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        StartCoroutine(SpawnDog());
    }

    IEnumerator SpawnDog()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isLaunched)
        {
            isLaunched = true;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            yield return new WaitForSeconds(spawnDelay);
            isLaunched = false;
        }
    }
}
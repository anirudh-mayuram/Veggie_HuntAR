using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    //public Transform[] spawnPoints;
    public GameObject[] fruits;
    timer tm = new timer();


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    void Update()
    {
        if (Time.deltaTime > tm.timeVal)
            StopAllCoroutines();
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(0.5F);


        int i = Random.Range(0, 10);
        var position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-5.0f, 5.0f), Random.Range(-10.0f, 10.0f));
        Instantiate(fruits [i], position, Quaternion.identity);

        StartCoroutine(StartSpawning());
    }
}

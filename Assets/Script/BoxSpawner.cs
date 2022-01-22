using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject BoxPrefab;
    // Use this for initialization
    void Start()
    {
        SpawnBox();
    }

    public void SpawnBox()
    {
        GameObject obj = Instantiate(BoxPrefab);
        Vector3 temp = transform.position;
        temp.z = 0;
        obj.transform.position = temp;
    }
    // Update is called once per frame
    void Update()
    {

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour
{

    public Transform arCamera;
    public GameObject projectile;
    public float shootForce = 1000.0f;
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            GameObject bullet = Instantiate(projectile, arCamera.position, arCamera.rotation * Quaternion.Euler(0f, -90f, 0f)) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(arCamera.forward * shootForce);
        }
    }

    private GameObject Instantiate(GameObject projectile, Vector3 position, object p)
    {
        throw new NotImplementedException();
    }
}

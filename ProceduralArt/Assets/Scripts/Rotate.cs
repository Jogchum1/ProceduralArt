using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject gameObject;

    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
       gameObject.transform.Rotate(Vector3.up * (rotateSpeed * Time.deltaTime));
    }
}

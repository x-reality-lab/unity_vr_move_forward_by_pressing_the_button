using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardScript : MonoBehaviour
{

    public float speed = 3.0f;

    void Update()
    {
        if (Input.GetButton("Fire1") || Input.touchCount > 0)
        {
            Vector3 foward = Camera.main.transform.forward;
            foward.y = 0;
            this.transform.position += foward * Time.deltaTime * speed;
        }
    }
}
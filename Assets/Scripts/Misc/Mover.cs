using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float velocity = 1f;

    void Update()
    {
        transform.position += new Vector3(-velocity * Time.deltaTime, 0.0f, 0.0f);
    }
}

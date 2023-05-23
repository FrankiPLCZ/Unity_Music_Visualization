using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_mov2 : MonoBehaviour
{
    public Transform target; // The point we want to move towards
    public float speed = 5.0f; // The speed at which we move

    void Update()
    {
          transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}

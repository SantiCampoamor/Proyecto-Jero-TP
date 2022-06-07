using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float movementVertical;
    public float rotationHorizontal;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3 (0, 1.5f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3( 0, 0.5f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, -rotationHorizontal, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, rotationHorizontal, 0);
        }
    }
}

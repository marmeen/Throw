using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThrowController : MonoBehaviour
{
    float moveSpeed;
    float rotSpeed;

    float mousePosition;

    void Update()
    {
        bool down = Input.GetMouseButtonDown(0);
        bool up = Input.GetMouseButtonUp(0);

        if (down)
        {
            mousePosition = Input.mousePosition.y;
        }

        if (up)
        {
            mousePosition -= Input.mousePosition.y;
            moveSpeed = mousePosition * 0.00024f;
            rotSpeed = 35.0f;
        }

        float throwPosition = this.gameObject.transform.position.y;

        this.transform.Translate(0, -moveSpeed, 0, Space.World);
        this.transform.Rotate(0, 0, rotSpeed);

        moveSpeed *= 0.96f;
        rotSpeed *= 0.96f;

    }
}

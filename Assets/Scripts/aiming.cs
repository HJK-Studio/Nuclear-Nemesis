using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiming : MonoBehaviour
{
    public Rigidbody2D rb;
    public Camera cam;
    public Transform RotPos;

    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        Vector2 RotPos2D = (Vector2)RotPos.position;
        Vector2 lookDir = mousePos - RotPos2D;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}

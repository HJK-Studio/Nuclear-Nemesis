using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2aim : MonoBehaviour
{
    public Rigidbody2D rb;
    public Camera cam;
    public Transform RotPos;
    public float constraint;

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
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f + constraint;
        rb.rotation = angle;
    }
}

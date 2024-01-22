using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adjust_power : MonoBehaviour
{
    public Slider slider;
    public Camera cam;
    public Transform Base; 
    public float height = 11.015f;
    public float scrollSpeed = 0.6f;

    Vector2 MousePos;
    Vector2 BasePos;

    void SetPower(float PowerVal)
    {
        slider.value = PowerVal;
    }

    // Start is called before the first frame update
    void Start()
    {
        float val = Random.Range(0f, 1f);
        SetPower(val);
    }


    void Update()
    {
        // MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        // BasePos = Base.position;
        // float Increment = (MousePos.y - BasePos.y) / height;
        float scrollWheelInput = Input.GetAxis("Mouse ScrollWheel");
        // SetPower(scrollWheelInput);
        slider.value += scrollWheelInput * scrollSpeed;
        slider.value = Mathf.Clamp(slider.value, slider.minValue, slider.maxValue);
    }
}

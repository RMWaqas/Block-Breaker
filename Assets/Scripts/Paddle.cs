using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // parameters
    [SerializeField] float screenWidthInUnits = 16f; // serialized for debugging purposes
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 peddlePos = new Vector2(transform.position.x, transform.position.y);
        peddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = peddlePos;
    }
}

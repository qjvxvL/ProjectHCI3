using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleInOut : MonoBehaviour
{
    public float zoomSpeed = 1.0f; // Adjust this to control the speed of zooming
    public float minZoom = 0.5f;    // Minimum scale
    public float maxZoom = 2.0f;    // Maximum scale

    private Vector2 touchStart;
    private float initialDistance;
    private float initialScale;

    void Update()
    {
        float zoomDelta = Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;

        // Calculate the new scale based on zoom input
        Vector3 newScale = transform.localScale + new Vector3(zoomDelta, zoomDelta, zoomDelta);

        // Clamp the scale to stay within the minZoom and maxZoom range
        newScale = Vector3.ClampMagnitude(newScale, maxZoom);

        // Update the scale if it's within the allowed range
        if (newScale.magnitude > minZoom && newScale.magnitude < maxZoom)
        {
            transform.localScale = newScale;
        }

        if (Input.touchCount == 2)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            if (touch0.phase == TouchPhase.Began || touch1.phase == TouchPhase.Began)
            {
                initialDistance = Vector2.Distance(touch0.position, touch1.position);
                initialScale = transform.localScale.magnitude;
            }

            float currentDistance = Vector2.Distance(touch0.position, touch1.position);
            float zoomDeltaTouch = (currentDistance - initialDistance) * zoomSpeed;

            // Calculate the new scale based on zoom input
            float newScaleMagnitude = initialScale + zoomDeltaTouch;
            newScaleMagnitude = Mathf.Clamp(newScaleMagnitude, minZoom, maxZoom);

            // Update the scale if it's within the allowed range
            if (newScaleMagnitude > minZoom && newScaleMagnitude < maxZoom)
            {
                Vector3 newScaledVector = transform.localScale.normalized * newScaleMagnitude;
                transform.localScale = newScaledVector;
            }
        }
    }
}

    



using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrollHorizontal : MonoBehaviour
{
    public ScrollRect scrollRect; // Reference to the ScrollRect component
    public float swipeThreshold = 0.2f; // Swipe sensitivity threshold
    public float smoothness = 0.1f; // Smoothness factor for scrolling

    private float[] positions;
    private int selectedIndex = 0;

    void Start()
    {
        int count = scrollRect.content.childCount;
        positions = new float[count];

        for (int i = 0; i < count; i++)
        {
            positions[i] = i / (float)(count - 1);
        }

        scrollRect.horizontalNormalizedPosition = positions[selectedIndex];
    }

    public void ScrollToIndex(int index)
    {
        if (index < 0 || index >= positions.Length) return;

        selectedIndex = index;
        StopAllCoroutines(); // Stop any ongoing scrolling
        StartCoroutine(SmoothScrollToPosition(positions[index]));
    }

    private IEnumerator SmoothScrollToPosition(float targetPosition)
    {
        float startPosition = scrollRect.horizontalNormalizedPosition;
        float elapsedTime = 0f;

        while (elapsedTime < 1f)
        {
            elapsedTime += Time.deltaTime / smoothness;
            scrollRect.horizontalNormalizedPosition = Mathf.Lerp(startPosition, targetPosition, elapsedTime);
            yield return null;
        }
        scrollRect.horizontalNormalizedPosition = targetPosition;
    }

    void Update()
    {
        // Use touch or mouse for swiping
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 startPos = Input.mousePosition;
            Vector2 endPos = startPos;
            if (Input.GetMouseButtonUp(0))
            {
                endPos = Input.mousePosition;
                float swipeDistance = endPos.x - startPos.x;

                if (Mathf.Abs(swipeDistance) > swipeThreshold)
                {
                    if (swipeDistance < 0)
                    {
                        ScrollToIndex(Mathf.Clamp(selectedIndex + 1, 0, positions.Length - 1));
                    }
                    else
                    {
                        ScrollToIndex(Mathf.Clamp(selectedIndex - 1, 0, positions.Length - 1));
                    }
                }
            }
        }
    }
}

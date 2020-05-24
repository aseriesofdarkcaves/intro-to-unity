using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private int frameCount = 0;

    // Start is called before the first frame update
    private void Start()
    {
        print("We're in the Start method!");
        int x1 = 0;
        int y1 = 0;
        int x2 = 5;
        int y2 = 5;
        float distance = GetDistance(x1, y1, x2, y2);
        print("Calculated distance between (" + x1 + ", " + y1 + ") & (" + x2 + ", " + y2 + ") to be: " + distance);
    }

    // Update is called once per frame
    private void Update()
    {
        frameCount += 1;
        print("Frame count: " + frameCount);
    }

    private float GetDistance(float x1, float y1, float x2, float y2)
    {
        float dx = x2 - x1;
        float dy = y2 - y1;
        float distanceSquared = (dx * dx) + (dy * dy);
        float distance = Mathf.Sqrt(distanceSquared);
        return distance;
    }
}

using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Transform targetTransform;
    public float movementSpeed;
    public float standoffDistance;

    private void Update()
    {
        Vector3 displacementFromTarget = targetTransform.position - transform.position;
        Vector3 directionToTarget = displacementFromTarget.normalized;
        Vector3 velocity = directionToTarget * movementSpeed;

        float distanceToTarget = displacementFromTarget.magnitude;

        if (distanceToTarget > standoffDistance)
            transform.Translate(velocity * Time.deltaTime);
    }
}

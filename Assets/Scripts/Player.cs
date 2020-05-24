using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed;
    
    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * movementSpeed;
        // Time.deltaTime decouples the update refresh from the frame rate
        Vector3 displacement = velocity * Time.deltaTime;

        //transform.position += displacement;
        transform.Translate(displacement);
    }
}

using UnityEngine;

public class AvailableMethods : MonoBehaviour
{
    // Awake is called before anything else, even Start()
    void Awake ()
    {
        Debug.Log("Awake");
    }

    // This gets called on the frame when the GameObject is initialised
    void Start ()
    {
        Debug.Log("Start");
    }

    // Update is called every single frame and is framerate locked
    void Update ()
    {
        //Debug.Log("Update every frame");
    }

    // This is a fixed update function and is often used to call physics functions
    void FixedUpdate ()
    {
        //Debug.Log("Fixed update");
    }

    // This is called at the end of the frame
    void LateUpdate ()
    {
        //Debug.Log("Late update");
    }

    // This is called on the first frame that the attached GameObject is enabled
    void OnEnable ()
    {
        Debug.Log("Enabled");
    }

    // This is called on the first frame that the attached GameObject is disabled
    void OnDisable ()
    {
        Debug.Log("Disabled");
    }
}

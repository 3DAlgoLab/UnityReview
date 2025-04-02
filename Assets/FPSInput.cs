using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float speed = 1.0f;
    public float gravity = -9.8f; 
    private CharacterController _charController; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _charController = GetComponent<CharacterController> ();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, speed, 0);
        var deltaX = Input.GetAxis("Horizontal") * speed;
        var deltaZ = Input.GetAxis("Vertical") * speed;
        var movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity; 
        
        movement *= Time.deltaTime;
        // Transform movement vector from local to global coordinate
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
    }
}

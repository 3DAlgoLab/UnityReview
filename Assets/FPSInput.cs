using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, speed, 0);

        var deltaX = Input.GetAxis("Horizontal") * speed;
        var deltaZ = Input.GetAxis("Vertical") * speed;

        var t_delta = Time.deltaTime;
        transform.Translate(deltaX * t_delta, 0, deltaZ * t_delta);
    }
}

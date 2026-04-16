using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public float LaunchSpeed = 20.0f;
    float moveY;
    Vector3 position;
    public Vector3 startPosition;
    public Quaternion startRotation;
    public Vector3 endPosition;
    public Quaternion endRotation;
    public GameObject BallLauncherSquare;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;

    }

    // Update is called once per frame
    void Update()
    {
        
        // This should allow the ball to spawn and launch when spacebar is pressed
        if (Input.GetKey(KeyCode.Space))
        {
            moveY = position.y * Time.deltaTime * LaunchSpeed;
            transform.Translate(endPosition);

        }
        else
        {
            
            //This should make it go back to start when the spacebar isn't being held. 
            transform.position = startPosition;
            transform.rotation = startRotation;
        }


    }
}

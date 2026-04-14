using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public float LaunchSpeed = 20.0f;
    float moveY;
    Vector3 position;
    private Vector3 startPosition;
    private Quaternion startRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        

        
       

        // This should allow the ball to spawn when spacebar is pressed, then have the ball launch 
        // when spacebar is released.
        if (Input.GetKeyUp(KeyCode.Space))
        {
            moveY = position.y * Time.deltaTime * LaunchSpeed;
            transform.position =
            
            transform.position = position;

        }
        else
        {
            //This should make it go back to start when the spacebar isn't being held. 
            transform.position = startPosition;
            transform.rotation = startRotation;
        }


    }
}

using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BouncePeg : MonoBehaviour
{
    public int points = 50;
    public Score score;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // This is for detecting collisions between the disc and other objects
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // This is to make sure that the pegs bounce. (WARNING, BOUNCE PEG LACKS BOUNCE) 
        if (collision != null)
        {
            Vector2 Bounce = collision.gameObject.GetComponent<Rigidbody2D>().linearVelocity;
            Bounce = Bounce.normalized;
            Bounce *= 10;

            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Bounce, ForceMode2D.Impulse);

            score.AddPoints(points);
        }
    }


    // Update is called once per frame
    //void //Update()
    //{
        // More Peg bouncing
            //if (Collision != null)



    //}
}

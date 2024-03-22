using UnityEngine;
using Debug = UnityEngine.Debug;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRigidbody;

    public float basicForce;

    public float forwardSpeed;
    

    // Update is called once per frame
    private void FixedUpdate()
    {
        playerRigidbody.AddForce(0, 0, forwardSpeed* Time.deltaTime);
        if (Input.GetKey("a"))
        {
            playerRigidbody.AddForce(-basicForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("d"))
        {
            playerRigidbody.AddForce(basicForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.touchCount > 0)
        {
            if (Input.touches[0].position.x *2< Screen.width)
            {
                playerRigidbody.AddForce(-basicForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else if(Input.touches[0].position.x *2>Screen.width)
            {
                playerRigidbody.AddForce(basicForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }            
        }

        if (transform.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Obstacle")) return;
        FindObjectOfType<PlayerMovement>().enabled = false;
        FindObjectOfType<GameManager>().EndGame();
    }
}
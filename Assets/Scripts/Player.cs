using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the gameobject

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = Vector3.forward * 10f;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            rb.velocity = Vector3.up * 10f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = Vector3.back * 10f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = Vector3.right * 10f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = Vector3.left * 10f;
        }


        // Change the color of the gameobject
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }

    }// update-funktio p‰‰ttyy t‰h‰n

    //ker‰ill‰‰n karkkeja
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            // Increment score
            GameControl.instance.IncrementScore();

            // Let¥s collect things
            Destroy(collision.gameObject);
        }
        // Let¥s get destroyed by enemy
        if (collision.gameObject.tag == "Enemy")
        {
            //Destroy(gameObject);

            // Let¥s load the GameOver -scene

            //SceneManager.LoadScene("GameOver");

            // Decrease Lives
            GameControl.instance.DecreaseLife();
            // Destroy the enemy
            Destroy(collision.gameObject);
        }
    }

} // Player p‰‰ttyy t‰h‰n




 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject explosion;

    private CameraShake shake;

    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("camShake").GetComponent<CameraShake>();
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) // check if the enemy collided with a bullet
    {
        if(other.tag == gameObject.tag)
        {

            shake.CamShake();
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(gameObject);   
            
            
        }
        else
        {
            shake.CamShake();
            Instantiate(explosion, transform.position, Quaternion.identity);
            GameOver();
           
        }

        if (other.CompareTag("Player"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            GameOver();
           
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovingScript : MonoBehaviour
{
    
    
    Rigidbody2D rbmovingwall;
    public GameObject myPrefab;


    // Start is called before the first frame update
    void Start()
    {
        rbmovingwall = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbmovingwall.AddForce(Vector2.left * 5);

        // moved off the left side of screen
        if (this.transform.position.x < -10)
        {
            
            Instantiate(myPrefab, new Vector2(Random.Range(20,22), Random.Range(-5,5)), Quaternion.identity);
            Destroy(gameObject);
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathWall")
        {
            Instantiate(myPrefab, new Vector2(Random.Range(20, 22), Random.Range(-5, 5)), Quaternion.identity);
            Destroy(gameObject);
            
        }
    }

}
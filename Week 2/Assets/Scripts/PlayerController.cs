using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
	
	public int score = 0;

	// there's only going to be 1 object that is "instance"
	public static PlayerController instance;

	// make this that object
	private void Awake()
	{
		if(instance == null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	// for physics
	public float force;
	Rigidbody2D rb;
	
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello world.");
		rb = GetComponent<Rigidbody2D>();		
    }

    // Update is called once per frame
    void Update()
    {

		if (Input.GetKey(KeyCode.Space)) // if Space is pressed
		{
			rb.velocity = new Vector2(0,0);
		}
		else
		{
			if (Input.GetKey(KeyCode.W)) // if W is pressed
			{
				rb.AddForce(Vector2.up * force); //apply a force using the "force" var
			}
			if (Input.GetKey(KeyCode.A)) // if A is pressed
			{
				rb.AddForce(Vector2.left * force); //apply a force using the "force" var
			}
			if (Input.GetKey(KeyCode.D)) // if D is pressed
			{
				rb.AddForce(Vector2.right * force); //apply a force using the "force" var
			}
			if (Input.GetKey(KeyCode.S)) // if S is pressed
			{
				rb.AddForce(Vector2.down * force); //apply a force using the "force" var
			}

		}
	}
}

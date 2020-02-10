using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Model : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set the text to the score
        print(gameObject.name);
        gameObject.GetComponent<UnityEngine.UI.Text>().text = PlayerController.instance.score.ToString();

        // press R to restart
        if (Input.GetKey(KeyCode.R))
        {
            PlayerController.instance.score = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}

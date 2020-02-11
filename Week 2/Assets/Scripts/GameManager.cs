using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // there's only going to be 1 object that is "instance"
    public static GameManager instance;

    // make this that object
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }



    public static float timer = 0;
    public Text infoText;

    // Start is called before the first frame update
    void Start()
    {
        // set the text to the score
        infoText = GameObject.Find("TextScore").GetComponent<UnityEngine.UI.Text>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        infoText.text = PlayerController.instance.score.ToString() + " / " + PrizeScript.targetScore.ToString();


        // press R to restart
        if (Input.GetKey(KeyCode.R))
        {
            PlayerController.instance.score = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }



    }
}

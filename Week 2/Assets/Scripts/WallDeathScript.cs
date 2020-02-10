using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDeathScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.GetComponent<SpriteRenderer>().color = new Color(0.75f + Mathf.Sin(Time.time * 4) * 0.25f, 0.085f, 0.085f, 1.0f);

    }
}

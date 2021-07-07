using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ffff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x >= 87.5)
        {
            Destroy(gameObject);
            Application.LoadLevel("win");
        }
    }
}

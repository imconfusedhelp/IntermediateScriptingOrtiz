using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : humanoid
{
    // Start is called before the first frame update
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

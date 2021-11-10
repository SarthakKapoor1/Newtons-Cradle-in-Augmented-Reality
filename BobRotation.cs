using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobRotation : MonoBehaviour
{
public Transform bob1;
public Transform bob2;
public int angle;
public int direction;
    // Start is called before the first frame update
    void Start()
    {
        angle=0;
        direction=1;
    }

    // Update is called once per frame
    void Update()
    {
        if(angle>=0)
        {
        bob1.Rotate(direction,0,0);
        }else{
        bob2.Rotate(direction,0,0);
        }
        angle=angle+direction;
 
        if(angle>=50)
        {
        direction=-1;
        angle=49;
        }
        if(angle<=-50)
        {
        direction=1;
        angle=-49;
        }
        
    }
}

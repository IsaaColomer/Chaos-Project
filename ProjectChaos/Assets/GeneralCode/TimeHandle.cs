using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeHandle : MonoBehaviour
{
    // Start is called before the first frame update
    

    public bool CountDownTimer(float time)
    {
        time-= Time.deltaTime;
        return (time > 0f) ? false : true;        
    }
}

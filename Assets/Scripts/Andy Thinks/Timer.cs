using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer{
    public float delay;
    public float NextTime;
    public bool isactive;
    public Timer(float time = 0, bool active = false)
    {
        delay = time;
        isactive = active;
    }
    public void Play()
    {
        NextTime = Time.time + delay;
    }
    public bool IsDone(bool reset = false)
    {
        bool result = Time.time >= NextTime;
        if (result && reset) Play();
        return result;
    }

}

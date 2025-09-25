using UnityEngine;

public class KeypadManagerScript : MonoBehaviour
{
    bool twoo = false;
    bool onee = false;
    bool sevenn = false;
    bool fivee = false;
    int c = 0;
    bool W = false;
    bool L = false;

    public void one()
    {
        if(c == 1)
        {
            onee = true;
            c = c+1;
        }
        else
        {
            L = true;
        }
    }
    public void two()
    {
        if(c == 0)
        {
            twoo = true;
            c = c+1;
        }
        else
        {
            L = true;
        }
    }
    public void three()
    {
        L = true;   
    }
    public void four()
    {
        L = true;
    }
    public void five()
    {
        if(c == 2)
        {
            fivee = true;
            c = c+1;
        }
        else
        {
            L = true;
        }
    }
    public void six()
    {
        L = true;
    }
    public void seven()
    {
        if(c == 3)
        {
            sevenn = true;
            c = c+1;
            W = true;
        }
        else
        {
            L = true;
        }
    }
    public void eight()
    {
        L = true;
    }
    public void nine()
    {
        L = true;
    }

    void Update()
    {
        if(L == true)
        {
            Debug.Log("Loss");
        }
        if(W == true)
        {
            Debug.Log("Won");
        }
    }
}
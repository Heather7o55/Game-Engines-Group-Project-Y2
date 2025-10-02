using UnityEngine;

public class MANAGHERS : MonoBehaviour
{
    bool twoo = false;
    bool onee = false;
    bool sevenn = false;
    bool fivee = false;

    bool threee = false;
    bool fourr = false;
    bool sixx = false;
    bool eightt = false;
    bool ninee = false;
    int c = 0;
    bool W = false;
    bool L = false;

    public void one()
    {
        if(c == 0)
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
        if(c == 1)
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
        if(c == 2)
        {
            threee = true;
            c = c+1;
        }
        else
        {
            L = true;
        } 
    }
    public void four()
    {
        if(c == 3)
        {
            fourr = true;
            c = c+1;
        }
        else
        {
            L = true;
        } 
    }
    public void five()
    {
        if(c == 4)
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
        if(c == 5)
        {
            sixx = true;
            c = c+1;
        }
        else
        {
            L = true;
        } 
    }
    public void seven()
    {
        if(c == 6)
        {
            sevenn = true;
            c = c+1;
        }
        else
        {
            L = true;
        }
    }
    public void eight()
    {
        if(c == 7)
        {
            eightt = true;
            c = c+1;
        }
        else
        {
            L = true;
        } 
    }
    public void nine()
    {
        if(c == 8)
        {
            ninee = true;
            c = c+1;
            W = true;
        }
        else
        {
            L = true;
        } 
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
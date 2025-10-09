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
    public GameObject SetActive;
    public GameObject SetActive1;
    public GameObject SetActive2;
    public GameObject SetActive3;
    public GameObject SetActive4;
    public GameObject SetActive5;
    public GameObject SetActive6;
    public GameObject SetActive7;
    public GameObject SetActive8;

    public GameObject WIN_SA9;

    public int Lcount = 0;
    bool LossReal = false;

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
        SetActive.SetActive(false);
        SetActive1.SetActive(false);
        SetActive2.SetActive(false);
        SetActive3.SetActive(false);
        SetActive4.SetActive(false);
        SetActive5.SetActive(false);
        SetActive6.SetActive(false);
        SetActive7.SetActive(false);
        SetActive8.SetActive(false);
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
            SetActive.SetActive(true);
            SetActive1.SetActive(true);
            SetActive2.SetActive(true);
            SetActive3.SetActive(true);
            SetActive4.SetActive(true);
            SetActive5.SetActive(true);
            SetActive6.SetActive(true);
            SetActive7.SetActive(true);
            SetActive8.SetActive(true);
            Lcount = Lcount+1;
            L = false;
        }
        if(Lcount>=5)
        {
            LossReal = true;
            Time.timeScale = 0.0f;
        }
        if(W == true)
        {
            Debug.Log("Won");
            // attatch movement
            WIN_SA9.SetActive(true);
        }
    }
}
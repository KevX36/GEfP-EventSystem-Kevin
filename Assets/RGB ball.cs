using UnityEngine;

public class RGBball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

    }
    public bool rave = false;
    public Animation ani;
    public void toggleRave()
    {
        if( rave )
        {
            rave = false;
            ani.Stop();
        }
        else
        {
            rave = true;
            ani.Play();
        }
    }
}

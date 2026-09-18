using UnityEngine;

public class cubeSpin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (spin)
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime*5);
        }
    }

    public bool spin = false;
    public void ToggleSpin()
    {
        if (spin)
        {
            spin = false;
        }
        else
        {
            spin = true;
        }
    }
}

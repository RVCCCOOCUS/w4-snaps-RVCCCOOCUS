using UnityEngine;

public class door_manager_2 : MonoBehaviour
{
    private bool doorlever2  = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doorlever2 == true )
        {
            this.gameObject.SetActive(false);
        }
    }
    public void pull_door_2()
    {
        doorlever2 = true;


    }
}

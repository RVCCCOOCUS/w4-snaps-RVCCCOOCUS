using UnityEngine;

public class dorr_manager_4 : MonoBehaviour
{
    private bool doorlever3 = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (doorlever3 == true)
        {
            this.gameObject.SetActive(false);
        }
    }
    public void pull_door_4()
    {
        doorlever3 = true;


    }
  }

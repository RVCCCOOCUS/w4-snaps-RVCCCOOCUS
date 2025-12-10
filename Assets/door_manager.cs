using UnityEngine;

public class door_manager : MonoBehaviour
{
    private bool CircleButtonPress=false;
    private bool SquareButtonPress = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CircleButtonPress == true && SquareButtonPress == true)
        {
            this.gameObject.SetActive(false);
        }
    }
    public void PressRoundButton()
    {
        CircleButtonPress=true;


    }
    public void PressSquareButton()

        { SquareButtonPress=true; }
}





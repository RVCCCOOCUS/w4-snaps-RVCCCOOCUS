using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class has_key_card : MonoBehaviour
{
    private bool HaskeyCard = false;
    public Text carryText;
    public GameObject keycardobject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HaskeyCard == true)
        {
            carryText.text = "carrying, keycard";
        }
    }
    public void takekeycard() { 
    HaskeyCard=true;
        keycardobject.SetActive(false);
    }
}

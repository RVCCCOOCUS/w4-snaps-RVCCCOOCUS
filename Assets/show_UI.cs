using UnityEngine;

public class show_UI : MonoBehaviour
{


    [SerializeField]
    private GameObject squarepanal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        squarepanal.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        squarepanal.SetActive(false);
    }
}

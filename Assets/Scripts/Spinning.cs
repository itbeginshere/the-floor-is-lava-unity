using UnityEngine;

public class Spinning : MonoBehaviour
{
    public Vector3 rotateChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateChange * Time.deltaTime);   
    }
}

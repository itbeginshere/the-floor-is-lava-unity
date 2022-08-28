using UnityEngine;

public class Raising : MonoBehaviour
{
    public Vector3 positionChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (positionChange * Time.deltaTime);
    }
}

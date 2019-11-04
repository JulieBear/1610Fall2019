using UnityEngine;

 
[RequireComponent(typeof(Rigidbody))] 
public class FallOver : MonoBehaviour 
{
 
    private Rigidbody rigBody;
    public float mDistance = 3f;
    public Transform thePlayer; 
    
    void Start () 
    {
        rigBody = GetComponent<Rigidbody> ();
        rigBody.useGravity = false;
    }
 
    void Update()
    {
        if (Vector3.Distance (thePlayer.position, transform.position) < mDistance) 
        { 
            rigBody.useGravity = true;
        }
    }
}
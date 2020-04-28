using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ammo : MonoBehaviour
{
    public float speed = 100f;
    private Rigidbody rigidBod;

    void Start()
    {
        rigidBod = GetComponent<Rigidbody>();
        rigidBod.velocity = transform.right * speed;
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}
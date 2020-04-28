using UnityEngine;

public class Shoot : MonoBehaviour
{
    public bool facingRight;
    public GameObject leftBull, rightBull;
    private Transform firing;

    private void Awake()
    {
        firing = transform.Find("Firing");
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Fire();
        }
    }

    void Fire()
    {
        if (facingRight) {
            Instantiate (rightBull, firing.position, Quaternion.identity);
        }
        if (!facingRight)
        {
            Instantiate (leftBull,firing.position, Quaternion.identity);
        }
    }
}
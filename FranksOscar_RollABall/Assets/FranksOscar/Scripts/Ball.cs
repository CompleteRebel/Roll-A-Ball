using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    Rigidbody _CachedRB;
    private Vector3 _Move;

    public void Start()
    {
        _CachedRB = GetComponent<Rigidbody>();
    }

    public void Move (Vector3 move)
    {
        _Move += move;
    }

    public void FixedUpdate()
    {
        _CachedRB.AddForce(_Move);

        _Move = Vector3.zero;
    }
}

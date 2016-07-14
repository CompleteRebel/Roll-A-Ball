using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    Rigidbody _CachedRB;
    private Vector3 _Move;
    private Vector3 _Jump;

    public void Start()
    {
        _CachedRB = GetComponent<Rigidbody>();
    }

    public void Move (Vector3 move)
    {
        _Move += move;
    }

    public void Jump (Vector3 jump)
    {
        _Jump += jump;
    }

    public void FixedUpdate()
    {
        _CachedRB.AddForce(_Move);

        _Move = Vector3.zero;
        _Jump = Vector3.zero;
    }
}

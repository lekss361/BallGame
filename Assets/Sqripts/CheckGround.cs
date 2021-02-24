using UnityEngine;

public class CheckGround : MonoBehaviour
{   
    [SerializeField] private float _radius;
    [SerializeField] private Transform _foot;
    [SerializeField] private LayerMask _ground;

    public bool Check()
    {
        return Physics2D.OverlapCircle(_foot.position, _radius, _ground);
    }
}

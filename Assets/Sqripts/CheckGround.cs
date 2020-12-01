using UnityEngine;

public class CheckGround : MonoBehaviour
{   
    [SerializeField] private float _radius;
    [SerializeField] private Transform _checkTransform;
    [SerializeField] private LayerMask _ground;
    public bool _CheckGround ()
    { 
    if (Physics2D.OverlapCircle(_checkTransform.position,_radius,_ground))
        {
        return true;
        }
        return false;
    }
}

using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform _player;

   private void Update()
   {
        TrackingObject(_player);
   }

   private void TrackingObject(Transform Object)
   {
        transform.position = new Vector3(Object.position.x,transform.position.y,transform.position.z);
   }
}

using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Transform _positionPlayer;

   private void Update()
   {
        ChangePositionCamerea();
   }

    private void ChangePositionCamerea()
    {
        transform.position = new Vector3(_positionPlayer.position.x,transform.position.y,transform.position.z);
    }
}

using UnityEngine;

public class SpawnGround : MonoBehaviour
{
    [SerializeField] private GameObject _ground;
    [SerializeField] private Transform _player;
    [SerializeField] private float _distanceSpawn;
    [SerializeField] private Transform _positionGround;

    private void Update()
    {
        SpawningGround();
    }

    private void SpawningGround()
    {
        if (_player.position.x+_distanceSpawn>_positionGround.position.x)
        {
            _positionGround.position+=new Vector3(Random.Range(0, 6),0,0);
            Instantiate(_ground,_positionGround.position,_positionGround.rotation);
            _positionGround.position += new Vector3(9, 0, 0);
        }
    }
}

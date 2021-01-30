using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private List<GameObject> SpawnObjects;
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject _coinPosition;
    [SerializeField] private float _distanceSpawnCoin;
    [SerializeField] private float _distanceSpawnGround;
    [SerializeField] private Transform _positionGround;
    [SerializeField] private float MinIntervalGround;
    [SerializeField] private float MaxIntervalGround;
    [SerializeField] private float MinIntervalCoin;
    [SerializeField] private float MaxIntervalCoin;

    private void Update()
    {
        if (_player.position.x + _distanceSpawnGround > _positionGround.position.x)
        {
            Spawn(_positionGround, SpawnObjects[0],MinIntervalGround,MaxIntervalGround);
        }

        if (_player.position.x + _distanceSpawnCoin > _coinPosition.transform.position.x)
        {
            Spawn(_coinPosition.transform, SpawnObjects[1],MinIntervalCoin,MaxIntervalCoin);
        }
    }

    private void Spawn(Transform position, GameObject ObjectSpawn,float MinInterval, float MaxInterval)
    {
        float Width = ObjectSpawn.GetComponent<Renderer>().bounds.size.x;
        position.position += new Vector3(Random.Range(Width * MinInterval, Width * MaxInterval), 0, 0);

        if (_coinPosition.GetComponent<CheckGround>().Check()||ObjectSpawn.layer==8)
        {
            Instantiate(ObjectSpawn, position.position, position.rotation);
        }

        position.position += new Vector3(Width, 0, 0);
    }

}

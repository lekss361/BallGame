using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnObjects;
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _coinPosition;
    [SerializeField] private float _distanceSpawnCoin;
    [SerializeField] private float _distanceSpawnGround;
    [SerializeField] private Transform _groundPosition;

    private void Update()
    {
        SpawnConditions(_spawnObjects[0], _distanceSpawnCoin, _coinPosition);
        SpawnConditions(_spawnObjects[1], _distanceSpawnGround, _groundPosition);
    }

    private void SpawnConditions(GameObject objectSpawn,float distanceSpawn,Transform lastObjectPosition)
    {
        float minInterval;
        float maxInterval;

        if (objectSpawn.GetComponent<CoinSpawnParameters>()==true)
        {
           minInterval = objectSpawn.GetComponent<CoinSpawnParameters>().MinInterval;
           maxInterval = objectSpawn.GetComponent<CoinSpawnParameters>().MaxInterval;
        }
        else
        {
           minInterval = objectSpawn.GetComponent<GroundSpawnParameters>().MinInterval;
           maxInterval = objectSpawn.GetComponent<GroundSpawnParameters>().MaxInterval;
        }

        if (_player.position.x + distanceSpawn > lastObjectPosition.position.x)
        {
            Spawn(lastObjectPosition, objectSpawn, minInterval, maxInterval);
        }
    }

    private void Spawn(Transform position, GameObject ObjectSpawn, float MinInterval, float MaxInterval)
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

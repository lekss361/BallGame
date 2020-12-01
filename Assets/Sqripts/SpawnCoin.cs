using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    [SerializeField] private GameObject _coin;
    [SerializeField] private CheckGround _isGround;
    [SerializeField] private Transform _playerPosition;
    [SerializeField] private GameObject _coinPosition;
    [SerializeField] private float _distanceSpawnCoin;
    void Start()
    {
        _isGround = _coinPosition.GetComponent<CheckGround>();
    }
    void Update()
    {
        SpawningCoin();
    }
    private void SpawningCoin()
    { 
        if (_playerPosition.position.x + _distanceSpawnCoin > _coinPosition.transform.position.x)
        {
            _coinPosition.transform.position += new Vector3(Random.Range(2, 10), 0, 0);
            if (_isGround._CheckGround())
            {   
                Instantiate(_coin, _coinPosition.transform.position, _coinPosition.transform.rotation);
            }
        }
    }
}

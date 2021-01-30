using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField] private Text _textCoin;
    private int _coins;

    public void Add(int coins)
    {
        _coins += coins;
        _textCoin.text = _coins.ToString();
    }
}

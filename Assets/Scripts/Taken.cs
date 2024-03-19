using UnityEngine;
using TMPro;

public class Taken : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private AudioSource _takeAudio;
    [SerializeField] private GameObject _armor;

    private int _score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
        {
            _takeAudio.Play();
            _armor.SetActive(true);
            Destroy(other.gameObject);
            _score++;
            _text.text = _score.ToString();
        }
    }
}

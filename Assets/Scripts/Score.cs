using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private TextMeshProUGUI _record;

    private float _delay = 0.1f;
    private float _repeatRate = 0.1f;
    private int _highScore;
    private int _score;

    private void Start()
    {
		_record.text = "Рекорд: " + PlayerPrefs.GetInt("HighScore");
		InvokeRepeating(nameof(AddScore), _delay, _repeatRate);
    }

    private void AddScore()
    {
        _score++;
        _text.text = _score.ToString();
		_highScore = _score;

		if (PlayerPrefs.GetInt("HighScore") <= _highScore)
        {
		    PlayerPrefs.SetInt("HighScore", _highScore);
			_record.text = "Рекорд: " + PlayerPrefs.GetInt("HighScore");
		} 	
	}
}

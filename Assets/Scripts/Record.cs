using UnityEngine;
using TMPro;

public class Record : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI _record;

	private void Start()
	{
		_record.text = "������: " + PlayerPrefs.GetInt("HighScore");
	}
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuMain()
    {
        SceneManager.LoadScene(0);
    }

	public void Exit()
	{
		Application.Quit();
	}
}

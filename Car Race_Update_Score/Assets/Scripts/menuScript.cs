using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	public Canvas QuitMenu;
	public Button startText;
	public Button exitText;

	// Use this for initialization
	void Start () {

		QuitMenu = QuitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		QuitMenu.enabled = false;
	}

	public void ExitPress()
	{
		QuitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}

	public void NoPress()
	{
		QuitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel()
	{
		//Application.LoadLevel ("Level1");
		SceneManager.LoadScene("Level1");

	}

	public void ExitGame()
	{
		Application.Quit ();
	}

}

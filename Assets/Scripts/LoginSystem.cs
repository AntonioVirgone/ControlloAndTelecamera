using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoginSystem : MonoBehaviour 
{
	private Rect rect;

	public int xPosition = 200;
	public int yPosition = 150;

	public string username = "";
	public string password = "";

	// Update is called once per frame
	void Update ()
	{
		this.rect = new Rect ((Screen.width / 2) - xPosition, (Screen.height / 2) - yPosition, 400, 300);
	}

	void OnGUI()
	{
		GUI.Window (0, this.rect, Login, "Login");
	}

	void Login(int id)
	{
		GUI.Label (new Rect (20, 50, 100, 20), "Username");
		username = GUI.TextField (new Rect (150, 50, 200, 20), username);

		GUI.Label (new Rect (20, 100, 100, 20), "Password");
		password = GUI.PasswordField (new Rect (150, 100, 200, 20), password, char.Parse("*"));

		if(GUI.Button(new Rect(20, 250, 100, 20), "Login")) {
			if(username == "Pippo") {
				print ("Username is " + username);
				SceneManager.LoadScene ("Level2");
			}
		}
	}
}

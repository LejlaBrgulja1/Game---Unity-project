using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class MainMenu : MonoBehaviour {
//	public Canvas MainCanvas;
	bool newGame=true;
	public Text playerName;
	public Text scores;
	public void NewGame ()
	{
		PlayerPrefs.DeleteAll ();
		PlayerPrefs.SetString ("GameMode", "newGame");
		PlayerPrefs.SetInt ("USBvisibility", 1);
		PlayerPrefs.SetString ("player", playerName.text);
		SceneManager.LoadScene (1);


	}

	public void Highscores ()
	{


		XmlSerializer serializer = new XmlSerializer (typeof(List<Highscore>));
		List<Highscore> highscores = new List<Highscore> ();
		using (XmlTextReader reader = new XmlTextReader ("highscores.xml")) {
			highscores = (List<Highscore>)serializer.Deserialize (reader);
		}
		highscores.Sort (delegate(Highscore a, Highscore b) {
			return a.score.CompareTo(b.score);
		});
		string s = "";
		int i = 0;
		foreach (Highscore h in highscores) {
			if (i == 10)
				break;
			s += h.player + " " + h.score+'\n';
			i++;
		}
		scores.text = s;

	}


	public void PreviousGame ()
	{
		PlayerPrefs.SetString ("GameMode", "resumeGame");
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void QuitGame ()
	{
		Application.Quit ();
	}
		

}

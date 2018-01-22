using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class FinishMenu : MonoBehaviour {

	public void Start(){
		Highscore highscore = new Highscore ();
		highscore.player = PlayerPrefs.GetString ("player");
		highscore.score = PlayerPrefs.GetFloat ("time");

		XmlSerializer serializer = new XmlSerializer (typeof(List<Highscore>));
		List<Highscore> highscores = new List<Highscore> ();
		using (XmlTextReader reader = new XmlTextReader ("highscores.xml")) {
			highscores = (List<Highscore>)serializer.Deserialize (reader);
		}

		highscores.Add (highscore);
		using (StreamWriter open = new StreamWriter ("highscores.xml")) {
			serializer.Serialize (open, highscores);
		}

		PlayerPrefs.DeleteAll ();
	}
	public void Back ()
	{
		SceneManager.LoadScene (0);
	}


	public void QuitGame ()
	{
		Application.Quit ();
	}
}

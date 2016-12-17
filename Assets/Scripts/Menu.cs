using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {

    public Canvas quitMenu;
    public Canvas optMenu;
    public Canvas instructMenu;
    public Button startText;
    public Button optionText;
    public Button exitText;

	// Use this for initialization
	void Start () {

        
        quitMenu = quitMenu.GetComponent<Canvas> ();
        optMenu = optMenu.GetComponent<Canvas>();
        instructMenu = instructMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button> ();
        optionText = optionText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
        optMenu.enabled = false;
        instructMenu.enabled = false;


    }

    public void OptPress()
    {
        quitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
        optionText.enabled = false;
        optMenu.enabled = true;

    }

    public void InstructPress()
    {
        instructMenu.enabled = true;
        quitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
        optionText.enabled = false;
        optMenu.enabled = false;

    }


    public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        optionText.enabled = false;
        optMenu.enabled = false;

    }



    public void NoPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        optionText.enabled = true;
        optMenu.enabled = false;
        instructMenu.enabled = false;

    }

    public void StartLevel()
    {
        Application.LoadLevel (1);
    }
     public void ExitGame()
    {
        Application.Quit();
    }
    
}

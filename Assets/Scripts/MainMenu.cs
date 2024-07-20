using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public int sceneID;
	public Text textComponent;
 
    void Start(){
		textComponent.gameObject.SetActive(true);

    }

	void Update () {
		if(Input.GetKeyDown(KeyCode.Return)){
			textComponent.gameObject.SetActive(false);
            SceneManager.LoadScene(sceneID);
		}	
	}  
}

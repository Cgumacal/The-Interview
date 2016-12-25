using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDialogue : MonoBehaviour {
    public Canvas UI;
    // Use this for initialization
    void Start()
    {
        UI.enabled = false;
        PlayerMovement.UIActive = false;
    }
    public void Run() {
        UI.enabled = true;
        UI.transform.FindChild("Text").gameObject.GetComponent<DialogueSequence>().Start();
        PlayerMovement.UIActive = true;
	}
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Button btn;

    public bool buttonPressed;

    public void OnPointerDown(PointerEventData data){
        buttonPressed = true;
        // Create randomizer for different scenes / games
        SceneManager.LoadScene(1);
    }
    
    public void OnPointerUp(PointerEventData data){
        buttonPressed = false;
    }
}

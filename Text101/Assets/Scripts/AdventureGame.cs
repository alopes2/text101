using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] 
    private Text _textComponent;

    [SerializeField] 
    private State _startingState;

    private State _state;

    // Start is called before the first frame update
    void Start()
    {
        _state = _startingState;
        _textComponent.text = _state.StoryText;
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = _state.NextStates;

        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                _state = nextStates[i];
            }
        }
        
        //var isKeyNumberOnePressed = Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1);
        //var isKeyNumberTwoPressed = Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2);

        //if (isKeyNumberOnePressed)
        //{
        //    _state = nextStates[0];
        //}
        //else if (isKeyNumberTwoPressed)
        //{
        //    _state = nextStates[1];
        //}

        _textComponent.text = _state.StoryText;
    }
}

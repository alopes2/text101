using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    // Use this instead of string to be able to use txt files
    [SerializeField]
    private TextAsset _storyText;

    [SerializeField]
    private State[] _nextStates;

    //[TextArea(14,10)]
    //[SerializeField]
    //private string _storyText;

    public string StoryText => _storyText.text;

    public State[] NextStates => _nextStates;
}

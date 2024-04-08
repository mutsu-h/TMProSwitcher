using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

[Serializable]
public class TMProSwitcherBehaviour : PlayableBehaviour
{
    public Color color = Color.white;
    public int fontSize = 14;
    public string text;
}

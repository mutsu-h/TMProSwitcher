using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class TMProSwitcherClip : PlayableAsset, ITimelineClipAsset
{
    public TMProSwitcherBehaviour template = new TMProSwitcherBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<TMProSwitcherBehaviour>.Create (graph, template);
        return playable;    }
}

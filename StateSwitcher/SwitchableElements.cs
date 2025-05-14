using System;
using System.Collections.Generic;
using UnityEngine;
using Utils;

namespace UIStateSwitcher
{
    [Serializable]
    public class SwitchableElements : SerializableKeyValuePair<string, List<SwitchableElement>>
    {
    }

    [Serializable]
    public class SwitchableSprite : SerializableKeyValuePair<string, Sprite>
    {
    }

    [Serializable]
    public class SwitchableText : SerializableKeyValuePair<string, string>
    {
    }

    [Serializable]
    public class SwitchableColor : SerializableKeyValuePair<string, Color>
    {
    }
    
    [Serializable]
    public class SwitchableRectTransform : SerializableKeyValuePair<string, SerializableRectTransform>
    {
    }
    
    [Serializable]
    public class SwitchableEnabled : SerializableKeyValuePair<string, bool>
    {
    }

    [Serializable]
    public class SerializableRectTransform
    {
        public Vector2 AnchoredPosition;
        public Vector2 SizeDelta;
    }
    
    [Serializable]
    public class SwitchableLayoutSettings : SerializableKeyValuePair<string, SerializableLayoutSettings>
    {
    }

    [Serializable]
    public class SerializableLayoutSettings
    {
        public RectOffset padding;
        public float spacing;
        public TextAnchor childAlignment;
        public bool reversAlignment;
    }
}
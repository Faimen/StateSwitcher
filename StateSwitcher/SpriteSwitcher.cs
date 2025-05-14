using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UIStateSwitcher
{
    public class SpriteSwitcher : SwitchableElement
    {
        [SerializeField] private Image targetImage;
        [SerializeField] private List<SwitchableSprite> switchableSprites;

        public override void Switch(string state)
        {
            var sprite = switchableSprites.Find(s => s.Key.Equals(state))?.Value;
            if(sprite != null)
                targetImage.sprite = sprite;
        }
    }
}
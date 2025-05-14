using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIStateSwitcher
{    
    public class StateSwitcher : SwitchableElement
    {
        [SerializeField] private List<string> states = new List<string>();
        [SerializeField] private List<SwitchableElement> switchableElements = new List<SwitchableElement>();

        public List<string> States => states;

        public string SelectedState { get; private set; }
        
        public override void Switch(string state)
        {
            switchableElements.ForEach(e => e.Switch(state));
            SelectedState = state;
        }
    }
}


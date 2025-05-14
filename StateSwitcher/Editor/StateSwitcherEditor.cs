using System;
using UnityEditor;
using UnityEngine;

namespace UIStateSwitcher.Editor
{
    [CustomEditor(typeof(StateSwitcher))]
    public class StateSwitcherEditor : UnityEditor.Editor
    {
        private int selectedIndex;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            StateSwitcher switcher = (StateSwitcher) target;
            GUIContent stateName = new GUIContent("State Selector");
            selectedIndex = EditorGUILayout.Popup(stateName, selectedIndex, switcher.States.ToArray());

            try
            {
                switcher.Switch(switcher.States[selectedIndex]);
            }
            catch (Exception e)
            {
                // ignored
            }
        }
    }
}
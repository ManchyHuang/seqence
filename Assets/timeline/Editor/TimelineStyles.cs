﻿using UnityEngine;

namespace UnityEditor.Timeline
{
    class TimelineStyles
    {
        const string k_Elipsis = "…";

        public static readonly GUIContent referenceTrackLabel =
            EditorGUIUtility.TrTextContent("R", "This track references an external asset");

        public static readonly GUIContent recordingLabel = EditorGUIUtility.TrTextContent("Recording...");
        public static readonly GUIContent sequenceSelectorIcon = EditorGUIUtility.IconContent("TimelineSelector");

        public static readonly GUIContent playContent =
            EditorGUIUtility.TrIconContent("Animation.Play", "Play the timeline (Space)");

        public static readonly GUIContent gotoBeginingContent =
            EditorGUIUtility.TrIconContent("Animation.FirstKey", "Go to the beginning of the timeline (Shift+<)");

        public static readonly GUIContent gotoEndContent =
            EditorGUIUtility.TrIconContent("Animation.LastKey", "Go to the end of the timeline (Shift+>)");

        public static readonly GUIContent nextFrameContent =
            EditorGUIUtility.TrIconContent("Animation.NextKey", "Go to the next frame");

        public static readonly GUIContent previousFrameContent =
            EditorGUIUtility.TrIconContent("Animation.PrevKey", "Go to the previous frame");

        public static readonly GUIContent noTimelineAssetSelected =
            EditorGUIUtility.TrTextContent("To start creating a timeline, select a GameObject");

        public static readonly GUIContent createTimelineOnSelection =
            EditorGUIUtility.TrTextContent("To begin a new timeline with {0}, create {1}");

        public static readonly GUIContent noTimelinesInScene =
            EditorGUIUtility.TrTextContent("No timeline found in the scene");

        public static readonly GUIContent createNewTimelineText =
            EditorGUIUtility.TrTextContent("Create a new Timeline and Director Component for Game Object");

        public static readonly GUIContent addContent = EditorGUIUtility.TrTextContent("Add", "Add new tracks.");

        public static readonly GUIContent previewContent =
            EditorGUIUtility.TrTextContent("Preview", "Enable/disable scene preview mode");

        public static readonly GUIContent mixOff =
            EditorGUIUtility.IconContent("TimelineEditModeMixOFF", "|Mix Mode (1)");

        public static readonly GUIContent
            mixOn = EditorGUIUtility.IconContent("TimelineEditModeMixON", "|Mix Mode (1)");

        public static readonly GUIContent rippleOff =
            EditorGUIUtility.IconContent("TimelineEditModeRippleOFF", "|Ripple Mode (2)");

        public static readonly GUIContent rippleOn =
            EditorGUIUtility.IconContent("TimelineEditModeRippleON", "|Ripple Mode (2)");

        public static readonly GUIContent replaceOff =
            EditorGUIUtility.IconContent("TimelineEditModeReplaceOFF", "|Replace Mode (3)");

        public static readonly GUIContent replaceOn =
            EditorGUIUtility.IconContent("TimelineEditModeReplaceON", "|Replace Mode (3)");

        public static readonly GUIContent showMarkersOn = EditorGUIUtility.TrTextContentWithIcon(string.Empty,
            "Show / Hide Timeline Markers", "TimelineMarkerAreaButtonEnabled");

        public static readonly GUIContent showMarkersOff = EditorGUIUtility.TrTextContentWithIcon(string.Empty,
            "Show / Hide Timeline Markers", "TimelineMarkerAreaButtonDisabled");

        public static readonly GUIContent showMarkersOnTimeline = EditorGUIUtility.TrTextContent("Show markers");

        public static readonly GUIContent timelineMarkerTrackHeader =
            EditorGUIUtility.TrTextContentWithIcon("Markers", string.Empty, "TimelineHeaderMarkerIcon");

        public static readonly GUIContent markerCollapseButton =
            EditorGUIUtility.TrTextContent(string.Empty, "Expand / Collapse Track Markers");


        private static readonly string _edit_img = @"Assets/timeline/Editor/StyleSheets/Images/";
        private static Texture2D _new_ico, _save_ico, _open_ico;

        public static Texture2D new_ico
        {
            get
            {
                if (_new_ico == null)
                {
                    _new_ico = AssetDatabase.LoadAssetAtPath<Texture2D>(_edit_img + "btn_editor_new.png");
                }
                return _new_ico;
            }
        }

        public static Texture2D open_ico
        {
            get
            {
                if (_open_ico == null)
                {
                    _open_ico = AssetDatabase.LoadAssetAtPath<Texture2D>(_edit_img + "btn_editor_open.png");
                }
                return _open_ico;
            }
        }

        public static Texture2D save_ico
        {
            get
            {
                if (_save_ico == null)
                {
                    _save_ico = AssetDatabase.LoadAssetAtPath<Texture2D>(_edit_img + "btn_editor_save.png");
                }
                return _save_ico;
            }
        }

        public static readonly GUIContent newContent = new GUIContent(new_ico, "new.");
        public static readonly GUIContent openContent = new GUIContent(open_ico, "open.");
        public static readonly GUIContent saveContent = new GUIContent(save_ico, "save.");

        // public GUIContent playrangeContent;
        // public static readonly float kBaseIndent = 15.0f;
        // public static readonly float kDurationGuiThickness = 5.0f;

        // matches dark skin warning color.
        public static readonly Color kClipErrorColor = new Color(0.957f, 0.737f, 0.008f, 1f);

        // TODO: Make skinnable? If we do, we should probably also make the associated cursors skinnable...
        public static readonly Color kMixToolColor = Color.white;
        public static readonly Color kRippleToolColor = new Color(255f / 255f, 210f / 255f, 51f / 255f);
        public static readonly Color kReplaceToolColor = new Color(165f / 255f, 30f / 255f, 30f / 255f);

        public const string markerDefaultStyle = "MarkerItem";
    }
}
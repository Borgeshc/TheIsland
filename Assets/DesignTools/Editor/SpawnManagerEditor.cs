using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SpawnManager)), CanEditMultipleObjects]
public class SpawnManagerEditor : Editor
{
    public SerializedProperty

        state_Prop;

    void OnEnable()
    {
        // Setup the SerializedProperties
        state_Prop = serializedObject.FindProperty("state");

        //List all the variables
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        serializedObject.Update();

        EditorGUILayout.PropertyField(state_Prop, new GUIContent("Object"));
        SpawnManager.Status st = (SpawnManager.Status)state_Prop.enumValueIndex;
        EditorGUIUtility.LookLikeInspector();

        switch (st)
        {
            case SpawnManager.Status.None:
                break;

            case SpawnManager.Status.Waves:
                //EditorGUILayout.Slider(sunMinSize_Prop, 0, 1000, new GUIContent("Sun's Min Size"));
                //EditorGUILayout.Slider(sunMaxSize_Prop, 0, 1000, new GUIContent("Sun's Max Size"));
                //EditorGUILayout.Slider(sunsMinX_Prop, 0, 1000, new GUIContent("Sun's Min X Spawn"));
                //EditorGUILayout.Slider(sunsMaxX_Prop, 0, 1000, new GUIContent("Sun's Max X Spawn"));
                //EditorGUILayout.Slider(sunsMinY_Prop, 0, 1000, new GUIContent("Sun's Min Y Spawn"));
                //EditorGUILayout.Slider(sunsMaxY_Prop, 0, 1000, new GUIContent("Sun's Max Y Spawn"));
                //EditorGUILayout.Slider(sunsMinZ_Prop, 0, 1000, new GUIContent("Sun's Min Z Spawn"));
                //EditorGUILayout.Slider(sunsMaxZ_Prop, 0, 1000, new GUIContent("Sun's Max Z Spawn"));
                //EditorGUILayout.Slider(sunMinRotationSpeed_Prop, 0, 1000, new GUIContent("Sun's Min Rotation Speed"));
                //EditorGUILayout.Slider(sunMaxRotationSpeed_Prop, 0, 1000, new GUIContent("Sun's Max Rotation Speed"));
                break;

            case SpawnManager.Status.OneTimeSpawn:
                //EditorGUILayout.Slider(planetSpeed_Prop, 0, 1000, new GUIContent("Planet's Speed"));
                //EditorGUILayout.Slider(planetMinSize_Prop, 0, 1000, new GUIContent("Planet's Min Size"));
                //EditorGUILayout.Slider(planetMaxSize_Prop, 0, 1000, new GUIContent("Planet's Max Size"));
                //EditorGUILayout.Slider(planetsMinX_Prop, 0, 1000, new GUIContent("Planet's Min X Spawn"));
                //EditorGUILayout.Slider(planetsMaxX_Prop, 0, 1000, new GUIContent("Planet's Max X Spawn"));
                //EditorGUILayout.Slider(planetsMinY_Prop, 0, 1000, new GUIContent("Planet's Min Y Spawn"));
                //EditorGUILayout.Slider(planetsMaxY_Prop, 0, 1000, new GUIContent("Planet's Max Y Spawn"));
                //EditorGUILayout.Slider(planetsMinZ_Prop, 0, 1000, new GUIContent("Planet's Min Z Spawn"));
                //EditorGUILayout.Slider(planetsMaxZ_Prop, 0, 1000, new GUIContent("Planet's Max Z Spawn"));
                //EditorGUILayout.Slider(planetsMinRotationSpeed_Prop, 0, 1000, new GUIContent("Planet's Min Rotation Speed"));
                //EditorGUILayout.Slider(planetsMaxRotationSpeed_Prop, 0, 1000, new GUIContent("Planet's Max Rotation Speed"));
                break;

            case SpawnManager.Status.SurviveForTime:
                //EditorGUILayout.Slider(moonSpeed_Prop, 0, 1000, new GUIContent("Moon's Speed"));
                //EditorGUILayout.Slider(moonMinSize_Prop, 0, 1000, new GUIContent("Moon's Min Size"));
                //EditorGUILayout.Slider(moonMaxSize_Prop, 0, 1000, new GUIContent("Moon's Max Size"));
                //EditorGUILayout.Slider(moonsMinX_Prop, 0, 1000, new GUIContent("Moon's Min X Spawn"));
                //EditorGUILayout.Slider(moonsMaxX_Prop, 0, 1000, new GUIContent("Moon's Max X Spawn"));
                //EditorGUILayout.Slider(moonsMinY_Prop, 0, 1000, new GUIContent("Moon's Min Y Spawn"));
                //EditorGUILayout.Slider(moonsMaxY_Prop, 0, 1000, new GUIContent("Moon's Max Y Spawn"));
                //EditorGUILayout.Slider(moonsMinZ_Prop, 0, 1000, new GUIContent("Moon's Min Z Spawn"));
                //EditorGUILayout.Slider(moonsMaxZ_Prop, 0, 1000, new GUIContent("Moon's Max Z Spawn"));
                //EditorGUILayout.Slider(moonMinRotationSpeed_Prop, 0, 1000, new GUIContent("Moon's Min Rotation Speed"));
                //EditorGUILayout.Slider(moonMaxRotationSpeed_Prop, 0, 1000, new GUIContent("Moon's Max Rotation Speed"));
                break;
        }
        serializedObject.ApplyModifiedProperties();
        EditorGUIUtility.LookLikeControls();
    }
}

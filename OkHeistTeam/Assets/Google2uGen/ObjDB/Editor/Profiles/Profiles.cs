using UnityEngine;
using UnityEditor;

namespace Google2u
{
	[CustomEditor(typeof(Profiles))]
	public class ProfilesEditor : Editor
	{
		public int Index = 0;
		public override void OnInspectorGUI ()
		{
			Profiles s = target as Profiles;
			ProfilesRow r = s.Rows[ Index ];

			EditorGUILayout.BeginHorizontal();
			if ( GUILayout.Button("<<") )
			{
				Index = 0;
			}
			if ( GUILayout.Button("<") )
			{
				Index -= 1;
				if ( Index < 0 )
					Index = s.Rows.Count - 1;
			}
			if ( GUILayout.Button(">") )
			{
				Index += 1;
				if ( Index >= s.Rows.Count )
					Index = 0;
			}
			if ( GUILayout.Button(">>") )
			{
				Index = s.Rows.Count - 1;
			}

			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "ID", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.LabelField( s.rowNames[ Index ] );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Name", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Name );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Like_Text", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Like_Text );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Dislike_Text", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Dislike_Text );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Skills_Text", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Skills_Text );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Description", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Description );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Skill_ID_1", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Skill_ID_1 );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Skill_ID_2", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Skill_ID_2 );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Skill_ID_3", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Skill_ID_3 );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Like_ID_1", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Like_ID_1 );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Idle_ID_2", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Idle_ID_2 );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Idle_ID_3", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Idle_ID_3 );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Dislile_ID_1", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Dislile_ID_1 );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Dislile_ID_2", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Dislile_ID_2 );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_Dislile_ID_3", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._Dislile_ID_3 );
			}
			EditorGUILayout.EndHorizontal();

		}
	}
}

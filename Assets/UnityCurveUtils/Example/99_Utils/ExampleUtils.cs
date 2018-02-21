using UnityEngine;

public static class ExampleUtils
{
	public static float Item( string text, float value )
	{
		GUILayout.BeginHorizontal();
		GUILayout.Label( text );
		value = GUILayout.HorizontalSlider( value, -1, 1, GUILayout.Width( 200 ) );
		GUILayout.Label( value.ToString( "0.00" ) );
		GUILayout.EndHorizontal();
		return value;
	}

	public static float Item2( string text, float value )
	{
		GUILayout.BeginHorizontal();
		GUILayout.Label( text );
		value = GUILayout.HorizontalSlider( value, 0, 5, GUILayout.Width( 200 ) );
		GUILayout.Label( value.ToString( "0.00" ) );
		GUILayout.EndHorizontal();
		return value;
	}
}
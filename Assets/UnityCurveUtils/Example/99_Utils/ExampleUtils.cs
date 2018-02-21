using UnityEngine;

namespace UnityCurveUtils_Example
{
	public static class ExampleUtils
	{
		public static float PosField( string text, float value )
		{
			return FieldImpl( text, value, -5, 5 );
		}

		public static float ParamField( string text, float value )
		{
			return FieldImpl( text, value, -1, 1 );
		}

		public static float ScaleField( string text, float value )
		{
			return FieldImpl( text, value, 0, 5 );
		}

		private static float FieldImpl( string text, float value, float min, float max )
		{
			GUILayout.BeginHorizontal();
			GUILayout.Label( text );
			value = GUILayout.HorizontalSlider( value, min, max, GUILayout.Width( 200 ) );
			GUILayout.Label( value.ToString( "0.00" ) );
			GUILayout.EndHorizontal();
			return value;
		}
	}
}
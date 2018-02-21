using System.Linq;
using UnityEngine;

/// <summary>
/// リサージュ曲線のサンプル
/// </summary>
public class Example_LissajousCurve : MonoBehaviour
{
	public LineRenderer lineRenderer;

	[Range( -5, 5 )] public float m_A;
	[Range( -5, 5 )] public float m_B;
	[Range( -5, 5 )] public float m_a;
	[Range( -5, 5 )] public float m_b;
	[Range( -5, 5 )] public float m_delta;

	private void Update()
	{
		var positions = Enumerable
			.Range( 0, 500 )
			.Select( c => UnityCurveUtils.LissajousCurve( m_A, m_B, m_a, m_b, m_delta, c / 10f ) )
			.Select( c => new Vector3( c.x, c.y ) )
			.ToArray()
		;

		lineRenderer.positionCount = positions.Length;
		lineRenderer.SetPositions( positions );
	}

	private void OnGUI()
	{
		m_A = GUILayout.HorizontalSlider( m_A, -2, 2, GUILayout.Width( 100 ) );
		m_B = GUILayout.HorizontalSlider( m_B, -2, 2, GUILayout.Width( 100 ) );
		m_a = GUILayout.HorizontalSlider( m_a, -2, 2, GUILayout.Width( 100 ) );
		m_b = GUILayout.HorizontalSlider( m_b, -2, 2, GUILayout.Width( 100 ) );
		m_delta = GUILayout.HorizontalSlider( m_delta, -2, 2, GUILayout.Width( 100 ) );
	}
}

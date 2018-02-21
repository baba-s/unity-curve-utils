using System.Linq;
using UnityEngine;

/// <summary>
/// コンコイドのサンプル
/// </summary>
public class Example_Conchoid : MonoBehaviour
{
	public LineRenderer lineRenderer;

	[Range( -5, 5 )] public float m_a;
	[Range( -5, 5 )] public float m_l;

	private void Update()
	{
		var positions = Enumerable
			.Range( 0, 500 )
			.Select( c => UnityCurveUtils.Conchoid( m_a, m_l, ( c - 250 ) / 10f ) )
			.Select( c => new Vector3( c.x, c.y ) )
			.ToArray()
		;

		lineRenderer.positionCount = positions.Length;
		lineRenderer.SetPositions( positions );
	}

	private void OnGUI()
	{
		m_a = GUILayout.HorizontalSlider( m_a, -2, 2, GUILayout.Width( 100 ) );
		m_l = GUILayout.HorizontalSlider( m_l, -2, 2, GUILayout.Width( 100 ) );
	}
}

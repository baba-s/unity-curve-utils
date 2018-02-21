using System.Linq;
using UnityEngine;

/// <summary>
/// サイクロイドのサンプル
/// </summary>
public class Example_Cycloid : MonoBehaviour
{
	public LineRenderer lineRenderer;
	public float m_scale;

	[Range( -5, 5 )] public float m_rm;

	private void Update()
	{
		var positions = Enumerable
			.Range( 0, 500 )
			.Select( c => UnityCurveUtils.Cycloid( m_rm, ( c - 250 ) / 10f ) )
			.Select( c => new Vector3( c.x, c.y ) * m_scale )
			.ToArray()
		;

		lineRenderer.positionCount = positions.Length;
		lineRenderer.SetPositions( positions );
	}

	private void OnGUI()
	{
		m_rm = ExampleUtils.Item( "動円の半径", m_rm );
		m_scale = ExampleUtils.Item2( "大きさ", m_scale );
	}
}

using System.Linq;
using UnityEngine;

/// <summary>
/// 内サイクロイドのサンプル
/// </summary>
public class Example_Hypocycloid : MonoBehaviour
{
	public LineRenderer lineRenderer;
	public float m_scale;

	[Range( -1, 1 )] public float m_rd;
	[Range( -1, 1 )] public float m_rm;

	private void Update()
	{
		var positions = Enumerable
			.Range( 0, 500 )
			.Select( c => UnityCurveUtils.Hypocycloid( m_rm, m_rd, c / 10f ) )
			.Select( c => new Vector3( c.x, c.y ) * m_scale )
			.ToArray()
		;

		lineRenderer.positionCount = positions.Length;
		lineRenderer.SetPositions( positions );
	}

	private void OnGUI()
	{
		m_rm = ExampleUtils.Item( "定円の半径", m_rm );
		m_rd = ExampleUtils.Item( "動円の半径", m_rd );
		m_scale = ExampleUtils.Item2( "大きさ", m_scale );
	}
}

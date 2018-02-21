using System.Linq;
using UnityEngine;

namespace UnityCurveUtils_Example
{
	/// <summary>
	/// ベジェ曲線のサンプル
	/// </summary>
	internal class Example_BezierCurve : MonoBehaviour
	{
		public LineRenderer lineRenderer = null;

		[Range( -5, 5 )] public float m_x1;
		[Range( -5, 5 )] public float m_y1;
		[Range( -5, 5 )] public float m_x2;
		[Range( -5, 5 )] public float m_y2;
		[Range( -5, 5 )] public float m_x3;
		[Range( -5, 5 )] public float m_y3;
		[Range( -5, 5 )] public float m_x4;
		[Range( -5, 5 )] public float m_y4;

		private void Update()
		{
			var positions = Enumerable
				.Range( 0, 500 )
				.Select( c => UnityCurveUtils.BezierCurve( m_x1, m_y1, m_x2, m_y2, m_x3, m_y3, m_x4, m_y4, c / 500f ) )
				.Select( c => new Vector3( c.x, c.y ) )
				.ToArray()
			;

			lineRenderer.positionCount = positions.Length;
			lineRenderer.SetPositions( positions );
		}

		private void OnGUI()
		{
			m_x1 = ExampleUtils.PosField( "始点の X 座標", m_x1 );
			m_y1 = ExampleUtils.PosField( "始点の Y 座標", m_y1 );
			m_x2 = ExampleUtils.PosField( "制御点1 の X 座標", m_x2 );
			m_y2 = ExampleUtils.PosField( "制御点1 の Y 座標", m_y2 );
			m_x3 = ExampleUtils.PosField( "制御点2 の X 座標", m_x3 );
			m_y3 = ExampleUtils.PosField( "制御点2 の Y 座標", m_y3 );
			m_x4 = ExampleUtils.PosField( "終点の X 座標", m_x4 );
			m_y4 = ExampleUtils.PosField( "終点の Y 座標", m_y4 );
		}
	}
}
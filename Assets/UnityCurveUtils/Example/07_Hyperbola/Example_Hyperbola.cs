using System.Linq;
using UnityEngine;

namespace UnityCurveUtils_Example
{
	/// <summary>
	/// 双曲線のサンプル
	/// </summary>
	internal class Example_Hyperbola : MonoBehaviour
	{
		public LineRenderer lineRenderer = null;

		[Range( -5, 5 )] public float m_a;
		[Range( -5, 5 )] public float m_b;

		private void Update()
		{
			var positions = Enumerable
				.Range( 0, 500 )
				.Select( c => UnityCurveUtils.Hyperbola( m_a, m_b, ( c - 250 ) / 10f ) )
				.Select( c => new Vector3( c.x, c.y ) )
				.ToArray()
			;

			lineRenderer.positionCount = positions.Length;
			lineRenderer.SetPositions( positions );
		}

		private void OnGUI()
		{
			m_a = GUILayout.HorizontalSlider( m_a, -2, 2, GUILayout.Width( 100 ) );
			m_b = GUILayout.HorizontalSlider( m_b, -2, 2, GUILayout.Width( 100 ) );
		}
	}
}
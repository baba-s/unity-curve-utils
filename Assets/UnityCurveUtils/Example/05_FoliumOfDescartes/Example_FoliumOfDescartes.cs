using System.Linq;
using UnityEngine;

namespace UnityCurveUtils_Example
{
	/// <summary>
	/// デカルトの正葉線のサンプル
	/// </summary>
	internal class Example_FoliumOfDescartes : MonoBehaviour
	{
		public LineRenderer lineRenderer = null;

		[Range( -5, 5 )] public float m_a;

		private void Update()
		{
			var positions = Enumerable
				.Range( 0, 500 )
				.Select( c => UnityCurveUtils.FoliumOfDescartes( m_a, ( c - 250 ) / 10f ) )
				.Select( c => new Vector3( c.x, c.y ) )
				.ToArray()
			;

			lineRenderer.positionCount = positions.Length;
			lineRenderer.SetPositions( positions );
		}

		private void OnGUI()
		{
			m_a = GUILayout.HorizontalSlider( m_a, -2, 2, GUILayout.Width( 100 ) );
		}
	}
}
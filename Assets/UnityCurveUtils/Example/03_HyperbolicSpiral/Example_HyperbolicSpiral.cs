﻿using System.Linq;
using UnityEngine;

/// <summary>
/// 双曲螺旋のサンプル
/// </summary>
public class Example_HyperbolicSpiral : MonoBehaviour
{
	public LineRenderer lineRenderer;

	[Range( -5, 5 )] public float m_a;

	private void Update()
	{
		var positions = Enumerable
			.Range( 0, 500 )
			.Select( c => UnityCurveUtils.HyperbolicSpiral( m_a, c / 10f ) )
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
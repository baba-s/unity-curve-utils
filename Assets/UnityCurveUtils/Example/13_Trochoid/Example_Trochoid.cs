﻿using System.Linq;
using UnityEngine;

namespace UnityCurveUtils_Example
{
	/// <summary>
	/// トロコイドのサンプル
	/// </summary>
	internal class Example_Trochoid : MonoBehaviour
	{
		public LineRenderer lineRenderer = null;
		public float m_scale;

		[Range( -5, 5 )] public float m_rm;
		[Range( -5, 5 )] public float m_rd;

		private void Update()
		{
			var positions = Enumerable
				.Range( 0, 500 )
				.Select( c => UnityCurveUtils.Trochoid( m_rm, ( c - 250 ) / 10f, m_rd ) )
				.Select( c => new Vector3( c.x, c.y ) * m_scale )
				.ToArray()
			;

			lineRenderer.positionCount = positions.Length;
			lineRenderer.SetPositions( positions );
		}

		private void OnGUI()
		{
			m_rm = ExampleUtils.ParamField( "動円の半径", m_rm );
			m_rd = ExampleUtils.ParamField( "描画点の半径", m_rd );
			m_scale = ExampleUtils.ScaleField( "大きさ", m_scale );
		}
	}
}
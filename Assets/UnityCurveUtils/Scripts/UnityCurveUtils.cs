using UnityEngine;

public static class UnityCurveUtils
{
	/// <summary>
	/// B-スプライン曲線を求めます
	/// </summary>
	public static float B_SplineCurveX( float x1, float y1, float x2, float y2, float x3, float y3, float t )
	{
		return Mathf.Pow( ( 1 - t ), 2 ) * x1 + 2 * t * ( 1 - t ) * x2 + Mathf.Pow( t, 2 ) * x3;
	}

	/// <summary>
	/// B-スプライン曲線を求めます
	/// </summary>
	public static float B_SplineCurveY( float x1, float y1, float x2, float y2, float x3, float y3, float t )
	{
		return Mathf.Pow( ( 1 - t ), 2 ) * y1 + 2 * t * ( 1 - t ) * y2 + Mathf.Pow( t, 2 ) * y3;
	}

	/// <summary>
	/// B-スプライン曲線を求めます
	/// </summary>
	public static Vector2 B_SplineCurve( float x1, float y1, float x2, float y2, float x3, float y3, float t )
	{
		return new Vector2(
			B_SplineCurveX( x1, y1, x2, y2, x3, y3, t ),
			B_SplineCurveY( x1, y1, x2, y2, x3, y3, t )
		);
	}

	/// <summary>
	/// ベジェ曲線を求めます
	/// </summary>
	public static float BezierCurveX( float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, float t )
	{
		return Mathf.Pow( ( 1 - t ), 3 ) * x1 + 3 * Mathf.Pow( ( 1 - t ), 2 ) * t * x2 + 3 * ( 1 - t ) * Mathf.Pow( t, 2 ) * x3 + Mathf.Pow( t, 3 ) * x4;
	}

	/// <summary>
	/// ベジェ曲線を求めます
	/// </summary>
	public static float BezierCurveY( float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, float t )
	{
		return Mathf.Pow( ( 1 - t ), 3 ) * y1 + 3 * Mathf.Pow( ( 1 - t ), 2 ) * t * y2 + 3 * ( 1 - t ) * Mathf.Pow( t, 2 ) * y3 + Mathf.Pow( t, 3 ) * y4;
	}

	/// <summary>
	/// ベジェ曲線を求めます
	/// </summary>
	public static Vector2 BezierCurve( float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, float t )
	{
		return new Vector2(
			BezierCurveX( x1, y1, x2, y2, x3, y3, x4, y4, t ),
			BezierCurveY( x1, y1, x2, y2, x3, y3, x4, y4, t )
		);
	}

	/// <summary>
	/// 双曲螺旋を求めます
	/// </summary>
	public static float HyperbolicSpiralX( float a, float theta )
	{
		return ( a * Mathf.Cos( theta ) ) / theta;
	}

	/// <summary>
	/// 双曲螺旋を求めます
	/// </summary>
	public static float HyperbolicSpiralY( float a, float theta )
	{
		return ( a * Mathf.Sin( theta ) ) / theta;
	}

	/// <summary>
	/// 双曲螺旋を求めます
	/// </summary>
	public static Vector2 HyperbolicSpiral( float a, float theta )
	{
		return new Vector2(
			HyperbolicSpiralX( a, theta ),
			HyperbolicSpiralY( a, theta )
		);
	}

	/// <summary>
	/// アーネシの曲線を求めます
	/// </summary>
	public static float WitchOfAgnesiX( float a, float theta )
	{
		return a * theta;
	}

	/// <summary>
	/// アーネシの曲線を求めます
	/// </summary>
	public static float WitchOfAgnesiY( float a, float theta )
	{
		return a / ( Mathf.Pow( theta, 2 ) + 1 );
	}

	/// <summary>
	/// アーネシの曲線を求めます
	/// </summary>
	public static Vector2 WitchOfAgnesi( float a, float theta )
	{
		return new Vector2(
			WitchOfAgnesiX( a, theta ),
			WitchOfAgnesiY( a, theta )
		);
	}

	/// <summary>
	/// デカルトの正葉線を求めます
	/// </summary>
	public static float FoliumOfDescartesX( float a, float theta )
	{
		return ( 3 * a * theta ) / 1 + Mathf.Pow( theta, 3 );
	}

	/// <summary>
	/// デカルトの正葉線を求めます
	/// </summary>
	public static float FoliumOfDescartesY( float a, float theta )
	{
		return ( 3 * a * Mathf.Pow( theta, 2 ) ) / 1 + Mathf.Pow( theta, 3 );
	}

	/// <summary>
	/// デカルトの正葉線を求めます
	/// </summary>
	public static Vector2 FoliumOfDescartes( float a, float theta )
	{
		return new Vector2(
			FoliumOfDescartesX( a, theta ),
			FoliumOfDescartesY( a, theta )
		);
	}

	////-----------------------------------------------------------------------------
	//// 双曲線を求める
	////-----------------------------------------------------------------------------
	//public static float HyperbolaX( float a, float b, float theta )
	//{
	//	return a * cosh( theta );
	//}

	//public static float HyperbolaY( float a, float b, float theta )
	//{
	//	return b * sinh( theta );
	//}

	//public static Vector2 Hyperbola2( float a, float b, float theta )
	//{
	//	return new Vector2(
	//		HyperbolaX( a, b, theta ),
	//		HyperbolaY( a, b, theta ) );
	//}

	/// <summary>
	/// 楕円を求めます
	/// </summary>
	public static float EllipseX( float a, float b, float theta )
	{
		return a * Mathf.Cos( theta );
	}

	/// <summary>
	/// 楕円を求めます
	/// </summary>
	public static float EllipseY( float a, float b, float theta )
	{
		return b * Mathf.Sin( theta );
	}

	/// <summary>
	/// 楕円を求めます
	/// </summary>
	public static Vector2 Ellipse( float a, float b, float theta )
	{
		return new Vector2(
			EllipseX( a, b, theta ),
			EllipseY( a, b, theta )
		);
	}

	/// <summary>
	/// インボリュート曲線を求めます
	/// </summary>
	public static float InvoluteOfCircleX( float a, float theta )
	{
		return a * ( Mathf.Cos( theta ) + theta * Mathf.Sin( theta ) );
	}

	/// <summary>
	/// インボリュート曲線を求めます
	/// </summary>
	public static float InvoluteOfCircleY( float a, float theta )
	{
		return a * ( Mathf.Sin( theta ) - theta * Mathf.Cos( theta ) );
	}

	/// <summary>
	/// インボリュート曲線を求めます
	/// </summary>
	public static Vector2 InvoluteOfCircle( float a, float theta )
	{
		return new Vector2(
			InvoluteOfCircleX( a, theta ),
			InvoluteOfCircleY( a, theta )
		);
	}

	/// <summary>
	/// ストロフォイドを求めます
	/// </summary>
	public static float StrophoidX( float a, float theta )
	{
		return ( a * ( Mathf.Pow( theta, 2 ) - 1 ) ) / ( Mathf.Pow( theta, 2 ) + 1 );
	}

	/// <summary>
	/// ストロフォイドを求めます
	/// </summary>
	public static float StrophoidY( float a, float theta )
	{
		return ( a * theta * ( Mathf.Pow( theta, 2 ) - 1 ) ) / ( Mathf.Pow( theta, 2 ) + 1 );
	}

	/// <summary>
	/// ストロフォイドを求めます
	/// </summary>
	public static Vector2 Strophoid( float a, float theta )
	{
		return new Vector2(
			StrophoidX( a, theta ),
			StrophoidY( a, theta ) );
	}

	/// <summary>
	/// コンコイドを求めます
	/// </summary>
	public static float ConchoidX( float a, float l, float theta )
	{
		return a + l * Mathf.Cos( theta );
	}

	/// <summary>
	/// コンコイドを求めます
	/// </summary>
	public static float ConchoidY( float a, float l, float theta )
	{
		return a * Mathf.Tan( theta ) + l * Mathf.Sin( theta );
	}

	/// <summary>
	/// コンコイドを求めます
	/// </summary>
	public static Vector2 Conchoid( float a, float l, float theta )
	{
		return new Vector2(
			ConchoidX( a, l, theta ),
			ConchoidY( a, l, theta )
		);
	}

	/// <summary>
	/// シッソイドを求めます
	/// </summary>
	public static float CissoidX( float a, float theta )
	{
		return ( a * Mathf.Pow( theta, 2 ) ) / 1 + Mathf.Pow( theta, 2 );
	}

	/// <summary>
	/// シッソイドを求めます
	/// </summary>
	public static float CissoidY( float a, float theta )
	{
		return ( a * Mathf.Pow( theta, 3 ) ) / 1 + Mathf.Pow( theta, 2 );
	}

	/// <summary>
	/// シッソイドを求めます
	/// </summary>
	public static Vector2 Cissoid( float a, float theta )
	{
		return new Vector2(
			CissoidX( a, theta ),
			CissoidY( a, theta )
		);
	}

	/// <summary>
	/// リサジュー曲線を求めます
	/// </summary>
	public static float LissajousCurveX( float A, float B, float a, float b, float delta, float theta )
	{
		return A * Mathf.Cos( a * theta );
	}

	/// <summary>
	/// リサジュー曲線を求めます
	/// </summary>
	public static float LissajousCurveY( float A, float B, float a, float b, float delta, float theta )
	{
		return B * Mathf.Sin( b * theta + delta );
	}

	/// <summary>
	/// リサジュー曲線を求めます
	/// </summary>
	public static Vector2 LissajousCurve( float A, float B, float a, float b, float delta, float theta )
	{
		return new Vector2(
			LissajousCurveX( A, B, a, b, delta, theta ),
			LissajousCurveY( A, B, a, b, delta, theta )
		);
	}

	/// <summary>
	/// トロコイドを求めます
	/// </summary>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <param name="rd">描画点の半径</param>
	/// <returns>トロコイドの媒介変数</returns>
	public static float TrochoidX( float rm, float theta, float rd )
	{
		return rm * theta - rd * Mathf.Sin( theta );
	}

	/// <summary>
	/// トロコイドを求めます
	/// </summary>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <param name="rd">描画点の半径</param>
	/// <returns>トロコイドの媒介変数</returns>
	public static float TrochoidY( float rm, float theta, float rd )
	{
		return rm - rd * Mathf.Cos( theta );
	}

	/// <summary>
	/// トロコイドを求めます
	/// </summary>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <param name="rd">描画点の半径</param>
	/// <returns>トロコイドの媒介変数</returns>
	public static Vector2 Trochoid( float rm, float theta, float rd )
	{
		return new Vector2(
			TrochoidX( rm, theta, rd ),
			TrochoidY( rm, theta, rd )
		);
	}

	/// <summary>
	/// 外トロコイドを求めます
	/// </summary>
	/// <param name="rc">定円の半径</param>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <param name="rd">描画点の半径</param>
	/// <returns>外トロコイドの媒介変数</returns>
	public static float EpitrocoidX( float rc, float rm, float theta, float rd )
	{
		return ( rc + rm ) * Mathf.Cos( theta ) - rd * Mathf.Cos( ( rc + rm ) * theta / rm );
	}

	/// <summary>
	/// 外トロコイドを求めます
	/// </summary>
	/// <param name="rc">定円の半径</param>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <param name="rd">描画点の半径</param>
	/// <returns>外トロコイドの媒介変数</returns>
	public static float EpitrocoidY( float rc, float rm, float theta, float rd )
	{
		return ( rc + rm ) * Mathf.Sin( theta ) - rd * Mathf.Sin( ( rc + rm ) * theta / rm );
	}

	/// <summary>
	/// 外トロコイドを求めます
	/// </summary>
	/// <param name="rc">定円の半径</param>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <param name="rd">描画点の半径</param>
	/// <returns>外トロコイドの媒介変数</returns>
	public static Vector2 Epitrocoid( float rc, float rm, float theta, float rd )
	{
		return new Vector2(
			EpitrocoidX( rc, rm, theta, rd ),
			EpitrocoidY( rc, rm, theta, rd )
		);
	}

	/// <summary>
	/// 内トロコイドを求めます
	/// </summary>
	/// <param name="rc">定円の半径</param>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <param name="rd">描画点の半径</param>
	/// <returns>内トロコイドの媒介変数</returns>
	public static float HypetrocoidX( float rc, float rm, float theta, float rd )
	{
		return ( rc - rm ) * Mathf.Cos( theta ) + rd * Mathf.Cos( ( rc - rm ) * theta / rm );
	}

	/// <summary>
	/// 内トロコイドを求めます
	/// </summary>
	/// <param name="rc">定円の半径</param>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <param name="rd">描画点の半径</param>
	/// <returns>内トロコイドの媒介変数</returns>
	public static float HypetrocoidY( float rc, float rm, float theta, float rd )
	{
		return ( rc - rm ) * Mathf.Sin( theta ) - rd * Mathf.Sin( ( rc - rm ) * theta / rm );
	}

	/// <summary>
	/// 内トロコイドを求めます
	/// </summary>
	/// <param name="rc">定円の半径</param>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <param name="rd">描画点の半径</param>
	/// <returns>内トロコイドの媒介変数</returns>
	public static Vector2 Hypetrocoid( float rc, float rm, float theta, float rd )
	{
		return new Vector2(
			HypetrocoidX( rc, rm, theta, rd ),
			HypetrocoidY( rc, rm, theta, rd )
		);
	}

	/// <summary>
	/// サイクロイドを求めます
	/// </summary>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <returns>サイクロイドの媒介変数</returns>
	public static float CycloidX( float rm, float theta )
	{
		return rm * ( theta - Mathf.Sin( theta ) );
	}

	/// <summary>
	/// サイクロイドを求めます
	/// </summary>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <returns>サイクロイドの媒介変数</returns>
	public static float CycloidY( float rm, float theta )
	{
		return rm * ( 1 - Mathf.Cos( theta ) );
	}

	/// <summary>
	/// サイクロイドを求めます
	/// </summary>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <returns>サイクロイドの媒介変数</returns>
	public static Vector2 Cycloid( float rm, float theta )
	{
		return new Vector2(
			CycloidX( rm, theta ),
			CycloidY( rm, theta )
		);
	}

	/// <summary>
	/// 外サイクロイドを求めます
	/// </summary>
	/// <param name="rc">定円の半径</param>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <returns>外サイクロイドの媒介変数</returns>
	public static float EpicycloidX( float rc, float rm, float theta )
	{
		return ( rc + rm ) * Mathf.Cos( theta ) - rm * Mathf.Cos( ( rc + rm ) * theta / rm );
	}

	/// <summary>
	/// 外サイクロイドを求めます
	/// </summary>
	/// <param name="rc">定円の半径</param>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <returns>外サイクロイドの媒介変数</returns>
	public static float EpicycloidY( float rc, float rm, float theta )
	{
		return ( rc + rm ) * Mathf.Sin( theta ) - rm * Mathf.Sin( ( rc + rm ) * theta / rm );
	}

	/// <summary>
	/// 外サイクロイドを求めます
	/// </summary>
	/// <param name="rc">定円の半径</param>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <returns>外サイクロイドの媒介変数</returns>
	public static Vector2 Epicycloid( float rc, float rm, float theta )
	{
		return new Vector2(
			EpicycloidX( rc, rm, theta ),
			EpicycloidY( rc, rm, theta )
		);
	}

	/// <summary>
	/// 内サイクロイドを求めます
	/// </summary>
	/// <param name="rc">定円の半径</param>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <returns>内サイクロイドの媒介変数</returns>
	public static float HypocycloidX( float rc, float rm, float theta )
	{
		return ( rc - rm ) * Mathf.Cos( theta ) + rm * Mathf.Cos( ( rc - rm ) * theta / rm );
	}

	/// <summary>
	/// 内サイクロイドを求めます
	/// </summary>
	/// <param name="rc">定円の半径</param>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <returns>内サイクロイドの媒介変数</returns>
	public static float HypocycloidY( float rc, float rm, float theta )
	{
		return ( rc - rm ) * Mathf.Sin( theta ) - rm * Mathf.Sin( ( rc - rm ) * theta / rm );
	}

	/// <summary>
	/// 内サイクロイドを求めます
	/// </summary>
	/// <param name="rc">定円の半径</param>
	/// <param name="rm">動円の半径</param>
	/// <param name="theta">回転角</param>
	/// <returns>内サイクロイドの媒介変数</returns>
	public static Vector2 Hypocycloid( float rc, float rm, float theta )
	{
		return new Vector2(
			HypocycloidX( rc, rm, theta ),
			HypocycloidY( rc, rm, theta )
		);
	}
}
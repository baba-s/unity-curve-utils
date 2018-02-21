# UnityCurveUtils

「UnityCurveUtils」は 18 種類の曲線アルゴリズムを使用できるユーティリティです  

# 導入方法

1. 下記のページにアクセスして「UnityCurveUtils.unitypackage」をダウンロードします  
https://github.com/baba-s/unity-curve-utils/blob/master/UnityCurveUtils.unitypackage?raw=true
2. ダウンロードした「UnityCurveUtils.unitypackage」を Unity プロジェクトにインポートします  

# 曲線アルゴリズム一覧

## B-スプライン曲線

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/01_B_SplineCurve.png)

```cs
var point = UnityCurveUtils.B_SplineCurve( x1, y1, x2, y2, x3, y3, t );
```

## ベジェ曲線

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/02_BezierCurve.png)

```cs
var point = UnityCurveUtils.BezierCurve( x1, y1, x2, y2, x3, y3, x4, y4, t );
```

## 双曲螺旋

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/03_HyperbolicSpiral.png)

```cs
var point = UnityCurveUtils.HyperbolicSpiral( a, c theta );
```

## アーネシの曲線

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/04_WitchOfAgnesi.png)

```cs
var point = UnityCurveUtils.WitchOfAgnesi( a, theta );
```

## デカルトの正葉線

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/05_FoliumOfDescartes.png)

```cs
var point = UnityCurveUtils.FoliumOfDescartes( a, theta );
```

## 楕円

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/06_Ellipse.png)

```cs
var point = UnityCurveUtils.Ellipse( a, b, theta );
```

## 双曲線

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/07_Hyperbola.png)

```cs
var point = UnityCurveUtils.Hyperbola( a, b, theta );
```

## インボリュート曲線

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/08_InvoluteOfCircle.png)

```cs
var point = UnityCurveUtils.InvoluteOfCircle( a, theta );
```

## ストロフォイド

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/09_Strophoid.png)

```cs
var point = UnityCurveUtils.Strophoid( a, theta );
```

## コンコイド

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/10_Conchoid.png)

```cs
var point = UnityCurveUtils.Conchoid( a, l, theta );
```

## シッソイド

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/11_Cissoid.png)

```cs
var point = UnityCurveUtils.Cissoid( a, theta );
```

## リサジュー曲線

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/12_LissajousCurve.png)

```cs
var point = UnityCurveUtils.LissajousCurve( A, B, a, b, delta, theta );
```

## トロコイド

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/13_Trochoid.png)

```cs
var point = UnityCurveUtils.Trochoid( rm, theta, rd );
```

## 外トロコイド

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/14_Epitrocoid.png)

```cs
var point = UnityCurveUtils.Epitrocoid( rc, rm, theta, rd );
```

## 内トロコイド

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/15_Hypetrocoid.png)

```cs
var point = UnityCurveUtils.Hypetrocoid( rc, rm, theta, rd );
```

## サイクロイド

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/16_Cycloid.png)

```cs
var point = UnityCurveUtils.Cycloid( rm, theta );
```

## 外サイクロイド

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/17_Epicycloid.png)

```cs
var point = UnityCurveUtils.Epicycloid( rm, rd, theta );
```

## 内サイクロイド

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/18_Hypocycloid.png)

```cs
var point = UnityCurveUtils.Hypocycloid( rm, rd, theta );
```

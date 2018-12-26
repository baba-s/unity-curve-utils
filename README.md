[日本語の Readme はこちら](https://github.com/baba-s/unity-curve-utils/blob/master/README_JP.md)  

# UnityCurveUtils

A utility that can use 18 kinds of curve algorithm.  

## Version

- Unity 2018.3.0f2

## Example

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/00_Example.png)

An example of use of each curve algorithm is stored in "Example" folder.  

## Algorithm list

### B-Spline curve

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/01_B_SplineCurve.png)

```cs
var point = UnityCurveUtils.B_SplineCurve( x1, y1, x2, y2, x3, y3, t );
```

### Bezier curve

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/02_BezierCurve.png)

```cs
var point = UnityCurveUtils.BezierCurve( x1, y1, x2, y2, x3, y3, x4, y4, t );
```

### Hyperbolic spiral

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/03_HyperbolicSpiral.png)

```cs
var point = UnityCurveUtils.HyperbolicSpiral( a, c theta );
```

### Witch of agnesi

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/04_WitchOfAgnesi.png)

```cs
var point = UnityCurveUtils.WitchOfAgnesi( a, theta );
```

### Folium of descartes

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/05_FoliumOfDescartes.png)

```cs
var point = UnityCurveUtils.FoliumOfDescartes( a, theta );
```

### Ellipse

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/06_Ellipse.png)

```cs
var point = UnityCurveUtils.Ellipse( a, b, theta );
```

### Hyperbola

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/07_Hyperbola.png)

```cs
var point = UnityCurveUtils.Hyperbola( a, b, theta );
```

### Involute of circle

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/08_InvoluteOfCircle.png)

```cs
var point = UnityCurveUtils.InvoluteOfCircle( a, theta );
```

### Strophoid

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/09_Strophoid.png)

```cs
var point = UnityCurveUtils.Strophoid( a, theta );
```

### Conchoid

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/10_Conchoid.png)

```cs
var point = UnityCurveUtils.Conchoid( a, l, theta );
```

### Cissoid

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/11_Cissoid.png)

```cs
var point = UnityCurveUtils.Cissoid( a, theta );
```

### Lissajous curve

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/12_LissajousCurve.png)

```cs
var point = UnityCurveUtils.LissajousCurve( A, B, a, b, delta, theta );
```

### Trochoid

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/13_Trochoid.png)

```cs
var point = UnityCurveUtils.Trochoid( rm, theta, rd );
```

### Epitrocoid

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/14_Epitrocoid.png)

```cs
var point = UnityCurveUtils.Epitrocoid( rc, rm, theta, rd );
```

### Hypetrocoid

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/15_Hypetrocoid.png)

```cs
var point = UnityCurveUtils.Hypetrocoid( rc, rm, theta, rd );
```

### Cycloid

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/16_Cycloid.png)

```cs
var point = UnityCurveUtils.Cycloid( rm, theta );
```

### Epicycloid

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/17_Epicycloid.png)

```cs
var point = UnityCurveUtils.Epicycloid( rm, rd, theta );
```

### Hypocycloid

![](https://raw.githubusercontent.com/baba-s/unity-curve-utils/master/Screenshots/18_Hypocycloid.png)

```cs
var point = UnityCurveUtils.Hypocycloid( rm, rd, theta );
```

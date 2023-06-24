using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[CreateAssetMenu]
	public class ShapesConfig : ScriptableObject
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001C2")]
		public static ShapesConfig Instance
		{
			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x2A4A1B0", Offset = "0x2A487B0", VA = "0x182A4A1B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x2A4A320", Offset = "0x2A48920", VA = "0x182A4A320")]
		public ShapesConfig()
		{
		}

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x0")]
		private static ShapesConfig inst;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Whether or not to use HDR color pickers throughout Shapes (This does not affect performance in any way)")]
		public bool useHdrColorPickers;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x19")]
		[Tooltip("Whether or not to auto-detect and set up render pipeline")]
		public bool autoConfigureRenderPipeline;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x1A")]
		[Tooltip("GPU Instancing in immediate mode drawing means if you render lots of similar shapes consecutively, they will get batched into a single draw call. Generally you'll want this on, but there may be cases where the CPU and memory overhead of instancing isn't worth it, which might be the case if you never draw shapes of the same type consecutively")]
		public bool useImmediateModeInstancing;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("Default point density for polyline arcs and beziers in points per full turn\nIf set to 128, then it'll use 64 points for a 180° turn, 32 points for a 90° turn\n\n16 = curves are very jagged, clearly just a bunch of straight lines in a trenchcoat, except they forgot the trenchcoat\n32 = curves visibly have straight segments when looking close, but appear smooth at a quick glance. (trenchcoat is now on)\n64 = curves generally appear smooth, except at the very sharpest of turns. recommended value.\n128 = curves appear smooth in pretty much all cases, beyond this is pretty wild, but I mean, if you're a wild person then go for it\n")]
		public float polylineDefaultPointsPerTurn;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Default accuracy when calculating point density of bezier curves.\nThis is only used for bezier curves where you specify density rather than point count.\nIf you have mostly very simple bezier curves, you can leave this at 3.\nIf you have more complex curves, like those with widely separated control points squishing the curve,\nthen you should use at least 5 samples\n\n1 = ~12% margin of error. this is the minimum value! works for the simplest curves, but generally inaccurate\n2 = ~4% margin of error. this is recommended, good balance between accuracy and speed\n3 = ~2% margin of error\n4 = ~1% margin of error")]
		public int polylineBezierAngularSumAccuracy;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("If this is on, static properties set inside of Draw.Command will apply only within that draw command. This is usually more intuitive and convenient, but it does come with a slight processing overhead, so if you are running something very performance sensitive you might want to turn this off")]
		public bool pushPopStateInDrawCommands;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		public const string TOOLTIP_BOUNDS = "These settings are uh, very esoteric\n*if* you are having trouble with *many* shapes being drawn on screen at the same time,\nmaking the bounds smaller using this parameter might help you optimize your game\n\nThis is like, super technical, so please read every word very carefully below:\nThis value should be set so that *all* shapes using, for instance, the quad mesh (disc, line, rect, etc.),\ncan use *these specific bounds*, so that the bounds would encapsulate the entire shape.\nPractically, this means that these bounds should be set so that it can encapsulate the largest\nshape you have in your project. If this is set too low, larger shapes will pop in/out of existence\n\nThe purpose of this is to gain some benefit in culling, but still keep the benefits of instancing.\nBy default, size is set to a large value of 1 << 16 (65536), practically \"turning off\" frustum culling";

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		private const float VERY_LORGE_BOUNDS = 65536f;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("These settings are uh, very esoteric\n*if* you are having trouble with *many* shapes being drawn on screen at the same time,\nmaking the bounds smaller using this parameter might help you optimize your game\n\nThis is like, super technical, so please read every word very carefully below:\nThis value should be set so that *all* shapes using, for instance, the quad mesh (disc, line, rect, etc.),\ncan use *these specific bounds*, so that the bounds would encapsulate the entire shape.\nPractically, this means that these bounds should be set so that it can encapsulate the largest\nshape you have in your project. If this is set too low, larger shapes will pop in/out of existence\n\nThe purpose of this is to gain some benefit in culling, but still keep the benefits of instancing.\nBy default, size is set to a large value of 1 << 16 (65536), practically \"turning off\" frustum culling")]
		public float boundsSizeQuad;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("These settings are uh, very esoteric\n*if* you are having trouble with *many* shapes being drawn on screen at the same time,\nmaking the bounds smaller using this parameter might help you optimize your game\n\nThis is like, super technical, so please read every word very carefully below:\nThis value should be set so that *all* shapes using, for instance, the quad mesh (disc, line, rect, etc.),\ncan use *these specific bounds*, so that the bounds would encapsulate the entire shape.\nPractically, this means that these bounds should be set so that it can encapsulate the largest\nshape you have in your project. If this is set too low, larger shapes will pop in/out of existence\n\nThe purpose of this is to gain some benefit in culling, but still keep the benefits of instancing.\nBy default, size is set to a large value of 1 << 16 (65536), practically \"turning off\" frustum culling")]
		public float boundsSizeTriangle;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("These settings are uh, very esoteric\n*if* you are having trouble with *many* shapes being drawn on screen at the same time,\nmaking the bounds smaller using this parameter might help you optimize your game\n\nThis is like, super technical, so please read every word very carefully below:\nThis value should be set so that *all* shapes using, for instance, the quad mesh (disc, line, rect, etc.),\ncan use *these specific bounds*, so that the bounds would encapsulate the entire shape.\nPractically, this means that these bounds should be set so that it can encapsulate the largest\nshape you have in your project. If this is set too low, larger shapes will pop in/out of existence\n\nThe purpose of this is to gain some benefit in culling, but still keep the benefits of instancing.\nBy default, size is set to a large value of 1 << 16 (65536), practically \"turning off\" frustum culling")]
		public float boundsSizeSphere;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("These settings are uh, very esoteric\n*if* you are having trouble with *many* shapes being drawn on screen at the same time,\nmaking the bounds smaller using this parameter might help you optimize your game\n\nThis is like, super technical, so please read every word very carefully below:\nThis value should be set so that *all* shapes using, for instance, the quad mesh (disc, line, rect, etc.),\ncan use *these specific bounds*, so that the bounds would encapsulate the entire shape.\nPractically, this means that these bounds should be set so that it can encapsulate the largest\nshape you have in your project. If this is set too low, larger shapes will pop in/out of existence\n\nThe purpose of this is to gain some benefit in culling, but still keep the benefits of instancing.\nBy default, size is set to a large value of 1 << 16 (65536), practically \"turning off\" frustum culling")]
		public float boundsSizeTorus;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("These settings are uh, very esoteric\n*if* you are having trouble with *many* shapes being drawn on screen at the same time,\nmaking the bounds smaller using this parameter might help you optimize your game\n\nThis is like, super technical, so please read every word very carefully below:\nThis value should be set so that *all* shapes using, for instance, the quad mesh (disc, line, rect, etc.),\ncan use *these specific bounds*, so that the bounds would encapsulate the entire shape.\nPractically, this means that these bounds should be set so that it can encapsulate the largest\nshape you have in your project. If this is set too low, larger shapes will pop in/out of existence\n\nThe purpose of this is to gain some benefit in culling, but still keep the benefits of instancing.\nBy default, size is set to a large value of 1 << 16 (65536), practically \"turning off\" frustum culling")]
		public float boundsSizeCuboid;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("These settings are uh, very esoteric\n*if* you are having trouble with *many* shapes being drawn on screen at the same time,\nmaking the bounds smaller using this parameter might help you optimize your game\n\nThis is like, super technical, so please read every word very carefully below:\nThis value should be set so that *all* shapes using, for instance, the quad mesh (disc, line, rect, etc.),\ncan use *these specific bounds*, so that the bounds would encapsulate the entire shape.\nPractically, this means that these bounds should be set so that it can encapsulate the largest\nshape you have in your project. If this is set too low, larger shapes will pop in/out of existence\n\nThe purpose of this is to gain some benefit in culling, but still keep the benefits of instancing.\nBy default, size is set to a large value of 1 << 16 (65536), practically \"turning off\" frustum culling")]
		public float boundsSizeCone;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("These settings are uh, very esoteric\n*if* you are having trouble with *many* shapes being drawn on screen at the same time,\nmaking the bounds smaller using this parameter might help you optimize your game\n\nThis is like, super technical, so please read every word very carefully below:\nThis value should be set so that *all* shapes using, for instance, the quad mesh (disc, line, rect, etc.),\ncan use *these specific bounds*, so that the bounds would encapsulate the entire shape.\nPractically, this means that these bounds should be set so that it can encapsulate the largest\nshape you have in your project. If this is set too low, larger shapes will pop in/out of existence\n\nThe purpose of this is to gain some benefit in culling, but still keep the benefits of instancing.\nBy default, size is set to a large value of 1 << 16 (65536), practically \"turning off\" frustum culling")]
		public float boundsSizeCylinder;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("These settings are uh, very esoteric\n*if* you are having trouble with *many* shapes being drawn on screen at the same time,\nmaking the bounds smaller using this parameter might help you optimize your game\n\nThis is like, super technical, so please read every word very carefully below:\nThis value should be set so that *all* shapes using, for instance, the quad mesh (disc, line, rect, etc.),\ncan use *these specific bounds*, so that the bounds would encapsulate the entire shape.\nPractically, this means that these bounds should be set so that it can encapsulate the largest\nshape you have in your project. If this is set too low, larger shapes will pop in/out of existence\n\nThe purpose of this is to gain some benefit in culling, but still keep the benefits of instancing.\nBy default, size is set to a large value of 1 << 16 (65536), practically \"turning off\" frustum culling")]
		public float boundsSizeCapsule;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x48")]
		public int[] sphereDetail;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x50")]
		public Vector2Int[] torusDivsMinorMajor;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x58")]
		public int[] coneDivs;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x60")]
		public int[] cylinderDivs;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x68")]
		public int[] capsuleDivs;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Precision of the fragment shader output.\n\n[fixed4] 11 bit, cheap and very low precision output, range of –2 to +2 and 1/256th precision\n\n[half4] 16 bit, range of –60000 to +60000, with about 3 decimal digits of precision\n\n[float4] 32 bit, full floating point precision")]
		public ShapesConfig.FragOutputPrecision FRAG_OUTPUT_V4;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x74")]
		[Tooltip("[Off] Turns off local anti-aliasing\n\n[Medium] Approximate, usually good enough. This uses the approximate partial derivative of fwidth for anti-aliasing\n\n[High] Higher quality, mathematically correct. Primarily handles diagonals better as it uses more precise partial derivative calculations")]
		public ShapesConfig.LocalAAQuality LOCAL_ANTI_ALIASING_QUALITY;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("[Low] Direct barycentric interpolation of colors per vertex\n  • super cheap\n  • prone to triangular artifacts\n  • playstation 1 energy\n\n[Medium] Barycentric interpolation of UVs, bilinear interpolation in the fragment shader\n  • this gets you like 80% there\n  • most games settle here\n  • only use quality above this if you really need to\n  • or if you are as pretentious as me with colors\n\n[High2D] 2D only, Z plane only, inverse barycentric interpolation in the fragment shader based on vertex positions.\n  • mathematically correct\n  • ...when restricted to the XY plane\n  • numerically unstable otherwise\n  • utterly and completely broken on the X plane or the Y plane. like, it goes invisible and I don't even know why. I think we're dividing by 0 or something idk\n\n[High] Full 3D inverse barycentric interpolation in the fragment shader based on vertex positions.\n  • mathematically correct method\n  • ...when all points are planar\n  • skew quads use a best-fit 2D projection\n  • the shader gets like way more expensive but the colors are nice and you can look at it and go \"nice\"")]
		public ShapesConfig.QuadInterpolationQuality QUAD_INTERPOLATION_QUALITY;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x7C")]
		[Tooltip("Noots is a unit, in addition to Meters and Pixels, useful for resolution-independent sizing\nA noot is proportional to the shortest dimension of your resolution (note: this is unrelated to physical size)\n\nConverting noots to pixels:\nmin(res.x,res.y)*(noots/NAS)\nres = screen resolution\nNAS = noots across screen\n\nYou can specify how big a single noot is here, though, I recommended leaving it at the default value of 100\n\n1 = 1 noot is 100% of the screen\n50 = 1 noot is 50% of the screen\n100 = 1 noot is 1% of the screen (default)\n(100 is like vmin in CSS)")]
		public int NOOTS_ACROSS_SCREEN;

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x200007E")]
		public enum FragOutputPrecision
		{
			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400029F")]
			fixed4,
			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			half4,
			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			float4
		}

		// Token: 0x0200007F RID: 127
		[Token(Token = "0x200007F")]
		public enum LocalAAQuality
		{
			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			Off,
			// Token: 0x040002A4 RID: 676
			[Token(Token = "0x40002A4")]
			Medium,
			// Token: 0x040002A5 RID: 677
			[Token(Token = "0x40002A5")]
			High
		}

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000080")]
		public enum QuadInterpolationQuality
		{
			// Token: 0x040002A7 RID: 679
			[Token(Token = "0x40002A7")]
			Low,
			// Token: 0x040002A8 RID: 680
			[Token(Token = "0x40002A8")]
			Medium,
			// Token: 0x040002A9 RID: 681
			[Token(Token = "0x40002A9")]
			High2D,
			// Token: 0x040002AA RID: 682
			[Token(Token = "0x40002AA")]
			High
		}
	}
}

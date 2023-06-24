using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	internal struct DrawStyle
	{
		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		private const float DEFAULT_THICKNESS = 0.05f;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		private const ThicknessSpace DEFAULT_THICKNESS_SPACE = ThicknessSpace.Meters;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x0")]
		public static DrawStyle @default;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x0")]
		public RenderState renderState;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x28")]
		public Color color;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x38")]
		public ShapesBlendMode blendMode;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x3C")]
		public ScaleMode scaleMode;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x40")]
		public DetailLevel detailLevel;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x44")]
		public bool useDashes;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x48")]
		public DashStyle dashStyle;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x64")]
		public bool useGradients;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x68")]
		public GradientFill gradientFill;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0xB8")]
		public float radius;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0xBC")]
		public float thickness;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0xC0")]
		public ThicknessSpace thicknessSpace;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0xC4")]
		public ThicknessSpace radiusSpace;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0xC8")]
		public ThicknessSpace sizeSpace;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0xCC")]
		public LineEndCap lineEndCaps;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0xD0")]
		public LineGeometry lineGeometry;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0xD4")]
		public PolygonTriangulation polygonTriangulation;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0xD8")]
		public PolylineGeometry polylineGeometry;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0xDC")]
		public PolylineJoins polylineJoins;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0xE0")]
		public DiscGeometry discGeometry;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0xE4")]
		public int regularPolygonSideCount;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0xE8")]
		public RegularPolygonGeometry regularPolygonGeometry;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0xF0")]
		public TextStyle textStyle;
	}
}

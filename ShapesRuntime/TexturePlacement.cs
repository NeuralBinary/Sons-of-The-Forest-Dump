using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	internal static class TexturePlacement
	{
		// Token: 0x06000B86 RID: 2950 RVA: 0x0000470C File Offset: 0x0000290C
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x2A46390", Offset = "0x2A44990", VA = "0x182A46390")]
		internal static ValueTuple<Rect, Rect> Fit(Texture texture, Rect rect, TextureFillMode mode)
		{
			return default(ValueTuple<Rect, Rect>);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00004724 File Offset: 0x00002924
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x2A466C0", Offset = "0x2A44CC0", VA = "0x182A466C0")]
		internal static ValueTuple<Rect, Rect> Size(Texture texture, Vector2 c, float size, TextureSizeMode mode)
		{
			return default(ValueTuple<Rect, Rect>);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0000473C File Offset: 0x0000293C
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x2A46B10", Offset = "0x2A45110", VA = "0x182A46B10")]
		private static ValueTuple<Rect, Rect> FitWidth(Vector2 c, float w, float aspect)
		{
			return default(ValueTuple<Rect, Rect>);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00004754 File Offset: 0x00002954
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x2A46BC0", Offset = "0x2A451C0", VA = "0x182A46BC0")]
		private static ValueTuple<Rect, Rect> FitHeight(Vector2 c, float h, float aspect)
		{
			return default(ValueTuple<Rect, Rect>);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0000476C File Offset: 0x0000296C
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x2A46C70", Offset = "0x2A45270", VA = "0x182A46C70")]
		private static ValueTuple<Rect, Rect> FitRadius(Texture tex, Vector2 c, float r)
		{
			return default(ValueTuple<Rect, Rect>);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00004784 File Offset: 0x00002984
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x2A46DC0", Offset = "0x2A453C0", VA = "0x182A46DC0")]
		private static ValueTuple<Rect, Rect> SimpleRect(Vector2 c, float w, float h)
		{
			return default(ValueTuple<Rect, Rect>);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0000479C File Offset: 0x0000299C
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x2A46E90", Offset = "0x2A45490", VA = "0x182A46E90")]
		private static Rect RectCnt(float cx, float cy, float w, float h)
		{
			return default(Rect);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000047B4 File Offset: 0x000029B4
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x2A46ED0", Offset = "0x2A454D0", VA = "0x182A46ED0")]
		private static Rect RectCnt(Vector2 c, float w, float h)
		{
			return default(Rect);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000047CC File Offset: 0x000029CC
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x2A46F20", Offset = "0x2A45520", VA = "0x182A46F20")]
		private static ValueTuple<Rect, Rect> StretchToFill(Rect rect)
		{
			return default(ValueTuple<Rect, Rect>);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000047E4 File Offset: 0x000029E4
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x2A46FA0", Offset = "0x2A455A0", VA = "0x182A46FA0")]
		private static ValueTuple<Rect, Rect> ScaleToFit(Texture texture, Rect rect)
		{
			return default(ValueTuple<Rect, Rect>);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000047FC File Offset: 0x000029FC
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x2A47170", Offset = "0x2A45770", VA = "0x182A47170")]
		private static ValueTuple<Rect, Rect> ScaleAndCropToFill(Texture texture, Rect rect)
		{
			return default(ValueTuple<Rect, Rect>);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00004814 File Offset: 0x00002A14
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x2A472C0", Offset = "0x2A458C0", VA = "0x182A472C0")]
		private static ValueTuple<Rect, Rect> TexelSized(Texture texture, Vector2 center, float pixelsPerMeter)
		{
			return default(ValueTuple<Rect, Rect>);
		}

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Rect fitUvs;
	}
}

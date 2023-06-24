using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[Serializable]
	public struct PolylinePoint
	{
		// Token: 0x06000BEA RID: 3050 RVA: 0x00004A6C File Offset: 0x00002C6C
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x2A48720", Offset = "0x2A46D20", VA = "0x182A48720")]
		public static PolylinePoint operator +(PolylinePoint a, PolylinePoint b)
		{
			return default(PolylinePoint);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00004A84 File Offset: 0x00002C84
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x2A48800", Offset = "0x2A46E00", VA = "0x182A48800")]
		public static PolylinePoint operator *(PolylinePoint a, float b)
		{
			return default(PolylinePoint);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x2A488B0", Offset = "0x2A46EB0", VA = "0x182A488B0")]
		public static PolylinePoint operator *(float b, PolylinePoint a)
		{
			return default(PolylinePoint);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x2A489B0", Offset = "0x2A46FB0", VA = "0x182A489B0")]
		public static PolylinePoint Lerp(PolylinePoint a, PolylinePoint b, float t)
		{
			return default(PolylinePoint);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x2A48AC0", Offset = "0x2A470C0", VA = "0x182A48AC0")]
		public PolylinePoint(Vector3 point)
		{
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x2A48AF0", Offset = "0x2A470F0", VA = "0x182A48AF0")]
		public PolylinePoint(Vector2 point)
		{
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x2A48B40", Offset = "0x2A47140", VA = "0x182A48B40")]
		public PolylinePoint(Vector3 point, Color color)
		{
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x2A48B60", Offset = "0x2A47160", VA = "0x182A48B60")]
		public PolylinePoint(Vector2 point, Color color)
		{
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x2A48BA0", Offset = "0x2A471A0", VA = "0x182A48BA0")]
		public PolylinePoint(Vector3 point, Color color, float thickness)
		{
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x2A48BC0", Offset = "0x2A471C0", VA = "0x182A48BC0")]
		public PolylinePoint(Vector2 point, Color color, float thickness)
		{
		}

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 point;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0xC")]
		[ShapesColorField(true)]
		public Color color;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x1C")]
		public float thickness;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x020001BE RID: 446
	[Token(Token = "0x20001BE")]
	public struct AxisAlignedBox2f
	{
		// Token: 0x06000C0B RID: 3083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x2027730", Offset = "0x2025D30", VA = "0x182027730")]
		public AxisAlignedBox2f(bool bIgnore)
		{
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x2027760", Offset = "0x2025D60", VA = "0x182027760")]
		public AxisAlignedBox2f(float xmin, float ymin, float xmax, float ymax)
		{
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x2027780", Offset = "0x2025D80", VA = "0x182027780")]
		public AxisAlignedBox2f(float fSquareSize)
		{
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x20277A0", Offset = "0x2025DA0", VA = "0x1820277A0")]
		public AxisAlignedBox2f(float fWidth, float fHeight)
		{
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x20277C0", Offset = "0x2025DC0", VA = "0x1820277C0")]
		public AxisAlignedBox2f(Vector2f vMin, Vector2f vMax)
		{
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x20278C0", Offset = "0x2025EC0", VA = "0x1820278C0")]
		public AxisAlignedBox2f(Vector2f vCenter, float fHalfWidth, float fHalfHeight)
		{
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x2027900", Offset = "0x2025F00", VA = "0x182027900")]
		public AxisAlignedBox2f(Vector2f vCenter, float fHalfWidth)
		{
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x2027940", Offset = "0x2025F40", VA = "0x182027940")]
		public AxisAlignedBox2f(Vector2f vCenter)
		{
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x2027960", Offset = "0x2025F60", VA = "0x182027960")]
		public AxisAlignedBox2f(AxisAlignedBox2f o)
		{
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00008A74 File Offset: 0x00006C74
		[Token(Token = "0x17000212")]
		public float Width
		{
			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x2027990", Offset = "0x2025F90", VA = "0x182027990")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00008A8C File Offset: 0x00006C8C
		[Token(Token = "0x17000213")]
		public float Height
		{
			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x2027A20", Offset = "0x2026020", VA = "0x182027A20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00008AA4 File Offset: 0x00006CA4
		[Token(Token = "0x17000214")]
		public float Area
		{
			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x2027AB0", Offset = "0x20260B0", VA = "0x182027AB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00008ABC File Offset: 0x00006CBC
		[Token(Token = "0x17000215")]
		public float DiagonalLength
		{
			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x2027AF0", Offset = "0x20260F0", VA = "0x182027AF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x00008AD4 File Offset: 0x00006CD4
		[Token(Token = "0x17000216")]
		public float MaxDim
		{
			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x2027BC0", Offset = "0x20261C0", VA = "0x182027BC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00008AEC File Offset: 0x00006CEC
		[Token(Token = "0x17000217")]
		public Vector2f Diagonal
		{
			[Token(Token = "0x6000C19")]
			[Address(RVA = "0x2027C60", Offset = "0x2026260", VA = "0x182027C60")]
			get
			{
				return default(Vector2f);
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x00008B04 File Offset: 0x00006D04
		[Token(Token = "0x17000218")]
		public Vector2f Center
		{
			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x2027C80", Offset = "0x2026280", VA = "0x182027C80")]
			get
			{
				return default(Vector2f);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00008B1C File Offset: 0x00006D1C
		[Token(Token = "0x17000219")]
		public Vector2f BottomLeft
		{
			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0x633720", Offset = "0x631D20", VA = "0x180633720")]
			get
			{
				return default(Vector2f);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00008B34 File Offset: 0x00006D34
		[Token(Token = "0x1700021A")]
		public Vector2f BottomRight
		{
			[Token(Token = "0x6000C1C")]
			[Address(RVA = "0xAB2780", Offset = "0xAB0D80", VA = "0x180AB2780")]
			get
			{
				return default(Vector2f);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00008B4C File Offset: 0x00006D4C
		[Token(Token = "0x1700021B")]
		public Vector2f TopLeft
		{
			[Token(Token = "0x6000C1D")]
			[Address(RVA = "0xAB35B0", Offset = "0xAB1BB0", VA = "0x180AB35B0")]
			get
			{
				return default(Vector2f);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00008B64 File Offset: 0x00006D64
		[Token(Token = "0x1700021C")]
		public Vector2f TopRight
		{
			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0xAB35F0", Offset = "0xAB1BF0", VA = "0x180AB35F0")]
			get
			{
				return default(Vector2f);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00008B7C File Offset: 0x00006D7C
		[Token(Token = "0x1700021D")]
		public Vector2f CenterLeft
		{
			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0x2027CB0", Offset = "0x20262B0", VA = "0x182027CB0")]
			get
			{
				return default(Vector2f);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x00008B94 File Offset: 0x00006D94
		[Token(Token = "0x1700021E")]
		public Vector2f CenterRight
		{
			[Token(Token = "0x6000C20")]
			[Address(RVA = "0x2027CD0", Offset = "0x20262D0", VA = "0x182027CD0")]
			get
			{
				return default(Vector2f);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00008BAC File Offset: 0x00006DAC
		[Token(Token = "0x1700021F")]
		public Vector2f CenterTop
		{
			[Token(Token = "0x6000C21")]
			[Address(RVA = "0x2027CF0", Offset = "0x20262F0", VA = "0x182027CF0")]
			get
			{
				return default(Vector2f);
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x00008BC4 File Offset: 0x00006DC4
		[Token(Token = "0x17000220")]
		public Vector2f CenterBottom
		{
			[Token(Token = "0x6000C22")]
			[Address(RVA = "0x2027D10", Offset = "0x2026310", VA = "0x182027D10")]
			get
			{
				return default(Vector2f);
			}
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00008BDC File Offset: 0x00006DDC
		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x2027D30", Offset = "0x2026330", VA = "0x182027D30")]
		public Vector2f GetCorner(int i)
		{
			return default(Vector2f);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x2027D80", Offset = "0x2026380", VA = "0x182027D80")]
		public void Expand(float fRadius)
		{
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x2027DC0", Offset = "0x20263C0", VA = "0x182027DC0")]
		public void Contract(float fRadius)
		{
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x2027E00", Offset = "0x2026400", VA = "0x182027E00")]
		[Obsolete("This method name is confusing. Will remove in future. Use Add() instead")]
		public void Pad(float fPadLeft, float fPadRight, float fPadBottom, float fPadTop)
		{
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x2027E00", Offset = "0x2026400", VA = "0x182027E00")]
		public void Add(float left, float right, float bottom, float top)
		{
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x2027E30", Offset = "0x2026430", VA = "0x182027E30")]
		public void SetWidth(float fNewWidth, AxisAlignedBox2f.ScaleMode eScaleMode)
		{
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x2027F00", Offset = "0x2026500", VA = "0x182027F00")]
		public void SetHeight(float fNewHeight, AxisAlignedBox2f.ScaleMode eScaleMode)
		{
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x2027FD0", Offset = "0x20265D0", VA = "0x182027FD0")]
		public void Contain(Vector2f v)
		{
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x20280E0", Offset = "0x20266E0", VA = "0x1820280E0")]
		public void Contain(AxisAlignedBox2f box)
		{
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00008BF4 File Offset: 0x00006DF4
		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x2028200", Offset = "0x2026800", VA = "0x182028200")]
		public AxisAlignedBox2f Intersect(AxisAlignedBox2f box)
		{
			return default(AxisAlignedBox2f);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00008C0C File Offset: 0x00006E0C
		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x2028460", Offset = "0x2026A60", VA = "0x182028460")]
		public bool Contains(Vector2f v)
		{
			return default(bool);
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00008C24 File Offset: 0x00006E24
		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x20284A0", Offset = "0x2026AA0", VA = "0x1820284A0")]
		public bool Intersects(AxisAlignedBox2f box)
		{
			return default(bool);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00008C3C File Offset: 0x00006E3C
		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x20284D0", Offset = "0x2026AD0", VA = "0x1820284D0")]
		public float Distance(Vector2f v)
		{
			return 0f;
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x2028650", Offset = "0x2026C50", VA = "0x182028650")]
		public void Translate(Vector2f vTranslate)
		{
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x2028690", Offset = "0x2026C90", VA = "0x182028690")]
		public void MoveMin(Vector2f vNewMin)
		{
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x20286D0", Offset = "0x2026CD0", VA = "0x1820286D0")]
		public void MoveMin(float fNewX, float fNewY)
		{
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x2028700", Offset = "0x2026D00", VA = "0x182028700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00008C54 File Offset: 0x00006E54
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x2028900", Offset = "0x2026F00", VA = "0x182028900")]
		public static implicit operator AxisAlignedBox2f(Rect b)
		{
			return default(AxisAlignedBox2f);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00008C6C File Offset: 0x00006E6C
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x20289A0", Offset = "0x2026FA0", VA = "0x1820289A0")]
		public static implicit operator Rect(AxisAlignedBox2f b)
		{
			return default(Rect);
		}

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x0")]
		public Vector2f Min;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x8")]
		public Vector2f Max;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AxisAlignedBox2f Empty;

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x10")]
		public static readonly AxisAlignedBox2f Zero;

		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x20")]
		public static readonly AxisAlignedBox2f UnitPositive;

		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x30")]
		public static readonly AxisAlignedBox2f Infinite;

		// Token: 0x020001BF RID: 447
		[Token(Token = "0x20001BF")]
		public enum ScaleMode
		{
			// Token: 0x04000704 RID: 1796
			[Token(Token = "0x4000704")]
			ScaleRight,
			// Token: 0x04000705 RID: 1797
			[Token(Token = "0x4000705")]
			ScaleLeft,
			// Token: 0x04000706 RID: 1798
			[Token(Token = "0x4000706")]
			ScaleUp,
			// Token: 0x04000707 RID: 1799
			[Token(Token = "0x4000707")]
			ScaleDown,
			// Token: 0x04000708 RID: 1800
			[Token(Token = "0x4000708")]
			ScaleCenter
		}
	}
}

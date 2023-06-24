using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001C3 RID: 451
	[Token(Token = "0x20001C3")]
	public struct AxisAlignedBox3d : IComparable<AxisAlignedBox3d>, IEquatable<AxisAlignedBox3d>
	{
		// Token: 0x06000C75 RID: 3189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x202A330", Offset = "0x2028930", VA = "0x18202A330")]
		public AxisAlignedBox3d(bool bIgnore)
		{
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x202A370", Offset = "0x2028970", VA = "0x18202A370")]
		public AxisAlignedBox3d(double xmin, double ymin, double zmin, double xmax, double ymax, double zmax)
		{
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x202A3B0", Offset = "0x20289B0", VA = "0x18202A3B0")]
		public AxisAlignedBox3d(double fCubeSize)
		{
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x202A3E0", Offset = "0x20289E0", VA = "0x18202A3E0")]
		public AxisAlignedBox3d(double fWidth, double fHeight, double fDepth)
		{
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x202A410", Offset = "0x2028A10", VA = "0x18202A410")]
		public AxisAlignedBox3d(Vector3d vMin, Vector3d vMax)
		{
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x202A590", Offset = "0x2028B90", VA = "0x18202A590")]
		public AxisAlignedBox3d(ref Vector3d vMin, ref Vector3d vMax)
		{
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x202A720", Offset = "0x2028D20", VA = "0x18202A720")]
		public AxisAlignedBox3d(Vector3d vCenter, double fHalfWidth, double fHalfHeight, double fHalfDepth)
		{
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x202A7B0", Offset = "0x2028DB0", VA = "0x18202A7B0")]
		public AxisAlignedBox3d(ref Vector3d vCenter, double fHalfWidth, double fHalfHeight, double fHalfDepth)
		{
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x202A810", Offset = "0x2028E10", VA = "0x18202A810")]
		public AxisAlignedBox3d(Vector3d vCenter, double fHalfSize)
		{
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x202A870", Offset = "0x2028E70", VA = "0x18202A870")]
		public AxisAlignedBox3d(Vector3d vCenter)
		{
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00008F24 File Offset: 0x00007124
		[Token(Token = "0x1700022D")]
		public double Width
		{
			[Token(Token = "0x6000C7F")]
			[Address(RVA = "0x202A890", Offset = "0x2028E90", VA = "0x18202A890")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00008F3C File Offset: 0x0000713C
		[Token(Token = "0x1700022E")]
		public double Height
		{
			[Token(Token = "0x6000C80")]
			[Address(RVA = "0x202A930", Offset = "0x2028F30", VA = "0x18202A930")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x00008F54 File Offset: 0x00007154
		[Token(Token = "0x1700022F")]
		public double Depth
		{
			[Token(Token = "0x6000C81")]
			[Address(RVA = "0x202A9D0", Offset = "0x2028FD0", VA = "0x18202A9D0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00008F6C File Offset: 0x0000716C
		[Token(Token = "0x17000230")]
		public double Volume
		{
			[Token(Token = "0x6000C82")]
			[Address(RVA = "0x202AA70", Offset = "0x2029070", VA = "0x18202AA70")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00008F84 File Offset: 0x00007184
		[Token(Token = "0x17000231")]
		public double DiagonalLength
		{
			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x202AAC0", Offset = "0x20290C0", VA = "0x18202AAC0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00008F9C File Offset: 0x0000719C
		[Token(Token = "0x17000232")]
		public double MaxDim
		{
			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x202ABC0", Offset = "0x20291C0", VA = "0x18202ABC0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00008FB4 File Offset: 0x000071B4
		[Token(Token = "0x17000233")]
		public Vector3d Diagonal
		{
			[Token(Token = "0x6000C85")]
			[Address(RVA = "0x202ACA0", Offset = "0x20292A0", VA = "0x18202ACA0")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00008FCC File Offset: 0x000071CC
		[Token(Token = "0x17000234")]
		public Vector3d Extents
		{
			[Token(Token = "0x6000C86")]
			[Address(RVA = "0x202ACD0", Offset = "0x20292D0", VA = "0x18202ACD0")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00008FE4 File Offset: 0x000071E4
		[Token(Token = "0x17000235")]
		public Vector3d Center
		{
			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x202AD20", Offset = "0x2029320", VA = "0x18202AD20")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00008FFC File Offset: 0x000071FC
		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x202AD70", Offset = "0x2029370", VA = "0x18202AD70")]
		public static bool operator ==(AxisAlignedBox3d a, AxisAlignedBox3d b)
		{
			return default(bool);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00009014 File Offset: 0x00007214
		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x202AE90", Offset = "0x2029490", VA = "0x18202AE90")]
		public static bool operator !=(AxisAlignedBox3d a, AxisAlignedBox3d b)
		{
			return default(bool);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0000902C File Offset: 0x0000722C
		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x202AFB0", Offset = "0x20295B0", VA = "0x18202AFB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00009044 File Offset: 0x00007244
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x202B0B0", Offset = "0x20296B0", VA = "0x18202B0B0", Slot = "5")]
		public bool Equals(AxisAlignedBox3d other)
		{
			return default(bool);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0000905C File Offset: 0x0000725C
		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x202B180", Offset = "0x2029780", VA = "0x18202B180", Slot = "4")]
		public int CompareTo(AxisAlignedBox3d other)
		{
			return 0;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00009074 File Offset: 0x00007274
		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x202B280", Offset = "0x2029880", VA = "0x18202B280", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0000908C File Offset: 0x0000728C
		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x202B2C0", Offset = "0x20298C0", VA = "0x18202B2C0")]
		public Vector3d Corner(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x000090A4 File Offset: 0x000072A4
		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x202B340", Offset = "0x2029940", VA = "0x18202B340")]
		public Vector3d Point(int xi, int yi, int zi)
		{
			return default(Vector3d);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x202B3D0", Offset = "0x20299D0", VA = "0x18202B3D0")]
		public void Expand(double fRadius)
		{
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x000090BC File Offset: 0x000072BC
		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x202B410", Offset = "0x2029A10", VA = "0x18202B410")]
		public AxisAlignedBox3d Expanded(double fRadius)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x202B470", Offset = "0x2029A70", VA = "0x18202B470")]
		public void Contract(double fRadius)
		{
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x000090D4 File Offset: 0x000072D4
		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x202B540", Offset = "0x2029B40", VA = "0x18202B540")]
		public AxisAlignedBox3d Contracted(double fRadius)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x202B620", Offset = "0x2029C20", VA = "0x18202B620")]
		public void Scale(double sx, double sy, double sz)
		{
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x202B730", Offset = "0x2029D30", VA = "0x18202B730")]
		public void Contain(Vector3d v)
		{
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x202B8C0", Offset = "0x2029EC0", VA = "0x18202B8C0")]
		public void Contain(ref Vector3d v)
		{
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x202BA40", Offset = "0x202A040", VA = "0x18202BA40")]
		public void Contain(AxisAlignedBox3d box)
		{
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x202BBD0", Offset = "0x202A1D0", VA = "0x18202BBD0")]
		public void Contain(ref AxisAlignedBox3d box)
		{
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x000090EC File Offset: 0x000072EC
		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x202BD50", Offset = "0x202A350", VA = "0x18202BD50")]
		public AxisAlignedBox3d Intersect(AxisAlignedBox3d box)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00009104 File Offset: 0x00007304
		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0x202C0F0", Offset = "0x202A6F0", VA = "0x18202C0F0")]
		public bool Contains(Vector3d v)
		{
			return default(bool);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0000911C File Offset: 0x0000731C
		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x202C150", Offset = "0x202A750", VA = "0x18202C150")]
		public bool Contains(ref Vector3d v)
		{
			return default(bool);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00009134 File Offset: 0x00007334
		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x202C1A0", Offset = "0x202A7A0", VA = "0x18202C1A0")]
		public bool Contains(AxisAlignedBox3d box2)
		{
			return default(bool);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0000914C File Offset: 0x0000734C
		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x202C1A0", Offset = "0x202A7A0", VA = "0x18202C1A0")]
		public bool Contains(ref AxisAlignedBox3d box2)
		{
			return default(bool);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00009164 File Offset: 0x00007364
		[Token(Token = "0x6000C9E")]
		[Address(RVA = "0x202C250", Offset = "0x202A850", VA = "0x18202C250")]
		public bool Intersects(AxisAlignedBox3d box)
		{
			return default(bool);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0000917C File Offset: 0x0000737C
		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x202C2B0", Offset = "0x202A8B0", VA = "0x18202C2B0")]
		public double DistanceSquared(Vector3d v)
		{
			return 0.0;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00009194 File Offset: 0x00007394
		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x202C360", Offset = "0x202A960", VA = "0x18202C360")]
		public double Distance(Vector3d v)
		{
			return 0.0;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000091AC File Offset: 0x000073AC
		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x202C410", Offset = "0x202AA10", VA = "0x18202C410")]
		public double SignedDistance(Vector3d v)
		{
			return 0.0;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000091C4 File Offset: 0x000073C4
		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x202C640", Offset = "0x202AC40", VA = "0x18202C640")]
		public double DistanceSquared(ref AxisAlignedBox3d box2)
		{
			return 0.0;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x202C820", Offset = "0x202AE20", VA = "0x18202C820")]
		public void Translate(Vector3d vTranslate)
		{
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x202C890", Offset = "0x202AE90", VA = "0x18202C890")]
		public void MoveMin(Vector3d vNewMin)
		{
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x202C8F0", Offset = "0x202AEF0", VA = "0x18202C8F0")]
		public void MoveMin(double fNewX, double fNewY, double fNewZ)
		{
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x202C940", Offset = "0x202AF40", VA = "0x18202C940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000091DC File Offset: 0x000073DC
		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x202CBF0", Offset = "0x202B1F0", VA = "0x18202CBF0")]
		public static implicit operator AxisAlignedBox3d(AxisAlignedBox3f v)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000091F4 File Offset: 0x000073F4
		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x202CD10", Offset = "0x202B310", VA = "0x18202CD10")]
		public static explicit operator AxisAlignedBox3f(AxisAlignedBox3d v)
		{
			return default(AxisAlignedBox3f);
		}

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x0")]
		public Vector3d Min;

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d Max;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AxisAlignedBox3d Empty;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x30")]
		public static readonly AxisAlignedBox3d Zero;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x60")]
		public static readonly AxisAlignedBox3d UnitPositive;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x90")]
		public static readonly AxisAlignedBox3d Infinite;
	}
}

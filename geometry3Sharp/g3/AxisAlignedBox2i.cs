using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	public struct AxisAlignedBox2i : IComparable<AxisAlignedBox2i>, IEquatable<AxisAlignedBox2i>
	{
		// Token: 0x06000C37 RID: 3127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x2028AC0", Offset = "0x20270C0", VA = "0x182028AC0")]
		public AxisAlignedBox2i(bool bIgnore)
		{
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x2028B00", Offset = "0x2027100", VA = "0x182028B00")]
		public AxisAlignedBox2i(int xmin, int ymin, int xmax, int ymax)
		{
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x2028B30", Offset = "0x2027130", VA = "0x182028B30")]
		public AxisAlignedBox2i(int fCubeSize)
		{
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x2028B50", Offset = "0x2027150", VA = "0x182028B50")]
		public AxisAlignedBox2i(int fWidth, int fHeight)
		{
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x2028B70", Offset = "0x2027170", VA = "0x182028B70")]
		public AxisAlignedBox2i(Vector2i vMin, Vector2i vMax)
		{
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x2028C10", Offset = "0x2027210", VA = "0x182028C10")]
		public AxisAlignedBox2i(Vector2i vCenter, int fHalfWidth, int fHalfHeight, int fHalfDepth)
		{
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x2028C50", Offset = "0x2027250", VA = "0x182028C50")]
		public AxisAlignedBox2i(Vector2i vCenter, int fHalfSize)
		{
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x1E70EB0", Offset = "0x1E6F4B0", VA = "0x181E70EB0")]
		public AxisAlignedBox2i(Vector2i vCenter)
		{
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00008C84 File Offset: 0x00006E84
		[Token(Token = "0x17000221")]
		public int Width
		{
			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0x2028C90", Offset = "0x2027290", VA = "0x182028C90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00008C9C File Offset: 0x00006E9C
		[Token(Token = "0x17000222")]
		public int Height
		{
			[Token(Token = "0x6000C40")]
			[Address(RVA = "0x2028CF0", Offset = "0x20272F0", VA = "0x182028CF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00008CB4 File Offset: 0x00006EB4
		[Token(Token = "0x17000223")]
		public int Area
		{
			[Token(Token = "0x6000C41")]
			[Address(RVA = "0x2028D50", Offset = "0x2027350", VA = "0x182028D50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00008CCC File Offset: 0x00006ECC
		[Token(Token = "0x17000224")]
		public int DiagonalLength
		{
			[Token(Token = "0x6000C42")]
			[Address(RVA = "0x2028E00", Offset = "0x2027400", VA = "0x182028E00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00008CE4 File Offset: 0x00006EE4
		[Token(Token = "0x17000225")]
		public int MaxDim
		{
			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x2028EA0", Offset = "0x20274A0", VA = "0x182028EA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00008CFC File Offset: 0x00006EFC
		[Token(Token = "0x17000226")]
		public Vector2i Diagonal
		{
			[Token(Token = "0x6000C44")]
			[Address(RVA = "0x2028F80", Offset = "0x2027580", VA = "0x182028F80")]
			get
			{
				return default(Vector2i);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x00008D14 File Offset: 0x00006F14
		[Token(Token = "0x17000227")]
		public Vector2i Extents
		{
			[Token(Token = "0x6000C45")]
			[Address(RVA = "0x2028FA0", Offset = "0x20275A0", VA = "0x182028FA0")]
			get
			{
				return default(Vector2i);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00008D2C File Offset: 0x00006F2C
		[Token(Token = "0x17000228")]
		public Vector2i Center
		{
			[Token(Token = "0x6000C46")]
			[Address(RVA = "0x2028FD0", Offset = "0x20275D0", VA = "0x182028FD0")]
			get
			{
				return default(Vector2i);
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00008D44 File Offset: 0x00006F44
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x2029000", Offset = "0x2027600", VA = "0x182029000")]
		public static bool operator ==(AxisAlignedBox2i a, AxisAlignedBox2i b)
		{
			return default(bool);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00008D5C File Offset: 0x00006F5C
		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x20290C0", Offset = "0x20276C0", VA = "0x1820290C0")]
		public static bool operator !=(AxisAlignedBox2i a, AxisAlignedBox2i b)
		{
			return default(bool);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00008D74 File Offset: 0x00006F74
		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x2029180", Offset = "0x2027780", VA = "0x182029180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00008D8C File Offset: 0x00006F8C
		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x2029290", Offset = "0x2027890", VA = "0x182029290", Slot = "5")]
		public bool Equals(AxisAlignedBox2i other)
		{
			return default(bool);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00008DA4 File Offset: 0x00006FA4
		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x2029370", Offset = "0x2027970", VA = "0x182029370", Slot = "4")]
		public int CompareTo(AxisAlignedBox2i other)
		{
			return 0;
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00008DBC File Offset: 0x00006FBC
		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x20293B0", Offset = "0x20279B0", VA = "0x1820293B0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00008DD4 File Offset: 0x00006FD4
		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x20293F0", Offset = "0x20279F0", VA = "0x1820293F0")]
		public Vector2i GetCorner(int i)
		{
			return default(Vector2i);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x2029440", Offset = "0x2027A40", VA = "0x182029440")]
		public void Expand(int nRadius)
		{
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x2029450", Offset = "0x2027A50", VA = "0x182029450")]
		public void Contract(int nRadius)
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x2029460", Offset = "0x2027A60", VA = "0x182029460")]
		public void Scale(int sx, int sy, int sz)
		{
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x2029540", Offset = "0x2027B40", VA = "0x182029540")]
		public void Contain(Vector2i v)
		{
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x20295D0", Offset = "0x2027BD0", VA = "0x1820295D0")]
		public void Contain(AxisAlignedBox2i box)
		{
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x2029660", Offset = "0x2027C60", VA = "0x182029660")]
		public void Contain(Vector3d v)
		{
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x2029700", Offset = "0x2027D00", VA = "0x182029700")]
		public void Contain(AxisAlignedBox3d box)
		{
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00008DEC File Offset: 0x00006FEC
		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x20297A0", Offset = "0x2027DA0", VA = "0x1820297A0")]
		public AxisAlignedBox2i Intersect(AxisAlignedBox2i box)
		{
			return default(AxisAlignedBox2i);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00008E04 File Offset: 0x00007004
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x2029930", Offset = "0x2027F30", VA = "0x182029930")]
		public bool Contains(Vector2i v)
		{
			return default(bool);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00008E1C File Offset: 0x0000701C
		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x2029950", Offset = "0x2027F50", VA = "0x182029950")]
		public bool Contains(ref Vector2i v)
		{
			return default(bool);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00008E34 File Offset: 0x00007034
		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x2029970", Offset = "0x2027F70", VA = "0x182029970")]
		public bool Contains(AxisAlignedBox2i box)
		{
			return default(bool);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00008E4C File Offset: 0x0000704C
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x2029970", Offset = "0x2027F70", VA = "0x182029970")]
		public bool Contains(ref AxisAlignedBox2i box)
		{
			return default(bool);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00008E64 File Offset: 0x00007064
		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x20299D0", Offset = "0x2027FD0", VA = "0x1820299D0")]
		public bool Intersects(AxisAlignedBox2i box)
		{
			return default(bool);
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00008E7C File Offset: 0x0000707C
		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x2029A00", Offset = "0x2028000", VA = "0x182029A00")]
		public double DistanceSquared(Vector2i v)
		{
			return 0.0;
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00008E94 File Offset: 0x00007094
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x2029A80", Offset = "0x2028080", VA = "0x182029A80")]
		public int Distance(Vector2i v)
		{
			return 0;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00008EAC File Offset: 0x000070AC
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x2029B10", Offset = "0x2028110", VA = "0x182029B10")]
		public Vector2i NearestPoint(Vector2i v)
		{
			return default(Vector2i);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x2029B50", Offset = "0x2028150", VA = "0x182029B50")]
		public void Translate(Vector2i vTranslate)
		{
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x2029BE0", Offset = "0x20281E0", VA = "0x182029BE0")]
		public void MoveMin(Vector2i vNewMin)
		{
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x2029C00", Offset = "0x2028200", VA = "0x182029C00")]
		public void MoveMin(int fNewX, int fNewY)
		{
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x2029C30", Offset = "0x2028230", VA = "0x182029C30")]
		public IEnumerable<Vector2i> IndicesInclusive()
		{
			return null;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x2029C90", Offset = "0x2028290", VA = "0x182029C90")]
		public IEnumerable<Vector2i> IndicesExclusive()
		{
			return null;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x2029CF0", Offset = "0x20282F0", VA = "0x182029CF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x4000709")]
		[FieldOffset(Offset = "0x0")]
		public Vector2i Min;

		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x8")]
		public Vector2i Max;

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x400070B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AxisAlignedBox2i Empty;

		// Token: 0x0400070C RID: 1804
		[Token(Token = "0x400070C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly AxisAlignedBox2i Zero;

		// Token: 0x0400070D RID: 1805
		[Token(Token = "0x400070D")]
		[FieldOffset(Offset = "0x20")]
		public static readonly AxisAlignedBox2i UnitPositive;

		// Token: 0x0400070E RID: 1806
		[Token(Token = "0x400070E")]
		[FieldOffset(Offset = "0x30")]
		public static readonly AxisAlignedBox2i Infinite;
	}
}

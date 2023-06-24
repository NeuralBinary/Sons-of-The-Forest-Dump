using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x20001C5")]
	public struct AxisAlignedBox3i : IComparable<AxisAlignedBox3i>, IEquatable<AxisAlignedBox3i>
	{
		// Token: 0x06000CD9 RID: 3289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0x202F560", Offset = "0x202DB60", VA = "0x18202F560")]
		public AxisAlignedBox3i(bool bIgnore)
		{
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x202F5B0", Offset = "0x202DBB0", VA = "0x18202F5B0")]
		public AxisAlignedBox3i(int xmin, int ymin, int zmin, int xmax, int ymax, int zmax)
		{
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x202F5F0", Offset = "0x202DBF0", VA = "0x18202F5F0")]
		public AxisAlignedBox3i(int fCubeSize)
		{
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x202F620", Offset = "0x202DC20", VA = "0x18202F620")]
		public AxisAlignedBox3i(int fWidth, int fHeight, int fDepth)
		{
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x202F660", Offset = "0x202DC60", VA = "0x18202F660")]
		public AxisAlignedBox3i(Vector3i vMin, Vector3i vMax)
		{
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x202F740", Offset = "0x202DD40", VA = "0x18202F740")]
		public AxisAlignedBox3i(Vector3i vCenter, int fHalfWidth, int fHalfHeight, int fHalfDepth)
		{
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x202F7A0", Offset = "0x202DDA0", VA = "0x18202F7A0")]
		public AxisAlignedBox3i(Vector3i vCenter, int fHalfSize)
		{
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x202D4A0", Offset = "0x202BAA0", VA = "0x18202D4A0")]
		public AxisAlignedBox3i(Vector3i vCenter)
		{
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00009464 File Offset: 0x00007664
		[Token(Token = "0x1700023F")]
		public int Width
		{
			[Token(Token = "0x6000CE1")]
			[Address(RVA = "0x202F800", Offset = "0x202DE00", VA = "0x18202F800")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0000947C File Offset: 0x0000767C
		[Token(Token = "0x17000240")]
		public int Height
		{
			[Token(Token = "0x6000CE2")]
			[Address(RVA = "0x202F860", Offset = "0x202DE60", VA = "0x18202F860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00009494 File Offset: 0x00007694
		[Token(Token = "0x17000241")]
		public int Depth
		{
			[Token(Token = "0x6000CE3")]
			[Address(RVA = "0x202F8C0", Offset = "0x202DEC0", VA = "0x18202F8C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x000094AC File Offset: 0x000076AC
		[Token(Token = "0x17000242")]
		public int Volume
		{
			[Token(Token = "0x6000CE4")]
			[Address(RVA = "0x202F920", Offset = "0x202DF20", VA = "0x18202F920")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000094C4 File Offset: 0x000076C4
		[Token(Token = "0x17000243")]
		public int DiagonalLength
		{
			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x202FA20", Offset = "0x202E020", VA = "0x18202FA20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x000094DC File Offset: 0x000076DC
		[Token(Token = "0x17000244")]
		public int MaxDim
		{
			[Token(Token = "0x6000CE6")]
			[Address(RVA = "0x202FAE0", Offset = "0x202E0E0", VA = "0x18202FAE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x000094F4 File Offset: 0x000076F4
		[Token(Token = "0x17000245")]
		public Vector3i Diagonal
		{
			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0x202FC20", Offset = "0x202E220", VA = "0x18202FC20")]
			get
			{
				return default(Vector3i);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0000950C File Offset: 0x0000770C
		[Token(Token = "0x17000246")]
		public Vector3i Extents
		{
			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x202FC40", Offset = "0x202E240", VA = "0x18202FC40")]
			get
			{
				return default(Vector3i);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00009524 File Offset: 0x00007724
		[Token(Token = "0x17000247")]
		public Vector3i Center
		{
			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x202FC80", Offset = "0x202E280", VA = "0x18202FC80")]
			get
			{
				return default(Vector3i);
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0000953C File Offset: 0x0000773C
		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x202FCC0", Offset = "0x202E2C0", VA = "0x18202FCC0")]
		public static bool operator ==(AxisAlignedBox3i a, AxisAlignedBox3i b)
		{
			return default(bool);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00009554 File Offset: 0x00007754
		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x202FDE0", Offset = "0x202E3E0", VA = "0x18202FDE0")]
		public static bool operator !=(AxisAlignedBox3i a, AxisAlignedBox3i b)
		{
			return default(bool);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0000956C File Offset: 0x0000776C
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x202FF00", Offset = "0x202E500", VA = "0x18202FF00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00009584 File Offset: 0x00007784
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x202FFD0", Offset = "0x202E5D0", VA = "0x18202FFD0", Slot = "5")]
		public bool Equals(AxisAlignedBox3i other)
		{
			return default(bool);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0000959C File Offset: 0x0000779C
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x2030070", Offset = "0x202E670", VA = "0x182030070", Slot = "4")]
		public int CompareTo(AxisAlignedBox3i other)
		{
			return 0;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000095B4 File Offset: 0x000077B4
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x20300F0", Offset = "0x202E6F0", VA = "0x1820300F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x2030140", Offset = "0x202E740", VA = "0x182030140")]
		public void Expand(int nRadius)
		{
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0x2030160", Offset = "0x202E760", VA = "0x182030160")]
		public void Contract(int nRadius)
		{
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x2030180", Offset = "0x202E780", VA = "0x182030180")]
		public void Scale(int sx, int sy, int sz)
		{
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x2030280", Offset = "0x202E880", VA = "0x182030280")]
		public void Contain(Vector3i v)
		{
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x2030330", Offset = "0x202E930", VA = "0x182030330")]
		public void Contain(AxisAlignedBox3i box)
		{
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x2030440", Offset = "0x202EA40", VA = "0x182030440")]
		public void Contain(Vector3d v)
		{
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0x2030530", Offset = "0x202EB30", VA = "0x182030530")]
		public void Contain(AxisAlignedBox3d box)
		{
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000095CC File Offset: 0x000077CC
		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0x20305F0", Offset = "0x202EBF0", VA = "0x1820305F0")]
		public AxisAlignedBox3i Intersect(AxisAlignedBox3i box)
		{
			return default(AxisAlignedBox3i);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x000095E4 File Offset: 0x000077E4
		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0x2030830", Offset = "0x202EE30", VA = "0x182030830")]
		public bool Contains(Vector3i v)
		{
			return default(bool);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x000095FC File Offset: 0x000077FC
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x2030860", Offset = "0x202EE60", VA = "0x182030860")]
		public bool Intersects(AxisAlignedBox3i box)
		{
			return default(bool);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00009614 File Offset: 0x00007814
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x20308E0", Offset = "0x202EEE0", VA = "0x1820308E0")]
		public double DistanceSquared(Vector3i v)
		{
			return 0.0;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0000962C File Offset: 0x0000782C
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x2030960", Offset = "0x202EF60", VA = "0x182030960")]
		public int Distance(Vector3i v)
		{
			return 0;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00009644 File Offset: 0x00007844
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x2030A90", Offset = "0x202F090", VA = "0x182030A90")]
		public Vector3i NearestPoint(Vector3i v)
		{
			return default(Vector3i);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0000965C File Offset: 0x0000785C
		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0x2030AF0", Offset = "0x202F0F0", VA = "0x182030AF0")]
		public Vector3i ClampInclusive(Vector3i v)
		{
			return default(Vector3i);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00009674 File Offset: 0x00007874
		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x2030BB0", Offset = "0x202F1B0", VA = "0x182030BB0")]
		public Vector3i ClampExclusive(Vector3i v)
		{
			return default(Vector3i);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x2030C80", Offset = "0x202F280", VA = "0x182030C80")]
		public void Translate(Vector3i vTranslate)
		{
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x2030CE0", Offset = "0x202F2E0", VA = "0x182030CE0")]
		public void MoveMin(Vector3i vNewMin)
		{
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x2030D30", Offset = "0x202F330", VA = "0x182030D30")]
		public void MoveMin(int fNewX, int fNewY, int fNewZ)
		{
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x2030D60", Offset = "0x202F360", VA = "0x182030D60")]
		public IEnumerable<Vector3i> IndicesInclusive()
		{
			return null;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x2030DD0", Offset = "0x202F3D0", VA = "0x182030DD0")]
		public IEnumerable<Vector3i> IndicesExclusive()
		{
			return null;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x2030E40", Offset = "0x202F440", VA = "0x182030E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x0")]
		public Vector3i Min;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0xC")]
		public Vector3i Max;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AxisAlignedBox3i Empty;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly AxisAlignedBox3i Zero;

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x30")]
		public static readonly AxisAlignedBox3i UnitPositive;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x48")]
		public static readonly AxisAlignedBox3i Infinite;
	}
}

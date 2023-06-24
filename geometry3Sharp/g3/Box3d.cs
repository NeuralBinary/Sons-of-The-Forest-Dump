using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001CB RID: 459
	[Token(Token = "0x20001CB")]
	public struct Box3d
	{
		// Token: 0x06000D4F RID: 3407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x2035AA0", Offset = "0x20340A0", VA = "0x182035AA0")]
		public Box3d(Vector3d center)
		{
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x2035B80", Offset = "0x2034180", VA = "0x182035B80")]
		public Box3d(Vector3d center, Vector3d x, Vector3d y, Vector3d z, Vector3d extent)
		{
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x2035BF0", Offset = "0x20341F0", VA = "0x182035BF0")]
		public Box3d(Vector3d center, Vector3d extent)
		{
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x2035CD0", Offset = "0x20342D0", VA = "0x182035CD0")]
		public Box3d(AxisAlignedBox3d aaBox)
		{
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x2035E50", Offset = "0x2034450", VA = "0x182035E50")]
		public Box3d(Frame3f frame, Vector3d extent)
		{
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x2036090", Offset = "0x2034690", VA = "0x182036090")]
		public Box3d(Segment3d seg)
		{
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x000099D4 File Offset: 0x00007BD4
		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x2036160", Offset = "0x2034760", VA = "0x182036160")]
		public Vector3d Axis(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x20361B0", Offset = "0x20347B0", VA = "0x1820361B0")]
		public Vector3d[] ComputeVertices()
		{
			return null;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D57")]
		[Address(RVA = "0x2036210", Offset = "0x2034810", VA = "0x182036210")]
		public void ComputeVertices(Vector3d[] vertex)
		{
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000D58")]
		[Address(RVA = "0x20366E0", Offset = "0x2034CE0", VA = "0x1820366E0")]
		public IEnumerable<Vector3d> VerticesItr()
		{
			return null;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x000099EC File Offset: 0x00007BEC
		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x20367B0", Offset = "0x2034DB0", VA = "0x1820367B0")]
		public AxisAlignedBox3d ToAABB()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00009A04 File Offset: 0x00007C04
		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x2036BE0", Offset = "0x20351E0", VA = "0x182036BE0")]
		public Vector3d Corner(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00009A1C File Offset: 0x00007C1C
		[Token(Token = "0x17000254")]
		public double MaxExtent
		{
			[Token(Token = "0x6000D5B")]
			[Address(RVA = "0x2036EA0", Offset = "0x20354A0", VA = "0x182036EA0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00009A34 File Offset: 0x00007C34
		[Token(Token = "0x17000255")]
		public double MinExtent
		{
			[Token(Token = "0x6000D5C")]
			[Address(RVA = "0x2036F70", Offset = "0x2035570", VA = "0x182036F70")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00009A4C File Offset: 0x00007C4C
		[Token(Token = "0x17000256")]
		public Vector3d Diagonal
		{
			[Token(Token = "0x6000D5D")]
			[Address(RVA = "0x2037040", Offset = "0x2035640", VA = "0x182037040")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x00009A64 File Offset: 0x00007C64
		[Token(Token = "0x17000257")]
		public double Volume
		{
			[Token(Token = "0x6000D5E")]
			[Address(RVA = "0x2037210", Offset = "0x2035810", VA = "0x182037210")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x2037230", Offset = "0x2035830", VA = "0x182037230")]
		public void Contain(Vector3d v)
		{
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x2037550", Offset = "0x2035B50", VA = "0x182037550")]
		public void Contain(IEnumerable<Vector3d> points)
		{
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D61")]
		[Address(RVA = "0x2037B30", Offset = "0x2036130", VA = "0x182037B30")]
		public void Contain(Box3d o)
		{
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00009A7C File Offset: 0x00007C7C
		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x2037BE0", Offset = "0x20361E0", VA = "0x182037BE0")]
		public bool Contains(Vector3d v)
		{
			return default(bool);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x2037DA0", Offset = "0x20363A0", VA = "0x182037DA0")]
		public void Expand(double f)
		{
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x2037E30", Offset = "0x2036430", VA = "0x182037E30")]
		public void Translate(Vector3d v)
		{
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x2037ED0", Offset = "0x20364D0", VA = "0x182037ED0")]
		public void Scale(Vector3d s)
		{
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x2038070", Offset = "0x2036670", VA = "0x182038070")]
		public void ScaleExtents(Vector3d s)
		{
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00009A94 File Offset: 0x00007C94
		[Token(Token = "0x6000D67")]
		[Address(RVA = "0x2038110", Offset = "0x2036710", VA = "0x182038110")]
		public double DistanceSquared(Vector3d v)
		{
			return 0.0;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00009AAC File Offset: 0x00007CAC
		[Token(Token = "0x6000D68")]
		[Address(RVA = "0x2038370", Offset = "0x2036970", VA = "0x182038370")]
		public Vector3d ClosestPoint(Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00009AC4 File Offset: 0x00007CC4
		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x2038620", Offset = "0x2036C20", VA = "0x182038620")]
		public static Box3d Merge(ref Box3d box0, ref Box3d box1)
		{
			return default(Box3d);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00009ADC File Offset: 0x00007CDC
		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x2038F60", Offset = "0x2037560", VA = "0x182038F60")]
		public static implicit operator Box3d(Box3f v)
		{
			return default(Box3d);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00009AF4 File Offset: 0x00007CF4
		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x2039180", Offset = "0x2037780", VA = "0x182039180")]
		public static explicit operator Box3f(Box3d v)
		{
			return default(Box3f);
		}

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x0")]
		public Vector3d Center;

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d AxisX;

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x30")]
		public Vector3d AxisY;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x48")]
		public Vector3d AxisZ;

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		[FieldOffset(Offset = "0x60")]
		public Vector3d Extent;

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Box3d Empty;

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0x78")]
		public static readonly Box3d UnitZeroCentered;

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x4000750")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly Box3d UnitPositive;
	}
}

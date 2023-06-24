using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	public class SphericalFibonacciPointSet
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public SphericalFibonacciPointSet(int n = 64)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x17000020")]
		public int Count
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1E27940", Offset = "0x1E25F40", VA = "0x181E27940")]
		public Vector3d Point(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x17000021 RID: 33
		[Token(Token = "0x17000021")]
		public Vector3d this[int i]
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1E27A70", Offset = "0x1E26070", VA = "0x181E27A70")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1E27BC0", Offset = "0x1E261C0", VA = "0x181E27BC0")]
		public int NearestPoint(Vector3d p, bool bIsNormalized = false)
		{
			return 0;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1E27C10", Offset = "0x1E26210", VA = "0x181E27C10")]
		private double madfrac(double a, double b)
		{
			return 0.0;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1E27C80", Offset = "0x1E26280", VA = "0x181E27C80")]
		private int inverseSF(ref Vector3d p)
		{
			return 0;
		}

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x10")]
		public int N;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly double PHI;
	}
}

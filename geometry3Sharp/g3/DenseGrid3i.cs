using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000361 RID: 865
	[Token(Token = "0x2000361")]
	public class DenseGrid3i
	{
		// Token: 0x06001CB4 RID: 7348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x1F6AEF0", Offset = "0x1F694F0", VA = "0x181F6AEF0")]
		public DenseGrid3i()
		{
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0x1F6C0C0", Offset = "0x1F6A6C0", VA = "0x181F6C0C0")]
		public DenseGrid3i(int ni, int nj, int nk, int initialValue)
		{
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x0001430C File Offset: 0x0001250C
		[Token(Token = "0x17000458")]
		public int size
		{
			[Token(Token = "0x6001CB6")]
			[Address(RVA = "0x1F6B120", Offset = "0x1F69720", VA = "0x181F6B120")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x1F6C1E0", Offset = "0x1F6A7E0", VA = "0x181F6C1E0")]
		public void resize(int ni, int nj, int nk)
		{
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0x1F6A7A0", Offset = "0x1F68DA0", VA = "0x181F6A7A0")]
		public void assign(int value)
		{
		}

		// Token: 0x17000459 RID: 1113
		[Token(Token = "0x17000459")]
		public int this[int i]
		{
			[Token(Token = "0x6001CB9")]
			[Address(RVA = "0x175F3B0", Offset = "0x175D9B0", VA = "0x18175F3B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001CBA")]
			[Address(RVA = "0x175F3E0", Offset = "0x175D9E0", VA = "0x18175F3E0")]
			set
			{
			}
		}

		// Token: 0x1700045A RID: 1114
		[Token(Token = "0x1700045A")]
		public int this[int i, int j, int k]
		{
			[Token(Token = "0x6001CBB")]
			[Address(RVA = "0x1F6C2B0", Offset = "0x1F6A8B0", VA = "0x181F6C2B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001CBC")]
			[Address(RVA = "0x1F6C2F0", Offset = "0x1F6A8F0", VA = "0x181F6C2F0")]
			set
			{
			}
		}

		// Token: 0x1700045B RID: 1115
		[Token(Token = "0x1700045B")]
		public int this[Vector3i ijk]
		{
			[Token(Token = "0x6001CBD")]
			[Address(RVA = "0x1F6C330", Offset = "0x1F6A930", VA = "0x181F6C330")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001CBE")]
			[Address(RVA = "0x1F6C380", Offset = "0x1F6A980", VA = "0x181F6C380")]
			set
			{
			}
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CBF")]
		[Address(RVA = "0x1F6C3D0", Offset = "0x1F6A9D0", VA = "0x181F6C3D0")]
		public void increment(int i, int j, int k)
		{
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CC0")]
		[Address(RVA = "0x1F6C410", Offset = "0x1F6AA10", VA = "0x181F6C410")]
		public void decrement(int i, int j, int k)
		{
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CC1")]
		[Address(RVA = "0x1F6C450", Offset = "0x1F6AA50", VA = "0x181F6C450")]
		public void atomic_increment(int i, int j, int k)
		{
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CC2")]
		[Address(RVA = "0x1F6C4A0", Offset = "0x1F6AAA0", VA = "0x181F6C4A0")]
		public void atomic_decrement(int i, int j, int k)
		{
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001CC3")]
		[Address(RVA = "0x1F6C4F0", Offset = "0x1F6AAF0", VA = "0x181F6C4F0")]
		public void atomic_incdec(int i, int j, int k, bool decrement = false)
		{
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001CC4")]
		[Address(RVA = "0x1F6C570", Offset = "0x1F6AB70", VA = "0x181F6C570")]
		public DenseGrid2i get_slice(int slice_i, int dimension)
		{
			return null;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001CC5")]
		[Address(RVA = "0x1F6C810", Offset = "0x1F6AE10", VA = "0x181F6C810")]
		public Bitmap3 get_bitmap(int thresh = 0)
		{
			return null;
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001CC6")]
		[Address(RVA = "0x1F6C900", Offset = "0x1F6AF00", VA = "0x181F6C900")]
		public IEnumerable<Vector3i> Indices()
		{
			return null;
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001CC7")]
		[Address(RVA = "0x1F6C9A0", Offset = "0x1F6AFA0", VA = "0x181F6C9A0")]
		public IEnumerable<Vector3i> InsetIndices(int border_width)
		{
			return null;
		}

		// Token: 0x04000F48 RID: 3912
		[Token(Token = "0x4000F48")]
		[FieldOffset(Offset = "0x10")]
		public int[] Buffer;

		// Token: 0x04000F49 RID: 3913
		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0x18")]
		public int ni;

		// Token: 0x04000F4A RID: 3914
		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0x1C")]
		public int nj;

		// Token: 0x04000F4B RID: 3915
		[Token(Token = "0x4000F4B")]
		[FieldOffset(Offset = "0x20")]
		public int nk;
	}
}

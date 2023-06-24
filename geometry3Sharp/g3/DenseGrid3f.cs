using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200035E RID: 862
	[Token(Token = "0x200035E")]
	public class DenseGrid3f
	{
		// Token: 0x06001C88 RID: 7304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C88")]
		[Address(RVA = "0x1F6AEF0", Offset = "0x1F694F0", VA = "0x181F6AEF0")]
		public DenseGrid3f()
		{
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C89")]
		[Address(RVA = "0x1F6AF00", Offset = "0x1F69500", VA = "0x181F6AF00")]
		public DenseGrid3f(int ni, int nj, int nk, float initialValue)
		{
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C8A")]
		[Address(RVA = "0x1F6AF80", Offset = "0x1F69580", VA = "0x181F6AF80")]
		public DenseGrid3f(DenseGrid3f copy)
		{
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C8B")]
		[Address(RVA = "0x1F697D0", Offset = "0x1F67DD0", VA = "0x181F697D0")]
		public void swap(DenseGrid3f g2)
		{
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x000141BC File Offset: 0x000123BC
		[Token(Token = "0x1700044E")]
		public int size
		{
			[Token(Token = "0x6001C8C")]
			[Address(RVA = "0x1F6B120", Offset = "0x1F69720", VA = "0x181F6B120")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C8D")]
		[Address(RVA = "0x1F6B130", Offset = "0x1F69730", VA = "0x181F6B130")]
		public void resize(int ni, int nj, int nk)
		{
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C8E")]
		[Address(RVA = "0x1F69950", Offset = "0x1F67F50", VA = "0x181F69950")]
		public void assign(float value)
		{
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C8F")]
		[Address(RVA = "0x1F6B200", Offset = "0x1F69800", VA = "0x181F6B200")]
		public void set_min(ref Vector3i ijk, float f)
		{
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C90")]
		[Address(RVA = "0x1F6B260", Offset = "0x1F69860", VA = "0x181F6B260")]
		public void set_max(ref Vector3i ijk, float f)
		{
		}

		// Token: 0x1700044F RID: 1103
		[Token(Token = "0x1700044F")]
		public float this[int i]
		{
			[Token(Token = "0x6001C91")]
			[Address(RVA = "0x1760B90", Offset = "0x175F190", VA = "0x181760B90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C92")]
			[Address(RVA = "0x1760BC0", Offset = "0x175F1C0", VA = "0x181760BC0")]
			set
			{
			}
		}

		// Token: 0x17000450 RID: 1104
		[Token(Token = "0x17000450")]
		public float this[int i, int j, int k]
		{
			[Token(Token = "0x6001C93")]
			[Address(RVA = "0x1F6B2B0", Offset = "0x1F698B0", VA = "0x181F6B2B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C94")]
			[Address(RVA = "0x1F6B2F0", Offset = "0x1F698F0", VA = "0x181F6B2F0")]
			set
			{
			}
		}

		// Token: 0x17000451 RID: 1105
		[Token(Token = "0x17000451")]
		public float this[Vector3i ijk]
		{
			[Token(Token = "0x6001C95")]
			[Address(RVA = "0x1F6B340", Offset = "0x1F69940", VA = "0x181F6B340")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C96")]
			[Address(RVA = "0x1F6B390", Offset = "0x1F69990", VA = "0x181F6B390")]
			set
			{
			}
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C97")]
		[Address(RVA = "0x1F6B3E0", Offset = "0x1F699E0", VA = "0x181F6B3E0")]
		public void get_x_pair(int i0, int j, int k, out float a, out float b)
		{
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x1F6B450", Offset = "0x1F69A50", VA = "0x181F6B450")]
		public void get_x_pair(int i0, int j, int k, out double a, out double b)
		{
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C99")]
		[Address(RVA = "0x1F6B4C0", Offset = "0x1F69AC0", VA = "0x181F6B4C0")]
		public void apply(Func<float, float> f)
		{
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x1F6B5A0", Offset = "0x1F69BA0", VA = "0x181F6B5A0")]
		public DenseGrid2f get_slice(int slice_i, int dimension)
		{
			return null;
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x1F6B840", Offset = "0x1F69E40", VA = "0x181F6B840")]
		public void set_slice(DenseGrid2f slice, int slice_i, int dimension)
		{
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x0001421C File Offset: 0x0001241C
		[Token(Token = "0x17000452")]
		public AxisAlignedBox3i Bounds
		{
			[Token(Token = "0x6001C9C")]
			[Address(RVA = "0x1F6BA30", Offset = "0x1F6A030", VA = "0x181F6BA30")]
			get
			{
				return default(AxisAlignedBox3i);
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x00014234 File Offset: 0x00012434
		[Token(Token = "0x17000453")]
		public AxisAlignedBox3i BoundsInclusive
		{
			[Token(Token = "0x6001C9D")]
			[Address(RVA = "0x1F6BA70", Offset = "0x1F6A070", VA = "0x181F6BA70")]
			get
			{
				return default(AxisAlignedBox3i);
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x1F6BAC0", Offset = "0x1F6A0C0", VA = "0x181F6BAC0")]
		public IEnumerable<Vector3i> Indices()
		{
			return null;
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0x1F6BB60", Offset = "0x1F6A160", VA = "0x181F6BB60")]
		public IEnumerable<Vector3i> InsetIndices(int border_width)
		{
			return null;
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0001424C File Offset: 0x0001244C
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x1F6BC20", Offset = "0x1F6A220", VA = "0x181F6BC20")]
		public Vector3i to_index(int idx)
		{
			return default(Vector3i);
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00014264 File Offset: 0x00012464
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x1F6BC50", Offset = "0x1F6A250", VA = "0x181F6BC50")]
		public int to_linear(int i, int j, int k)
		{
			return 0;
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0001427C File Offset: 0x0001247C
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x1F6BC60", Offset = "0x1F6A260", VA = "0x181F6BC60")]
		public int to_linear(ref Vector3i ijk)
		{
			return 0;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00014294 File Offset: 0x00012494
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x1F6BC60", Offset = "0x1F6A260", VA = "0x181F6BC60")]
		public int to_linear(Vector3i ijk)
		{
			return 0;
		}

		// Token: 0x04000F32 RID: 3890
		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x10")]
		public float[] Buffer;

		// Token: 0x04000F33 RID: 3891
		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x18")]
		public int ni;

		// Token: 0x04000F34 RID: 3892
		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x1C")]
		public int nj;

		// Token: 0x04000F35 RID: 3893
		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x20")]
		public int nk;
	}
}

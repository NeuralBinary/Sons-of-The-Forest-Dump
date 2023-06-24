using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000358 RID: 856
	[Token(Token = "0x2000358")]
	public class DenseGrid2f
	{
		// Token: 0x06001C3B RID: 7227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C3B")]
		[Address(RVA = "0x1F69510", Offset = "0x1F67B10", VA = "0x181F69510")]
		public DenseGrid2f()
		{
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C3C")]
		[Address(RVA = "0x1F69520", Offset = "0x1F67B20", VA = "0x181F69520")]
		public DenseGrid2f(int ni, int nj, float initialValue)
		{
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C3D")]
		[Address(RVA = "0x1F69630", Offset = "0x1F67C30", VA = "0x181F69630")]
		public DenseGrid2f(DenseGrid2f copy)
		{
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C3E")]
		[Address(RVA = "0x1F697D0", Offset = "0x1F67DD0", VA = "0x181F697D0")]
		public void swap(DenseGrid2f g2)
		{
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x0001400C File Offset: 0x0001220C
		[Token(Token = "0x1700043D")]
		public int size
		{
			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0x1F33610", Offset = "0x1F31C10", VA = "0x181F33610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C40")]
		[Address(RVA = "0x1F698A0", Offset = "0x1F67EA0", VA = "0x181F698A0")]
		public void resize(int ni, int nj)
		{
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C41")]
		[Address(RVA = "0x1F69950", Offset = "0x1F67F50", VA = "0x181F69950")]
		public void assign(float value)
		{
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C42")]
		[Address(RVA = "0x1F69990", Offset = "0x1F67F90", VA = "0x181F69990")]
		public void assign_border(float value, int rings)
		{
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C43")]
		[Address(RVA = "0x1F5D040", Offset = "0x1F5B640", VA = "0x181F5D040")]
		public void clear()
		{
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x1F69AA0", Offset = "0x1F680A0", VA = "0x181F69AA0")]
		public void copy(DenseGrid2f copy)
		{
		}

		// Token: 0x1700043E RID: 1086
		[Token(Token = "0x1700043E")]
		public float this[int i]
		{
			[Token(Token = "0x6001C45")]
			[Address(RVA = "0x1760B90", Offset = "0x175F190", VA = "0x181760B90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C46")]
			[Address(RVA = "0x1760BC0", Offset = "0x175F1C0", VA = "0x181760BC0")]
			set
			{
			}
		}

		// Token: 0x1700043F RID: 1087
		[Token(Token = "0x1700043F")]
		public float this[int i, int j]
		{
			[Token(Token = "0x6001C47")]
			[Address(RVA = "0x1F69B90", Offset = "0x1F68190", VA = "0x181F69B90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C48")]
			[Address(RVA = "0x1F69BD0", Offset = "0x1F681D0", VA = "0x181F69BD0")]
			set
			{
			}
		}

		// Token: 0x17000440 RID: 1088
		[Token(Token = "0x17000440")]
		public float this[Vector2i ijk]
		{
			[Token(Token = "0x6001C49")]
			[Address(RVA = "0x1F69C10", Offset = "0x1F68210", VA = "0x181F69C10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C4A")]
			[Address(RVA = "0x1F69C50", Offset = "0x1F68250", VA = "0x181F69C50")]
			set
			{
			}
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C4B")]
		[Address(RVA = "0x1F69C90", Offset = "0x1F68290", VA = "0x181F69C90")]
		public void get_x_pair(int i0, int j, out double a, out double b)
		{
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C4C")]
		[Address(RVA = "0x1F69D00", Offset = "0x1F68300", VA = "0x181F69D00")]
		public void apply(Func<float, float> f)
		{
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0x1F69DC0", Offset = "0x1F683C0", VA = "0x181F69DC0")]
		public void set_min(DenseGrid2f grid2)
		{
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x1F69ED0", Offset = "0x1F684D0", VA = "0x181F69ED0")]
		public void set_max(DenseGrid2f grid2)
		{
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x0001406C File Offset: 0x0001226C
		[Token(Token = "0x17000441")]
		public AxisAlignedBox2i Bounds
		{
			[Token(Token = "0x6001C4F")]
			[Address(RVA = "0x1F69FE0", Offset = "0x1F685E0", VA = "0x181F69FE0")]
			get
			{
				return default(AxisAlignedBox2i);
			}
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x1F6A010", Offset = "0x1F68610", VA = "0x181F6A010")]
		public IEnumerable<Vector2i> Indices()
		{
			return null;
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001C51")]
		[Address(RVA = "0x1F6A0B0", Offset = "0x1F686B0", VA = "0x181F6A0B0")]
		public IEnumerable<Vector2i> InsetIndices(int border_width)
		{
			return null;
		}

		// Token: 0x04000F0C RID: 3852
		[Token(Token = "0x4000F0C")]
		[FieldOffset(Offset = "0x10")]
		public float[] Buffer;

		// Token: 0x04000F0D RID: 3853
		[Token(Token = "0x4000F0D")]
		[FieldOffset(Offset = "0x18")]
		public int ni;

		// Token: 0x04000F0E RID: 3854
		[Token(Token = "0x4000F0E")]
		[FieldOffset(Offset = "0x1C")]
		public int nj;
	}
}

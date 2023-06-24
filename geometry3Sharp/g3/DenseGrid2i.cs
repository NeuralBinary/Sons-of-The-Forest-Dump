using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200035B RID: 859
	[Token(Token = "0x200035B")]
	public class DenseGrid2i
	{
		// Token: 0x06001C62 RID: 7266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C62")]
		[Address(RVA = "0x1F69510", Offset = "0x1F67B10", VA = "0x181F69510")]
		public DenseGrid2i()
		{
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C63")]
		[Address(RVA = "0x1F6A560", Offset = "0x1F68B60", VA = "0x181F6A560")]
		public DenseGrid2i(int ni, int nj, int initialValue)
		{
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C64")]
		[Address(RVA = "0x1F6A5E0", Offset = "0x1F68BE0", VA = "0x181F6A5E0")]
		public DenseGrid2i(DenseGrid2i copy)
		{
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x000140E4 File Offset: 0x000122E4
		[Token(Token = "0x17000446")]
		public int size
		{
			[Token(Token = "0x6001C65")]
			[Address(RVA = "0x1F33610", Offset = "0x1F31C10", VA = "0x181F33610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x1F6A6F0", Offset = "0x1F68CF0", VA = "0x181F6A6F0")]
		public void resize(int ni, int nj)
		{
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C67")]
		[Address(RVA = "0x1F5D040", Offset = "0x1F5B640", VA = "0x181F5D040")]
		public void clear()
		{
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C68")]
		[Address(RVA = "0x1F69AA0", Offset = "0x1F680A0", VA = "0x181F69AA0")]
		public void copy(DenseGrid2i copy)
		{
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x1F6A7A0", Offset = "0x1F68DA0", VA = "0x181F6A7A0")]
		public void assign(int value)
		{
		}

		// Token: 0x17000447 RID: 1095
		[Token(Token = "0x17000447")]
		public int this[int i]
		{
			[Token(Token = "0x6001C6A")]
			[Address(RVA = "0x175F3B0", Offset = "0x175D9B0", VA = "0x18175F3B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C6B")]
			[Address(RVA = "0x175F3E0", Offset = "0x175D9E0", VA = "0x18175F3E0")]
			set
			{
			}
		}

		// Token: 0x17000448 RID: 1096
		[Token(Token = "0x17000448")]
		public int this[int i, int j]
		{
			[Token(Token = "0x6001C6C")]
			[Address(RVA = "0x1F6A800", Offset = "0x1F68E00", VA = "0x181F6A800")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C6D")]
			[Address(RVA = "0x1F6A840", Offset = "0x1F68E40", VA = "0x181F6A840")]
			set
			{
			}
		}

		// Token: 0x17000449 RID: 1097
		[Token(Token = "0x17000449")]
		public int this[Vector2i ijk]
		{
			[Token(Token = "0x6001C6E")]
			[Address(RVA = "0x1F6A880", Offset = "0x1F68E80", VA = "0x181F6A880")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C6F")]
			[Address(RVA = "0x1F6A8C0", Offset = "0x1F68EC0", VA = "0x181F6A8C0")]
			set
			{
			}
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C70")]
		[Address(RVA = "0x1F6A900", Offset = "0x1F68F00", VA = "0x181F6A900")]
		public void increment(int i, int j)
		{
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C71")]
		[Address(RVA = "0x1F6A940", Offset = "0x1F68F40", VA = "0x181F6A940")]
		public void decrement(int i, int j)
		{
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C72")]
		[Address(RVA = "0x1F6A980", Offset = "0x1F68F80", VA = "0x181F6A980")]
		public void atomic_increment(int i, int j)
		{
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C73")]
		[Address(RVA = "0x1F6A9C0", Offset = "0x1F68FC0", VA = "0x181F6A9C0")]
		public void atomic_decrement(int i, int j)
		{
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C74")]
		[Address(RVA = "0x1F6AA00", Offset = "0x1F69000", VA = "0x181F6AA00")]
		public void atomic_incdec(int i, int j, bool decrement = false)
		{
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00014144 File Offset: 0x00012344
		[Token(Token = "0x6001C75")]
		[Address(RVA = "0x1F6AA70", Offset = "0x1F69070", VA = "0x181F6AA70")]
		public int sum()
		{
			return 0;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001C76")]
		[Address(RVA = "0x1F6AAC0", Offset = "0x1F690C0", VA = "0x181F6AAC0")]
		public IEnumerable<Vector2i> Indices()
		{
			return null;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001C77")]
		[Address(RVA = "0x1F6AB60", Offset = "0x1F69160", VA = "0x181F6AB60")]
		public IEnumerable<Vector2i> InsetIndices(int border_width)
		{
			return null;
		}

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x10")]
		public int[] Buffer;

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x18")]
		public int ni;

		// Token: 0x04000F21 RID: 3873
		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x1C")]
		public int nj;
	}
}

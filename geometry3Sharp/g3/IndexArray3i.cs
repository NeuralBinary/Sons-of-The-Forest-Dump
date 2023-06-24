using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	public class IndexArray3i : VectorArray3<int>
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1F50E80", Offset = "0x1F4F480", VA = "0x181F50E80")]
		public IndexArray3i(int nCount)
		{
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1F50EC0", Offset = "0x1F4F4C0", VA = "0x181F50EC0")]
		public IndexArray3i(int[] data)
		{
		}

		// Token: 0x1700009E RID: 158
		[Token(Token = "0x1700009E")]
		public Index3i this[int i]
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1F50A20", Offset = "0x1F4F020", VA = "0x181F50A20")]
			get
			{
				return default(Index3i);
			}
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x1F50A80", Offset = "0x1F4F080", VA = "0x181F50A80")]
			set
			{
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1F50AF0", Offset = "0x1F4F0F0", VA = "0x181F50AF0")]
		public void Set(int i, int a, int b, int c, bool bCycle = false)
		{
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1F50F40", Offset = "0x1F4F540", VA = "0x181F50F40")]
		public IEnumerable<Index3i> AsIndex3i()
		{
			return null;
		}
	}
}

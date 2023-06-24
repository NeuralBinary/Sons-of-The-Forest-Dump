using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public class VectorArray3i : VectorArray3<int>
	{
		// Token: 0x06000493 RID: 1171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1F50960", Offset = "0x1F4EF60", VA = "0x181F50960")]
		public VectorArray3i(int nCount)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1F509A0", Offset = "0x1F4EFA0", VA = "0x181F509A0")]
		public VectorArray3i(int[] data)
		{
		}

		// Token: 0x1700009B RID: 155
		[Token(Token = "0x1700009B")]
		public Vector3i this[int i]
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1F50A20", Offset = "0x1F4F020", VA = "0x181F50A20")]
			get
			{
				return default(Vector3i);
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1F50A80", Offset = "0x1F4F080", VA = "0x181F50A80")]
			set
			{
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1F50AF0", Offset = "0x1F4F0F0", VA = "0x181F50AF0")]
		public void Set(int i, int a, int b, int c, bool bCycle = false)
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1F50BA0", Offset = "0x1F4F1A0", VA = "0x181F50BA0")]
		public IEnumerable<Vector3i> AsVector3i()
		{
			return null;
		}
	}
}

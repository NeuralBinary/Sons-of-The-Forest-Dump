using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public class DVectorArray3i : DVectorArray3<int>
	{
		// Token: 0x0600026C RID: 620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1F3F090", Offset = "0x1F3D690", VA = "0x181F3F090")]
		public DVectorArray3i(int nCount = 0)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1F3F0D0", Offset = "0x1F3D6D0", VA = "0x181F3F0D0")]
		public DVectorArray3i(int[] data)
		{
		}

		// Token: 0x1700003A RID: 58
		[Token(Token = "0x1700003A")]
		public Vector3i this[int i]
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x1F3F120", Offset = "0x1F3D720", VA = "0x181F3F120")]
			get
			{
				return default(Vector3i);
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x1F3F290", Offset = "0x1F3D890", VA = "0x181F3F290")]
			set
			{
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1F3F2C0", Offset = "0x1F3D8C0", VA = "0x181F3F2C0")]
		public void Set(int i, int a, int b, int c, bool bCycle = false)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1F3F520", Offset = "0x1F3DB20", VA = "0x181F3F520")]
		public IEnumerable<Vector3i> AsVector3i()
		{
			return null;
		}
	}
}

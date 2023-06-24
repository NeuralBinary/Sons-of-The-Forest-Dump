using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public class DVectorArray2d : DVectorArray2<double>
	{
		// Token: 0x06000296 RID: 662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1F400E0", Offset = "0x1F3E6E0", VA = "0x181F400E0")]
		public DVectorArray2d(int nCount = 0)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1F401F0", Offset = "0x1F3E7F0", VA = "0x181F401F0")]
		public DVectorArray2d(double[] data)
		{
		}

		// Token: 0x17000043 RID: 67
		[Token(Token = "0x17000043")]
		public Vector2d this[int i]
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x1F402F0", Offset = "0x1F3E8F0", VA = "0x181F402F0")]
			get
			{
				return default(Vector2d);
			}
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x1F40400", Offset = "0x1F3EA00", VA = "0x181F40400")]
			set
			{
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1F404B0", Offset = "0x1F3EAB0", VA = "0x181F404B0")]
		public IEnumerable<Vector2d> AsVector2d()
		{
			return null;
		}
	}
}

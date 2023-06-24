using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public class DVectorArray2f : DVectorArray2<float>
	{
		// Token: 0x060002A3 RID: 675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1F40850", Offset = "0x1F3EE50", VA = "0x181F40850")]
		public DVectorArray2f(int nCount = 0)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1F40960", Offset = "0x1F3EF60", VA = "0x181F40960")]
		public DVectorArray2f(float[] data)
		{
		}

		// Token: 0x17000046 RID: 70
		[Token(Token = "0x17000046")]
		public Vector2f this[int i]
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x1F40A60", Offset = "0x1F3F060", VA = "0x181F40A60")]
			get
			{
				return default(Vector2f);
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1F40B60", Offset = "0x1F3F160", VA = "0x181F40B60")]
			set
			{
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1F40C00", Offset = "0x1F3F200", VA = "0x181F40C00")]
		public IEnumerable<Vector2d> AsVector2f()
		{
			return null;
		}
	}
}

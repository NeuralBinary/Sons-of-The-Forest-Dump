using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	public class VectorArray2f : VectorArray2<float>
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1F90180", Offset = "0x1F8E780", VA = "0x181F90180")]
		public VectorArray2f(int nCount)
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1F90250", Offset = "0x1F8E850", VA = "0x181F90250")]
		public VectorArray2f(float[] data)
		{
		}

		// Token: 0x170000A7 RID: 167
		[Token(Token = "0x170000A7")]
		public Vector2f this[int i]
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x1F902D0", Offset = "0x1F8E8D0", VA = "0x181F902D0")]
			get
			{
				return default(Vector2f);
			}
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x1F90320", Offset = "0x1F8E920", VA = "0x181F90320")]
			set
			{
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1F903A0", Offset = "0x1F8E9A0", VA = "0x181F903A0")]
		public IEnumerable<Vector2d> AsVector2f()
		{
			return null;
		}
	}
}

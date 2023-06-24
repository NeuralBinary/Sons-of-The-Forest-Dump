using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	public class VectorArray3f : VectorArray3<float>
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1F50430", Offset = "0x1F4EA30", VA = "0x181F50430")]
		public VectorArray3f(int nCount)
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1F50500", Offset = "0x1F4EB00", VA = "0x181F50500")]
		public VectorArray3f(float[] data)
		{
		}

		// Token: 0x17000098 RID: 152
		[Token(Token = "0x17000098")]
		public Vector3f this[int i]
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x1F50580", Offset = "0x1F4EB80", VA = "0x181F50580")]
			get
			{
				return default(Vector3f);
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1F505E0", Offset = "0x1F4EBE0", VA = "0x181F505E0")]
			set
			{
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1F50680", Offset = "0x1F4EC80", VA = "0x181F50680")]
		public IEnumerable<Vector3f> AsVector3f()
		{
			return null;
		}
	}
}

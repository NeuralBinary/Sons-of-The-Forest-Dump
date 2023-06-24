using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class TQ
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x28DA560", Offset = "0x28D8B60", VA = "0x1828DA560")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 t;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion q;
	}
}

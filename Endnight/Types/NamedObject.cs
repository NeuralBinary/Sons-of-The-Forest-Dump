using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Types
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	[Serializable]
	public class NamedObject
	{
		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NamedObject()
		{
		}

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x18")]
		public UnityEngine.Object Object;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Types
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[Serializable]
	public class NamedGameObject
	{
		// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NamedGameObject()
		{
		}

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x18")]
		public GameObject GameObject;
	}
}

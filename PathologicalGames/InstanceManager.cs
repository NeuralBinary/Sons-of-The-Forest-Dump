using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public static class InstanceManager
	{
		// Token: 0x06000245 RID: 581 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x28CE0C0", Offset = "0x28CC6C0", VA = "0x1828CE0C0")]
		public static Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x28CE150", Offset = "0x28CC750", VA = "0x1828CE150")]
		public static void Despawn(Transform instance)
		{
		}

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x0")]
		public static string poolName;
	}
}

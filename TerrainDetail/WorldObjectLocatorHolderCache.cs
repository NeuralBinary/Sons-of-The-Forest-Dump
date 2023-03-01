using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x02000510 RID: 1296
	[Token(Token = "0x2000510")]
	public static class WorldObjectLocatorHolderCache
	{
		// Token: 0x0600217D RID: 8573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217D")]
		[Address(RVA = "0x2D71AF0", Offset = "0x2D70AF0", VA = "0x182D71AF0")]
		public static WorldObjectLocatorHolder GetHolderCache(Transform target)
		{
			return null;
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217E")]
		[Address(RVA = "0x2D71CB0", Offset = "0x2D70CB0", VA = "0x182D71CB0")]
		private static WorldObjectLocatorHolder GetOrCreate(Transform target)
		{
			return null;
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600217F")]
		[Address(RVA = "0x2D71D70", Offset = "0x2D70D70", VA = "0x182D71D70")]
		private static void RemoveHolderCache(Transform target)
		{
		}

		// Token: 0x04001EDE RID: 7902
		[Token(Token = "0x4001EDE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, WorldObjectLocatorHolder> HolderCache;

		// Token: 0x04001EDF RID: 7903
		[Token(Token = "0x4001EDF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Action<Transform> RemoveHolderCacheMethod;
	}
}

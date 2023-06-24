using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x02000518 RID: 1304
	[Token(Token = "0x2000518")]
	public static class WorldObjectLocatorHolderCache
	{
		// Token: 0x06002260 RID: 8800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002260")]
		[Address(RVA = "0x333A7A0", Offset = "0x3338DA0", VA = "0x18333A7A0")]
		public static WorldObjectLocatorHolder GetHolderCache(Transform target)
		{
			return null;
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002261")]
		[Address(RVA = "0x333AA60", Offset = "0x3339060", VA = "0x18333AA60")]
		private static WorldObjectLocatorHolder GetOrCreate(Transform target)
		{
			return null;
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002262")]
		[Address(RVA = "0x333ABC0", Offset = "0x33391C0", VA = "0x18333ABC0")]
		private static void RemoveHolderCache(Transform target)
		{
		}

		// Token: 0x04001F8E RID: 8078
		[Token(Token = "0x4001F8E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, WorldObjectLocatorHolder> HolderCache;

		// Token: 0x04001F8F RID: 8079
		[Token(Token = "0x4001F8F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Action<Transform> RemoveHolderCacheMethod;
	}
}

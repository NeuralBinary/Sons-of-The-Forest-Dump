using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public class PoolLink : MonoBehaviour
	{
		// Token: 0x06000083 RID: 131 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public PrefabPool GetPrefabPool()
		{
			return null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetPool(PrefabPool prefabPool)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PoolLink()
		{
		}

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		private PrefabPool _prefabPool;
	}
}

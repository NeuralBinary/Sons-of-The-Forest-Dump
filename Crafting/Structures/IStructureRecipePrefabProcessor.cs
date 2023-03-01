using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007C2 RID: 1986
	[Token(Token = "0x20007C2")]
	public interface IStructureRecipePrefabProcessor
	{
		// Token: 0x0600346E RID: 13422
		[Token(Token = "0x600346E")]
		void ValidatePrefabs(GameObject nodePrefab, GameObject builtPrefab);
	}
}

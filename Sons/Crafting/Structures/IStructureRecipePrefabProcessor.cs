using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006CD RID: 1741
	[Token(Token = "0x20006CD")]
	public interface IStructureRecipePrefabProcessor
	{
		// Token: 0x06002DE8 RID: 11752
		[Token(Token = "0x6002DE8")]
		void ValidatePrefabs(GameObject nodePrefab, GameObject builtPrefab);
	}
}

using System;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200012B RID: 299
	[Token(Token = "0x200012B")]
	[CreateAssetMenu(menuName = "Sons/Construction/ScrewPrefabProcessor")]
	public class ScrewPrefabProcessor : ScriptableObject, IStructureRecipePrefabProcessor
	{
		// Token: 0x06000837 RID: 2103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void ValidatePrefabs(GameObject nodePrefab, GameObject builtPrefab)
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public ScrewPrefabProcessor()
		{
		}
	}
}

using System;
using System.Collections.Generic;
using Construction;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Construction.Branching
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[CreateAssetMenu(menuName = "Sons/Construction/Branching/BranchingElementDatabase")]
	public class BranchingElementDatabase : ScriptableObject
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2D5CB60", Offset = "0x2D5B160", VA = "0x182D5CB60")]
		public bool Accepts(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2D5CB80", Offset = "0x2D5B180", VA = "0x182D5CB80")]
		public bool TryGet(ItemInstance itemInstance, out BranchingElementData foundElement)
		{
			return default(bool);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2D5CE00", Offset = "0x2D5B400", VA = "0x182D5CE00")]
		public bool TryGet(StructureElement prefab, out BranchingElementData foundElement)
		{
			return default(bool);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public BranchingElementDatabase()
		{
		}

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<BranchingElementDataAsset> _itemAssets;
	}
}

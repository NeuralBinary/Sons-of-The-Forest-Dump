using System;
using System.Collections.Generic;
using Construction;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Construction.Branching
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[AddComponentMenu("Sons/Construction/Branching/BranchingController")]
	public class BranchingController : MonoBehaviour
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2D5BE30", Offset = "0x2D5A430", VA = "0x182D5BE30")]
		public IBranchingAction GetAction(ItemData item, IAimRayProvider aimRayProvider, StructureElement element)
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2D5BF40", Offset = "0x2D5A540", VA = "0x182D5BF40")]
		public void ListAvailableActions(StructureElement element, List<IBranchingAction> actions)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2D5C050", Offset = "0x2D5A650", VA = "0x182D5C050")]
		public bool TryGetAvailableAction(StructureElement element, int actionNum, out IBranchingAction action)
		{
			return default(bool);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2D5C290", Offset = "0x2D5A890", VA = "0x182D5C290")]
		public BranchingController()
		{
		}

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_workableItemDatabase")]
		private BranchingElementDatabase _elementDatabase;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x28")]
		private readonly EquipItemBranchingAction _equipItemAction;
	}
}

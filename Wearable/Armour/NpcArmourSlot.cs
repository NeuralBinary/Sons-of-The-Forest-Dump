using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Characters;
using UnityEngine;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005C1 RID: 1473
	[Token(Token = "0x20005C1")]
	[AddComponentMenu("Sons/Wearable/Armour/NPC Armour Slot")]
	public class NpcArmourSlot : MonoBehaviour, IVariationResult
	{
		// Token: 0x060025C4 RID: 9668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C4")]
		[Address(RVA = "0x2DA6C90", Offset = "0x2DA5C90", VA = "0x182DA6C90", Slot = "4")]
		public void OnActivated()
		{
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025C5")]
		[Address(RVA = "0x2DA69A0", Offset = "0x2DA59A0", VA = "0x182DA69A0")]
		private NpcArmourSlot.ArmorTierPiece GetActiveTier(int slotTier)
		{
			return null;
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x0000B1C0 File Offset: 0x000093C0
		[Token(Token = "0x60025C6")]
		[Address(RVA = "0x2DA6790", Offset = "0x2DA5790", VA = "0x182DA6790")]
		private int ChooseSlotTier(int maxTier)
		{
			return default(int);
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C7")]
		[Address(RVA = "0x2DA6D50", Offset = "0x2DA5D50", VA = "0x182DA6D50")]
		private void SpawnArmourPiece(NpcArmourSlot.ArmorTierPiece activeTier)
		{
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C8")]
		[Address(RVA = "0x2DA6D40", Offset = "0x2DA5D40", VA = "0x182DA6D40", Slot = "5")]
		public void OnDeactivated()
		{
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C9")]
		[Address(RVA = "0x2DA6B10", Offset = "0x2DA5B10", VA = "0x182DA6B10")]
		private void HideAll()
		{
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CA")]
		[Address(RVA = "0x2DA6F10", Offset = "0x2DA5F10", VA = "0x182DA6F10")]
		public NpcArmourSlot()
		{
		}

		// Token: 0x0400221A RID: 8730
		[Token(Token = "0x400221A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private NpcArmourSystem _armourSystem;

		// Token: 0x0400221B RID: 8731
		[Token(Token = "0x400221B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _slotEnabled;

		// Token: 0x0400221C RID: 8732
		[Token(Token = "0x400221C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<NpcArmourSlot.ArmorTierPiece> _armorTierPieces;

		// Token: 0x0400221D RID: 8733
		[Token(Token = "0x400221D")]
		[FieldOffset(Offset = "0x38")]
		private int _actorSeed;

		// Token: 0x020005C2 RID: 1474
		[Token(Token = "0x20005C2")]
		[Serializable]
		private class ArmorTierPiece
		{
			// Token: 0x060025CB RID: 9675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025CB")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ArmorTierPiece()
			{
			}

			// Token: 0x0400221E RID: 8734
			[Token(Token = "0x400221E")]
			[FieldOffset(Offset = "0x10")]
			public NpcArmourSystem.Tier Tier;

			// Token: 0x0400221F RID: 8735
			[Token(Token = "0x400221F")]
			[FieldOffset(Offset = "0x18")]
			public NpcArmourPiece ArmourPiece;

			// Token: 0x04002220 RID: 8736
			[Token(Token = "0x4002220")]
			[FieldOffset(Offset = "0x20")]
			public NpcArmourPiece PieceInstance;
		}
	}
}

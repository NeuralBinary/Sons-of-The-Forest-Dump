using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Characters;
using UnityEngine;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005D2 RID: 1490
	[Token(Token = "0x20005D2")]
	[AddComponentMenu("Sons/Wearable/Armour/NPC Armour Slot")]
	public class NpcArmourSlot : MonoBehaviour, IVariationResult
	{
		// Token: 0x060026C8 RID: 9928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C8")]
		[Address(RVA = "0x33B4BB0", Offset = "0x33B31B0", VA = "0x1833B4BB0", Slot = "4")]
		public void OnActivated()
		{
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C9")]
		[Address(RVA = "0x33B4CA0", Offset = "0x33B32A0", VA = "0x1833B4CA0")]
		private NpcArmourSlot.ArmorTierPiece GetActiveTier(int slotTier)
		{
			return null;
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[Token(Token = "0x60026CA")]
		[Address(RVA = "0x33B4E40", Offset = "0x33B3440", VA = "0x1833B4E40")]
		private int ChooseSlotTier(int maxTier)
		{
			return 0;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CB")]
		[Address(RVA = "0x33B5090", Offset = "0x33B3690", VA = "0x1833B5090")]
		private void SpawnArmourPiece(NpcArmourSlot.ArmorTierPiece activeTier)
		{
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CC")]
		[Address(RVA = "0x33B5490", Offset = "0x33B3A90", VA = "0x1833B5490", Slot = "5")]
		public void OnDeactivated()
		{
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CD")]
		[Address(RVA = "0x33B54A0", Offset = "0x33B3AA0", VA = "0x1833B54A0")]
		private void HideAll()
		{
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CE")]
		[Address(RVA = "0x33B56C0", Offset = "0x33B3CC0", VA = "0x1833B56C0")]
		public NpcArmourSlot()
		{
		}

		// Token: 0x040022F7 RID: 8951
		[Token(Token = "0x40022F7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private NpcArmourSystem _armourSystem;

		// Token: 0x040022F8 RID: 8952
		[Token(Token = "0x40022F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _slotEnabled;

		// Token: 0x040022F9 RID: 8953
		[Token(Token = "0x40022F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<NpcArmourSlot.ArmorTierPiece> _armorTierPieces;

		// Token: 0x040022FA RID: 8954
		[Token(Token = "0x40022FA")]
		[FieldOffset(Offset = "0x38")]
		private int _actorSeed;

		// Token: 0x020005D3 RID: 1491
		[Token(Token = "0x20005D3")]
		[Serializable]
		private class ArmorTierPiece
		{
			// Token: 0x060026CF RID: 9935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026CF")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ArmorTierPiece()
			{
			}

			// Token: 0x040022FB RID: 8955
			[Token(Token = "0x40022FB")]
			[FieldOffset(Offset = "0x10")]
			public NpcArmourSystem.Tier Tier;

			// Token: 0x040022FC RID: 8956
			[Token(Token = "0x40022FC")]
			[FieldOffset(Offset = "0x18")]
			public NpcArmourPiece ArmourPiece;

			// Token: 0x040022FD RID: 8957
			[Token(Token = "0x40022FD")]
			[FieldOffset(Offset = "0x20")]
			public NpcArmourPiece PieceInstance;
		}
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Atmosphere;
using Sons.Characters;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005C3 RID: 1475
	[Token(Token = "0x20005C3")]
	[AddComponentMenu("Sons/Wearable/Armour/NpcArmourSystem")]
	public class NpcArmourSystem : MonoBehaviour, IArmorSystem, ISeasonsReceiver
	{
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x0000B1D8 File Offset: 0x000093D8
		[Token(Token = "0x1700051A")]
		public NpcArmourSystem.Tier CurrentTier
		{
			[Token(Token = "0x60025CC")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return NpcArmourSystem.Tier.Zero;
			}
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CD")]
		[Address(RVA = "0x2DA7250", Offset = "0x2DA6250", VA = "0x182DA7250")]
		private void OnEnable()
		{
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CE")]
		[Address(RVA = "0x2DA7200", Offset = "0x2DA6200", VA = "0x182DA7200")]
		private void OnDisable()
		{
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CF")]
		[Address(RVA = "0x2DA7880", Offset = "0x2DA6880", VA = "0x182DA7880", Slot = "4")]
		public void SetupArmor(float level, int actorSeed)
		{
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D0")]
		[Address(RVA = "0x2DA7510", Offset = "0x2DA6510", VA = "0x182DA7510")]
		private void SetCurrentTier(NpcArmourSystem.Tier currentTier, int actorSeed)
		{
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D1")]
		[Address(RVA = "0x2DA72A0", Offset = "0x2DA62A0", VA = "0x182DA72A0")]
		private void RemoveInactiveArmorPieces()
		{
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D2")]
		[Address(RVA = "0x2DA7900", Offset = "0x2DA6900", VA = "0x182DA7900")]
		private void SetupArmourPiece(NpcArmourSystem.ArmourSlots armourSlot, NpcArmourPiece armourPiece)
		{
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x0000B1F0 File Offset: 0x000093F0
		[Token(Token = "0x60025D3")]
		[Address(RVA = "0x2DA6F90", Offset = "0x2DA5F90", VA = "0x182DA6F90")]
		private static bool GetDamageNode(Transform parentTarget, out DamageNode result, bool onlyChildren = false)
		{
			return default(bool);
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x0000B208 File Offset: 0x00009408
		[Token(Token = "0x60025D4")]
		[Address(RVA = "0x2DA7140", Offset = "0x2DA6140", VA = "0x182DA7140")]
		public int GetNextSeed()
		{
			return default(int);
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D5")]
		[Address(RVA = "0x2DA74F0", Offset = "0x2DA64F0", VA = "0x182DA74F0", Slot = "5")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D6")]
		[Address(RVA = "0x2DA7A50", Offset = "0x2DA6A50", VA = "0x182DA7A50")]
		public NpcArmourSystem()
		{
		}

		// Token: 0x04002221 RID: 8737
		[Token(Token = "0x4002221")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private NpcArmourSystem.Tier _currentTier;

		// Token: 0x04002222 RID: 8738
		[Token(Token = "0x4002222")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InstanceVariation _instanceVariation;

		// Token: 0x04002223 RID: 8739
		[Token(Token = "0x4002223")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<NpcArmourSystem.ArmourSlots> _armourSlots;

		// Token: 0x04002224 RID: 8740
		[Token(Token = "0x4002224")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _animationRoot;

		// Token: 0x04002225 RID: 8741
		[Token(Token = "0x4002225")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Armor Piece Rolls at Tier 1")]
		private int _repeatRollBase;

		// Token: 0x04002226 RID: 8742
		[Token(Token = "0x4002226")]
		[FieldOffset(Offset = "0x48")]
		private Random _random;

		// Token: 0x04002227 RID: 8743
		[Token(Token = "0x4002227")]
		[FieldOffset(Offset = "0x50")]
		private bool _isWinter;

		// Token: 0x020005C4 RID: 1476
		[Token(Token = "0x20005C4")]
		public enum Tier
		{
			// Token: 0x04002229 RID: 8745
			[Token(Token = "0x4002229")]
			Zero,
			// Token: 0x0400222A RID: 8746
			[Token(Token = "0x400222A")]
			One,
			// Token: 0x0400222B RID: 8747
			[Token(Token = "0x400222B")]
			Two,
			// Token: 0x0400222C RID: 8748
			[Token(Token = "0x400222C")]
			Three
		}

		// Token: 0x020005C5 RID: 1477
		[Token(Token = "0x20005C5")]
		[Serializable]
		private class ArmourSlots
		{
			// Token: 0x060025D7 RID: 9687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025D7")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ArmourSlots()
			{
			}

			// Token: 0x0400222D RID: 8749
			[Token(Token = "0x400222D")]
			[FieldOffset(Offset = "0x10")]
			public GameObject _slot;

			// Token: 0x0400222E RID: 8750
			[Token(Token = "0x400222E")]
			[FieldOffset(Offset = "0x18")]
			public Transform _bone;

			// Token: 0x0400222F RID: 8751
			[Token(Token = "0x400222F")]
			[FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public NpcArmourPiece _piece;
		}
	}
}

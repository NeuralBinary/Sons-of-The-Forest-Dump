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
	// Token: 0x020005D4 RID: 1492
	[Token(Token = "0x20005D4")]
	[AddComponentMenu("Sons/Wearable/Armour/NpcArmourSystem")]
	public class NpcArmourSystem : MonoBehaviour, IArmorSystem, ISeasonsReceiver
	{
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		[Token(Token = "0x1700052F")]
		public NpcArmourSystem.Tier CurrentTier
		{
			[Token(Token = "0x60026D0")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return NpcArmourSystem.Tier.Zero;
			}
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D1")]
		[Address(RVA = "0x33B57A0", Offset = "0x33B3DA0", VA = "0x1833B57A0")]
		private void OnEnable()
		{
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x33B57F0", Offset = "0x33B3DF0", VA = "0x1833B57F0")]
		private void OnDisable()
		{
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x33B5840", Offset = "0x33B3E40", VA = "0x1833B5840", Slot = "4")]
		public void SetupArmor(float level, int actorSeed)
		{
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D4")]
		[Address(RVA = "0x33B58C0", Offset = "0x33B3EC0", VA = "0x1833B58C0")]
		private void SetCurrentTier(NpcArmourSystem.Tier currentTier, int actorSeed)
		{
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D5")]
		[Address(RVA = "0x33B5D60", Offset = "0x33B4360", VA = "0x1833B5D60")]
		private void RemoveInactiveArmorPieces()
		{
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D6")]
		[Address(RVA = "0x33B6040", Offset = "0x33B4640", VA = "0x1833B6040")]
		private void SetupArmourPiece(NpcArmourSystem.ArmourSlots armourSlot, NpcArmourPiece armourPiece)
		{
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		[Token(Token = "0x60026D7")]
		[Address(RVA = "0x33B6330", Offset = "0x33B4930", VA = "0x1833B6330")]
		private static bool GetDamageNode(Transform parentTarget, out DamageNode result, bool onlyChildren = false)
		{
			return default(bool);
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[Token(Token = "0x60026D8")]
		[Address(RVA = "0x33B67A0", Offset = "0x33B4DA0", VA = "0x1833B67A0")]
		public int GetNextSeed()
		{
			return 0;
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D9")]
		[Address(RVA = "0x33B68A0", Offset = "0x33B4EA0", VA = "0x1833B68A0", Slot = "5")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x33B68C0", Offset = "0x33B4EC0", VA = "0x1833B68C0")]
		public NpcArmourSystem()
		{
		}

		// Token: 0x040022FE RID: 8958
		[Token(Token = "0x40022FE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private NpcArmourSystem.Tier _currentTier;

		// Token: 0x040022FF RID: 8959
		[Token(Token = "0x40022FF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InstanceVariation _instanceVariation;

		// Token: 0x04002300 RID: 8960
		[Token(Token = "0x4002300")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<NpcArmourSystem.ArmourSlots> _armourSlots;

		// Token: 0x04002301 RID: 8961
		[Token(Token = "0x4002301")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _animationRoot;

		// Token: 0x04002302 RID: 8962
		[Token(Token = "0x4002302")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Armor Piece Rolls at Tier 1")]
		private int _repeatRollBase;

		// Token: 0x04002303 RID: 8963
		[Token(Token = "0x4002303")]
		[FieldOffset(Offset = "0x48")]
		private System.Random _random;

		// Token: 0x04002304 RID: 8964
		[Token(Token = "0x4002304")]
		[FieldOffset(Offset = "0x50")]
		private bool _isWinter;

		// Token: 0x020005D5 RID: 1493
		[Token(Token = "0x20005D5")]
		public enum Tier
		{
			// Token: 0x04002306 RID: 8966
			[Token(Token = "0x4002306")]
			Zero,
			// Token: 0x04002307 RID: 8967
			[Token(Token = "0x4002307")]
			One,
			// Token: 0x04002308 RID: 8968
			[Token(Token = "0x4002308")]
			Two,
			// Token: 0x04002309 RID: 8969
			[Token(Token = "0x4002309")]
			Three
		}

		// Token: 0x020005D6 RID: 1494
		[Token(Token = "0x20005D6")]
		[Serializable]
		private class ArmourSlots
		{
			// Token: 0x060026DB RID: 9947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026DB")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ArmourSlots()
			{
			}

			// Token: 0x0400230A RID: 8970
			[Token(Token = "0x400230A")]
			[FieldOffset(Offset = "0x10")]
			public GameObject _slot;

			// Token: 0x0400230B RID: 8971
			[Token(Token = "0x400230B")]
			[FieldOffset(Offset = "0x18")]
			public Transform _bone;

			// Token: 0x0400230C RID: 8972
			[Token(Token = "0x400230C")]
			[FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public NpcArmourPiece _piece;
		}
	}
}

using System;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005D0 RID: 1488
	[Token(Token = "0x20005D0")]
	[AddComponentMenu("Sons/Wearable/Armour/NPC Armour Piece")]
	public class NpcArmourPiece : MonoBehaviour
	{
		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060026BE RID: 9918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052A")]
		public DamageNode DamageNode
		{
			[Token(Token = "0x60026BE")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052B")]
		public Collider GetCollider
		{
			[Token(Token = "0x60026BF")]
			[Address(RVA = "0x33B3970", Offset = "0x33B1F70", VA = "0x1833B3970")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x33B3990", Offset = "0x33B1F90", VA = "0x1833B3990")]
		private void Start()
		{
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C1")]
		[Address(RVA = "0x33B3C10", Offset = "0x33B2210", VA = "0x1833B3C10")]
		private void OnBreak(IBreakSender sender, IImpactData impactData)
		{
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x33B46A0", Offset = "0x33B2CA0", VA = "0x1833B46A0")]
		public void RemapSkinnedMeshes(Transform animationRoot)
		{
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C3")]
		[Address(RVA = "0x33B4B40", Offset = "0x33B3140", VA = "0x1833B4B40")]
		public NpcArmourPiece()
		{
		}

		// Token: 0x040022EF RID: 8943
		[Token(Token = "0x40022EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x040022F0 RID: 8944
		[Token(Token = "0x40022F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _brokenPrefab;

		// Token: 0x040022F1 RID: 8945
		[Token(Token = "0x40022F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private NpcArmourSettings _armourSettings;

		// Token: 0x040022F2 RID: 8946
		[Token(Token = "0x40022F2")]
		[FieldOffset(Offset = "0x38")]
		private readonly float _popOffForce;

		// Token: 0x040022F3 RID: 8947
		[Token(Token = "0x40022F3")]
		[FieldOffset(Offset = "0x3C")]
		private readonly float _maxPopOffForce;
	}
}

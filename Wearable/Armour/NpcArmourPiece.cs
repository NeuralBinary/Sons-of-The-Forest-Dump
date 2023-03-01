using System;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005BF RID: 1471
	[Token(Token = "0x20005BF")]
	[AddComponentMenu("Sons/Wearable/Armour/NPC Armour Piece")]
	public class NpcArmourPiece : MonoBehaviour
	{
		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000516")]
		public DamageNode DamageNode
		{
			[Token(Token = "0x60025BB")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000517")]
		public Collider GetCollider
		{
			[Token(Token = "0x60025BC")]
			[Address(RVA = "0x2DA6750", Offset = "0x2DA5750", VA = "0x182DA6750")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BD")]
		[Address(RVA = "0x2DA6620", Offset = "0x2DA5620", VA = "0x182DA6620")]
		private void Start()
		{
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BE")]
		[Address(RVA = "0x2DA5C70", Offset = "0x2DA4C70", VA = "0x182DA5C70")]
		private void OnBreak(IBreakSender sender, IImpactData impactData)
		{
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BF")]
		[Address(RVA = "0x2DA6350", Offset = "0x2DA5350", VA = "0x182DA6350")]
		public void RemapSkinnedMeshes(Transform animationRoot)
		{
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C0")]
		[Address(RVA = "0x2DA6730", Offset = "0x2DA5730", VA = "0x182DA6730")]
		public NpcArmourPiece()
		{
		}

		// Token: 0x04002213 RID: 8723
		[Token(Token = "0x4002213")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x04002214 RID: 8724
		[Token(Token = "0x4002214")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _brokenPrefab;

		// Token: 0x04002215 RID: 8725
		[Token(Token = "0x4002215")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private NpcArmourSettings _armourSettings;

		// Token: 0x04002216 RID: 8726
		[Token(Token = "0x4002216")]
		[FieldOffset(Offset = "0x38")]
		private readonly float _popOffForce;

		// Token: 0x04002217 RID: 8727
		[Token(Token = "0x4002217")]
		[FieldOffset(Offset = "0x3C")]
		private readonly float _maxPopOffForce;
	}
}

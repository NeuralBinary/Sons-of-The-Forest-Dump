using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Physics
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	public class IgnoreCollision : MonoBehaviour
	{
		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xA978E0", Offset = "0xA95EE0", VA = "0x180A978E0")]
		public static void RegisterPlayerCollision(List<Collider> colliders)
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xA97A20", Offset = "0xA96020", VA = "0x180A97A20")]
		private void IgnoreCollider(Collider eachCollider)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xA97CB0", Offset = "0xA962B0", VA = "0x180A97CB0")]
		private void IgnoreColliders(List<Collider> colliders)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xA97DF0", Offset = "0xA963F0", VA = "0x180A97DF0")]
		private void OnValidate()
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xA97F50", Offset = "0xA96550", VA = "0x180A97F50")]
		private void Start()
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xA98140", Offset = "0xA96740", VA = "0x180A98140")]
		private void ConvertToList()
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0xA98330", Offset = "0xA96930", VA = "0x180A98330")]
		private void IgnorePlayer()
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x6000301")]
		[Address(RVA = "0xA98390", Offset = "0xA96990", VA = "0x180A98390")]
		private bool VerifyPlayerColliders()
		{
			return default(bool);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000302")]
		[Address(RVA = "0xA98560", Offset = "0xA96B60", VA = "0x180A98560")]
		private void IgnoreTerrain()
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x6000303")]
		[Address(RVA = "0xA985A0", Offset = "0xA96BA0", VA = "0x180A985A0")]
		private bool VerifyTerrainCollider()
		{
			return default(bool);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000304")]
		[Address(RVA = "0xA98840", Offset = "0xA96E40", VA = "0x180A98840")]
		private void OnDisable()
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public IgnoreCollision()
		{
		}

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private Collider _target;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private bool _convertedToList;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Collider> _targets;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Collider> _colliders;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _ignoreTerrain;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _ignorePlayer;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TerrainCollider _terrainCollider;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _autoCollectInChildren;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x0")]
		private static List<Collider> _playerCollision;
	}
}

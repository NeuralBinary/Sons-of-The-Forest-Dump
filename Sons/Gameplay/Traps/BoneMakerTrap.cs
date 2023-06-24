using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Traps
{
	// Token: 0x0200083B RID: 2107
	[Token(Token = "0x200083B")]
	[AddComponentMenu("Sons/Gameplay/Traps/BoneMakerTrap")]
	public class BoneMakerTrap : BaseTrapController
	{
		// Token: 0x06003BB5 RID: 15285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB5")]
		[Address(RVA = "0x35934A0", Offset = "0x3591AA0", VA = "0x1835934A0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x00012288 File Offset: 0x00010488
		[Token(Token = "0x6003BB6")]
		[Address(RVA = "0x3593720", Offset = "0x3591D20", VA = "0x183593720", Slot = "27")]
		protected override bool TryTriggerTrapMechanics()
		{
			return default(bool);
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB7")]
		[Address(RVA = "0x3593D30", Offset = "0x3592330", VA = "0x183593D30", Slot = "28")]
		protected override void OnReset()
		{
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB8")]
		[Address(RVA = "0x3593EE0", Offset = "0x35924E0", VA = "0x183593EE0")]
		public BoneMakerTrap()
		{
		}

		// Token: 0x040032B5 RID: 12981
		[Token(Token = "0x40032B5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _fireObject;

		// Token: 0x040032B6 RID: 12982
		[Token(Token = "0x40032B6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _ragdollSnapTransform;

		// Token: 0x040032B7 RID: 12983
		[Token(Token = "0x40032B7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SphereCollider _killArea;

		// Token: 0x040032B8 RID: 12984
		[Token(Token = "0x40032B8")]
		[FieldOffset(Offset = "0x98")]
		private Rigidbody _ragdollRigidbody;
	}
}

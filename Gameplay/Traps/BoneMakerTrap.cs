using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Traps
{
	// Token: 0x020006EE RID: 1774
	[Token(Token = "0x20006EE")]
	[AddComponentMenu("Sons/Gameplay/Traps/BoneMakerTrap")]
	public class BoneMakerTrap : BaseTrapController
	{
		// Token: 0x06002DC8 RID: 11720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC8")]
		[Address(RVA = "0x2E036E0", Offset = "0x2E026E0", VA = "0x182E036E0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x0000D038 File Offset: 0x0000B238
		[Token(Token = "0x6002DC9")]
		[Address(RVA = "0x2E038C0", Offset = "0x2E028C0", VA = "0x182E038C0", Slot = "26")]
		protected override bool TryTriggerTrapMechanics()
		{
			return default(bool);
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCA")]
		[Address(RVA = "0x2E03810", Offset = "0x2E02810", VA = "0x182E03810", Slot = "27")]
		protected override void OnReset()
		{
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCB")]
		[Address(RVA = "0x2E03CB0", Offset = "0x2E02CB0", VA = "0x182E03CB0")]
		public BoneMakerTrap()
		{
		}

		// Token: 0x040028D6 RID: 10454
		[Token(Token = "0x40028D6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _fireObject;

		// Token: 0x040028D7 RID: 10455
		[Token(Token = "0x40028D7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _ragdollSnapTransform;

		// Token: 0x040028D8 RID: 10456
		[Token(Token = "0x40028D8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SphereCollider _killArea;

		// Token: 0x040028D9 RID: 10457
		[Token(Token = "0x40028D9")]
		[FieldOffset(Offset = "0x90")]
		private Rigidbody _ragdollRigidbody;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000891 RID: 2193
	[Token(Token = "0x2000891")]
	public class IkFakeBone : MonoBehaviour, IIkFakeBone
	{
		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06003B2D RID: 15149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000738")]
		public Transform TipTransform
		{
			[Token(Token = "0x6003B2D")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06003B2E RID: 15150 RVA: 0x000113A0 File Offset: 0x0000F5A0
		[Token(Token = "0x17000739")]
		public IkLimbs Limb
		{
			[Token(Token = "0x6003B2E")]
			[Address(RVA = "0x589ED0", Offset = "0x588ED0", VA = "0x180589ED0", Slot = "5")]
			get
			{
				return IkLimbs.RightHand;
			}
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B2F")]
		[Address(RVA = "0x2EFA8D0", Offset = "0x2EF98D0", VA = "0x182EFA8D0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B30")]
		[Address(RVA = "0x2EFAA00", Offset = "0x2EF9A00", VA = "0x182EFAA00")]
		private void OnEnable()
		{
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B31")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public IkFakeBone()
		{
		}

		// Token: 0x04003F8E RID: 16270
		[Token(Token = "0x4003F8E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _tipTransform;

		// Token: 0x04003F8F RID: 16271
		[Token(Token = "0x4003F8F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private IkLimbs _limb;

		// Token: 0x04003F90 RID: 16272
		[Token(Token = "0x4003F90")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private IkTargetsController _controller;
	}
}

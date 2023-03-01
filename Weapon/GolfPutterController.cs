using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000847 RID: 2119
	[Token(Token = "0x2000847")]
	[AddComponentMenu("Sons/Weapon/GolfPutterController")]
	public class GolfPutterController : GenericMeleeWeaponController
	{
		// Token: 0x0600389D RID: 14493 RVA: 0x00010968 File Offset: 0x0000EB68
		[Token(Token = "0x600389D")]
		[Address(RVA = "0x2ECCCD0", Offset = "0x2ECBCD0", VA = "0x182ECCCD0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389E")]
		[Address(RVA = "0x2ECCF10", Offset = "0x2ECBF10", VA = "0x182ECCF10", Slot = "28")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389F")]
		[Address(RVA = "0x2ECD030", Offset = "0x2ECC030", VA = "0x182ECD030", Slot = "29")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x2ECCD90", Offset = "0x2ECBD90", VA = "0x182ECCD90")]
		private void OnActivated()
		{
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A1")]
		[Address(RVA = "0x2ECCE00", Offset = "0x2ECBE00", VA = "0x182ECCE00")]
		private void OnDeactivated()
		{
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A2")]
		[Address(RVA = "0x2EAE660", Offset = "0x2EAD660", VA = "0x182EAE660")]
		public GolfPutterController()
		{
		}
	}
}

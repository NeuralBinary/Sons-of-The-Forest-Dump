using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008D1 RID: 2257
	[Token(Token = "0x20008D1")]
	[AddComponentMenu("Sons/Items/RevolverWeaponController")]
	public class RevolverWeaponController : RangedWeaponController
	{
		// Token: 0x06004092 RID: 16530 RVA: 0x00013B30 File Offset: 0x00011D30
		[Token(Token = "0x6004092")]
		[Address(RVA = "0x35FFE70", Offset = "0x35FE470", VA = "0x1835FFE70", Slot = "26")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x00013B48 File Offset: 0x00011D48
		[Token(Token = "0x6004093")]
		[Address(RVA = "0x3600000", Offset = "0x35FE600", VA = "0x183600000", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x00013B60 File Offset: 0x00011D60
		[Token(Token = "0x6004094")]
		[Address(RVA = "0x3600170", Offset = "0x35FE770", VA = "0x183600170", Slot = "24")]
		protected override bool CanAim()
		{
			return default(bool);
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x00013B78 File Offset: 0x00011D78
		[Token(Token = "0x6004095")]
		[Address(RVA = "0x35E13D0", Offset = "0x35DF9D0", VA = "0x1835E13D0", Slot = "35")]
		protected override bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004096")]
		[Address(RVA = "0x35DD460", Offset = "0x35DBA60", VA = "0x1835DD460")]
		public RevolverWeaponController()
		{
		}
	}
}

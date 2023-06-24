using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008B7 RID: 2231
	[Token(Token = "0x20008B7")]
	[AddComponentMenu("Sons/Weapon/GolfPutterController")]
	public class GolfPutterController : GenericMeleeWeaponController
	{
		// Token: 0x06003FB5 RID: 16309 RVA: 0x00013728 File Offset: 0x00011928
		[Token(Token = "0x6003FB5")]
		[Address(RVA = "0x35ECA50", Offset = "0x35EB050", VA = "0x1835ECA50", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB6")]
		[Address(RVA = "0x35ECB00", Offset = "0x35EB100", VA = "0x1835ECB00", Slot = "28")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB7")]
		[Address(RVA = "0x35ECC80", Offset = "0x35EB280", VA = "0x1835ECC80", Slot = "29")]
		protected override void UnregisterEvents()
		{
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB8")]
		[Address(RVA = "0x35ECE00", Offset = "0x35EB400", VA = "0x1835ECE00")]
		private void OnActivated()
		{
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB9")]
		[Address(RVA = "0x35ECE70", Offset = "0x35EB470", VA = "0x1835ECE70")]
		private void OnDeactivated()
		{
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBA")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public GolfPutterController()
		{
		}
	}
}

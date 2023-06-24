using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	public class LightningBeamSpellScript : LightningSpellScript
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000181")]
		[Address(RVA = "0xA4D510", Offset = "0xA4BB10", VA = "0x180A4D510")]
		private void CheckCollision()
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000182")]
		[Address(RVA = "0xA4E010", Offset = "0xA4C610", VA = "0x180A4E010", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000183")]
		[Address(RVA = "0xA4E040", Offset = "0xA4C640", VA = "0x180A4E040", Slot = "6")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000184")]
		[Address(RVA = "0xA4E060", Offset = "0xA4C660", VA = "0x180A4E060", Slot = "8")]
		protected override void OnCastSpell()
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA4E090", Offset = "0xA4C690", VA = "0x180A4E090", Slot = "9")]
		protected override void OnStopSpell()
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000186")]
		[Address(RVA = "0xA4E0C0", Offset = "0xA4C6C0", VA = "0x180A4E0C0")]
		public LightningBeamSpellScript()
		{
		}

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0xA8")]
		[Header("Beam")]
		[Tooltip("The lightning path script creating the beam of lightning")]
		public LightningBoltPathScriptBase LightningPathScript;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("Give the end point some randomization")]
		public float EndPointRandomization;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		public Action<RaycastHit> CollisionCallback;
	}
}

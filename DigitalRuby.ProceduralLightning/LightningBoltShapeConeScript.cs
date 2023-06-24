using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public class LightningBoltShapeConeScript : LightningBoltPrefabScriptBase
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011E")]
		[Address(RVA = "0xA433E0", Offset = "0xA419E0", VA = "0x180A433E0", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011F")]
		[Address(RVA = "0xA437C0", Offset = "0xA41DC0", VA = "0x180A437C0")]
		public LightningBoltShapeConeScript()
		{
		}

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x1F0")]
		[Header("Lightning Cone Properties")]
		[Tooltip("Radius at base of cone where lightning can emit from")]
		public float InnerRadius;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x1F4")]
		[Tooltip("Radius at outer part of the cone where lightning emits to")]
		public float OuterRadius;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x1F8")]
		[Tooltip("The length of the cone from the center of the inner and outer circle")]
		public float Length;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public class LightningBoltShapeSphereScript : LightningBoltPrefabScriptBase
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000120")]
		[Address(RVA = "0xA437F0", Offset = "0xA41DF0", VA = "0x180A437F0", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000121")]
		[Address(RVA = "0xA43960", Offset = "0xA41F60", VA = "0x180A43960")]
		public LightningBoltShapeSphereScript()
		{
		}

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x1F0")]
		[Header("Lightning Sphere Properties")]
		[Tooltip("Radius inside the sphere where lightning can emit from")]
		public float InnerRadius;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x1F4")]
		[Tooltip("Radius of the sphere")]
		public float Radius;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public class LightningBoltPrefabScript : LightningBoltPrefabScriptBase
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA3E1E0", Offset = "0xA3C7E0", VA = "0x180A3E1E0", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xA3E540", Offset = "0xA3CB40", VA = "0x180A3E540")]
		public LightningBoltPrefabScript()
		{
		}

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x1F0")]
		[Tooltip("The source game object, can be null")]
		[Header("Start/end")]
		public GameObject Source;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x1F8")]
		[Tooltip("The destination game object, can be null")]
		public GameObject Destination;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x200")]
		[Tooltip("X, Y and Z for variance from the start point. Use positive values.")]
		public Vector3 StartVariance;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x20C")]
		[Tooltip("X, Y and Z for variance from the end point. Use positive values.")]
		public Vector3 EndVariance;
	}
}

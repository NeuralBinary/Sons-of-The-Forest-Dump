using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public class LightningGeneratorPath : LightningGenerator
	{
		// Token: 0x06000145 RID: 325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000145")]
		[Address(RVA = "0xA46D30", Offset = "0xA45330", VA = "0x180A46D30")]
		public void GenerateLightningBoltPath(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters parameters)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000146")]
		[Address(RVA = "0xA47670", Offset = "0xA45C70", VA = "0x180A47670", Slot = "4")]
		protected override void OnGenerateLightningBolt(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters parameters)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000147")]
		[Address(RVA = "0xA476D0", Offset = "0xA45CD0", VA = "0x180A476D0")]
		public LightningGeneratorPath()
		{
		}

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LightningGeneratorPath PathGeneratorInstance;
	}
}

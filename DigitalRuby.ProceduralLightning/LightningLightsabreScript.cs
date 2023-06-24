using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class LightningLightsabreScript : LightningBoltPrefabScript
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA477E0", Offset = "0xA45DE0", VA = "0x180A477E0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014B")]
		[Address(RVA = "0xA477F0", Offset = "0xA45DF0", VA = "0x180A477F0", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA47AB0", Offset = "0xA460B0", VA = "0x180A47AB0")]
		public bool TurnOn(bool value)
		{
			return default(bool);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA47D90", Offset = "0xA46390", VA = "0x180A47D90")]
		public void TurnOnGUI(bool value)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA47DA0", Offset = "0xA463A0", VA = "0x180A47DA0")]
		public LightningLightsabreScript()
		{
		}

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x218")]
		[Tooltip("Height of the blade")]
		[Header("Lightsabre Properties")]
		public float BladeHeight;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x21C")]
		[Tooltip("How long it takes to turn the lightsabre on and off")]
		public float ActivationTime;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x220")]
		[Tooltip("Sound to play when the lightsabre turns on")]
		public AudioSource StartSound;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x228")]
		[Tooltip("Sound to play when the lightsabre turns off")]
		public AudioSource StopSound;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x230")]
		[Tooltip("Sound to play when the lightsabre stays on")]
		public AudioSource ConstantSound;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x238")]
		private int state;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x23C")]
		private Vector3 bladeStart;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x248")]
		private Vector3 bladeDir;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x254")]
		private float bladeTime;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x258")]
		private float bladeIntensity;
	}
}

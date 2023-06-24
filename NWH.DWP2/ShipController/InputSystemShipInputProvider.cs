using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.ShipController
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public class InputSystemShipInputProvider : ShipInputProvider
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x27113A0", Offset = "0x270F9A0", VA = "0x1827113A0")]
		public new void Awake()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2711460", Offset = "0x270FA60", VA = "0x182711460")]
		public void Update()
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0", Slot = "7")]
		public override float Throttle()
		{
			return 0f;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860", Slot = "8")]
		public override float Throttle2()
		{
			return 0f;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0", Slot = "9")]
		public override float Throttle3()
		{
			return 0f;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320", Slot = "10")]
		public override float Throttle4()
		{
			return 0f;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80", Slot = "6")]
		public override float Steering()
		{
			return 0f;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570", Slot = "12")]
		public override float BowThruster()
		{
			return 0f;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70", Slot = "11")]
		public override float SternThruster()
		{
			return 0f;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x23B72F0", Offset = "0x23B58F0", VA = "0x1823B72F0", Slot = "13")]
		public override float SubmarineDepth()
		{
			return 0f;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x27118A0", Offset = "0x270FEA0", VA = "0x1827118A0", Slot = "14")]
		public override bool EngineStartStop()
		{
			return default(bool);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2711930", Offset = "0x270FF30", VA = "0x182711930", Slot = "15")]
		public override bool Anchor()
		{
			return default(bool);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x5BC460", Offset = "0x5BAA60", VA = "0x1805BC460", Slot = "16")]
		public override Vector2 DragObjectPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "17")]
		public override bool DragObjectModifier()
		{
			return default(bool);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2711390", Offset = "0x270F990", VA = "0x182711390")]
		public InputSystemShipInputProvider()
		{
		}

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x20")]
		public ShipInputActions shipInputActions;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x28")]
		private float _steering;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x2C")]
		private float _throttle;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x30")]
		private float _throttle2;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x34")]
		private float _throttle3;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x38")]
		private float _throttle4;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x3C")]
		private float _sternThruster;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x40")]
		private float _bowThruster;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x44")]
		private float _submarineDepth;
	}
}

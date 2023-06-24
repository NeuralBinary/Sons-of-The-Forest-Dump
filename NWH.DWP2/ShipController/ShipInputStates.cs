using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.ShipController
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[Serializable]
	public struct ShipInputStates
	{
		// Token: 0x0600017A RID: 378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x27168E0", Offset = "0x2714EE0", VA = "0x1827168E0")]
		public void Reset()
		{
		}

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x0")]
		[Range(-1f, 1f)]
		public float steering;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x4")]
		[Range(-1f, 1f)]
		public float throttle;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x8")]
		[Range(-1f, 1f)]
		public float throttle2;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0xC")]
		[Range(-1f, 1f)]
		public float throttle3;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x10")]
		[Range(-1f, 1f)]
		public float throttle4;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x14")]
		[Range(-1f, 1f)]
		public float sternThruster;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x18")]
		[Range(-1f, 1f)]
		public float bowThruster;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float submarineDepth;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x20")]
		public bool engineStartStop;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x21")]
		public bool anchor;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x22")]
		public bool changeShip;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x23")]
		public bool changeCamera;
	}
}

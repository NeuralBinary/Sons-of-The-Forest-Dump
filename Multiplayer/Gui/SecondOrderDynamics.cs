using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x02000560 RID: 1376
	[Token(Token = "0x2000560")]
	[Serializable]
	public class SecondOrderDynamics
	{
		// Token: 0x060023DF RID: 9183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x2D8F3E0", Offset = "0x2D8E3E0", VA = "0x182D8F3E0")]
		public void Initialize(float f, float z, float r, Vector3 x0)
		{
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x0000A578 File Offset: 0x00008778
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x2D8F4A0", Offset = "0x2D8E4A0", VA = "0x182D8F4A0")]
		public Vector3 Update(float deltaTime, Vector3 x, [Optional] Vector3? xd)
		{
			return default(Vector3);
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E1")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public SecondOrderDynamics()
		{
		}

		// Token: 0x0400203A RID: 8250
		[Token(Token = "0x400203A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _fInput;

		// Token: 0x0400203B RID: 8251
		[Token(Token = "0x400203B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _zInput;

		// Token: 0x0400203C RID: 8252
		[Token(Token = "0x400203C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _rInput;

		// Token: 0x0400203D RID: 8253
		[Token(Token = "0x400203D")]
		[FieldOffset(Offset = "0x1C")]
		private float _fCached;

		// Token: 0x0400203E RID: 8254
		[Token(Token = "0x400203E")]
		[FieldOffset(Offset = "0x20")]
		private float _zCached;

		// Token: 0x0400203F RID: 8255
		[Token(Token = "0x400203F")]
		[FieldOffset(Offset = "0x24")]
		private float _rCached;

		// Token: 0x04002040 RID: 8256
		[Token(Token = "0x4002040")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _xp;

		// Token: 0x04002041 RID: 8257
		[Token(Token = "0x4002041")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 _y;

		// Token: 0x04002042 RID: 8258
		[Token(Token = "0x4002042")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _yd;

		// Token: 0x04002043 RID: 8259
		[Token(Token = "0x4002043")]
		[FieldOffset(Offset = "0x4C")]
		private float _w;

		// Token: 0x04002044 RID: 8260
		[Token(Token = "0x4002044")]
		[FieldOffset(Offset = "0x50")]
		private float _z;

		// Token: 0x04002045 RID: 8261
		[Token(Token = "0x4002045")]
		[FieldOffset(Offset = "0x54")]
		private float _d;

		// Token: 0x04002046 RID: 8262
		[Token(Token = "0x4002046")]
		[FieldOffset(Offset = "0x58")]
		private float _k1;

		// Token: 0x04002047 RID: 8263
		[Token(Token = "0x4002047")]
		[FieldOffset(Offset = "0x5C")]
		private float _k2;

		// Token: 0x04002048 RID: 8264
		[Token(Token = "0x4002048")]
		[FieldOffset(Offset = "0x60")]
		private float _k3;

		// Token: 0x04002049 RID: 8265
		[Token(Token = "0x4002049")]
		[FieldOffset(Offset = "0x64")]
		private bool _initialized;
	}
}

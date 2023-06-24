using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x0200056F RID: 1391
	[Token(Token = "0x200056F")]
	[Serializable]
	public class SecondOrderDynamics
	{
		// Token: 0x060024DB RID: 9435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DB")]
		[Address(RVA = "0x3390C70", Offset = "0x338F270", VA = "0x183390C70")]
		public void Initialize(float f, float z, float r, Vector3 x0)
		{
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x0000AC38 File Offset: 0x00008E38
		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x3390D30", Offset = "0x338F330", VA = "0x183390D30")]
		public Vector3 Update(float deltaTime, Vector3 x, [Optional] Vector3? xd)
		{
			return default(Vector3);
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SecondOrderDynamics()
		{
		}

		// Token: 0x0400210A RID: 8458
		[Token(Token = "0x400210A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _fInput;

		// Token: 0x0400210B RID: 8459
		[Token(Token = "0x400210B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _zInput;

		// Token: 0x0400210C RID: 8460
		[Token(Token = "0x400210C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _rInput;

		// Token: 0x0400210D RID: 8461
		[Token(Token = "0x400210D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _fCached;

		// Token: 0x0400210E RID: 8462
		[Token(Token = "0x400210E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _zCached;

		// Token: 0x0400210F RID: 8463
		[Token(Token = "0x400210F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _rCached;

		// Token: 0x04002110 RID: 8464
		[Token(Token = "0x4002110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 _xp;

		// Token: 0x04002111 RID: 8465
		[Token(Token = "0x4002111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 _y;

		// Token: 0x04002112 RID: 8466
		[Token(Token = "0x4002112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 _yd;

		// Token: 0x04002113 RID: 8467
		[Token(Token = "0x4002113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _w;

		// Token: 0x04002114 RID: 8468
		[Token(Token = "0x4002114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _z;

		// Token: 0x04002115 RID: 8469
		[Token(Token = "0x4002115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _d;

		// Token: 0x04002116 RID: 8470
		[Token(Token = "0x4002116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _k1;

		// Token: 0x04002117 RID: 8471
		[Token(Token = "0x4002117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _k2;

		// Token: 0x04002118 RID: 8472
		[Token(Token = "0x4002118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _k3;

		// Token: 0x04002119 RID: 8473
		[Token(Token = "0x4002119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _initialized;
	}
}

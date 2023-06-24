using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Animation
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	public abstract class AnimStateEventBase
	{
		// Token: 0x060004F3 RID: 1267
		[Token(Token = "0x60004F3")]
		public abstract bool IsRange();

		// Token: 0x060004F4 RID: 1268
		[Token(Token = "0x60004F4")]
		public abstract bool EndOnExitStart();

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void ChangedTime()
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void ChangedRange()
		{
		}

		// Token: 0x060004F7 RID: 1271
		[Token(Token = "0x60004F7")]
		public abstract AnimStateEventBase Clone();

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xAB20A0", Offset = "0xAB06A0", VA = "0x180AB20A0")]
		protected AnimStateEventBase()
		{
		}

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 _startEnd;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 100f)]
		public float _eventTime;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public bool _lastActive;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 _lastStartEnd;
	}
}

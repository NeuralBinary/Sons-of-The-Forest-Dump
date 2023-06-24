using System;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.FMODIsolated
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public class AutoDisableFmodEmitter : MonoBehaviour
	{
		// Token: 0x060000DC RID: 220 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2FE2CE0", Offset = "0x2FE12E0", VA = "0x182FE2CE0")]
		private void OnValidate()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2FE2E10", Offset = "0x2FE1410", VA = "0x182FE2E10")]
		private void OnEnable()
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2FE2F00", Offset = "0x2FE1500", VA = "0x182FE2F00")]
		private void Update()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AutoDisableFmodEmitter()
		{
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SonsFMODEventEmitter _emitter;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _timer;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x30")]
		private AutoTimer _autoTimer;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x38")]
		private bool _timerNeedsRestart;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x39")]
		private bool _finished;
	}
}

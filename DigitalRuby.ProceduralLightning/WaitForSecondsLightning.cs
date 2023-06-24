using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	public class WaitForSecondsLightning : CustomYieldInstruction
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011C")]
		[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
		public WaitForSecondsLightning(float time)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x1700002B")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0xA43360", Offset = "0xA41960", VA = "0x180A43360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x10")]
		private float remaining;
	}
}

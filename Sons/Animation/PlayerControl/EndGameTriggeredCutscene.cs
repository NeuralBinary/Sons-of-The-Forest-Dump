using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x0200094B RID: 2379
	[Token(Token = "0x200094B")]
	public abstract class EndGameTriggeredCutscene : EndGameCutscene
	{
		// Token: 0x060044C7 RID: 17607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "33")]
		protected virtual void OnTriggerEnterPassed(Collider other)
		{
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C8")]
		[Address(RVA = "0x3658BE0", Offset = "0x36571E0", VA = "0x183658BE0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C9")]
		[Address(RVA = "0x3658D00", Offset = "0x3657300", VA = "0x183658D00", Slot = "34")]
		internal virtual void InteractionTriggered()
		{
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CA")]
		[Address(RVA = "0x3658DC0", Offset = "0x36573C0", VA = "0x183658DC0", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CB")]
		[Address(RVA = "0x3658DE0", Offset = "0x36573E0", VA = "0x183658DE0")]
		protected EndGameTriggeredCutscene()
		{
		}

		// Token: 0x0400478B RID: 18315
		[Token(Token = "0x400478B")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		protected LayerMask _triggerLayerMask;

		// Token: 0x0400478C RID: 18316
		[Token(Token = "0x400478C")]
		[FieldOffset(Offset = "0x184")]
		private bool _triggered;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008D6 RID: 2262
	[Token(Token = "0x20008D6")]
	public abstract class EndGameTriggeredCutscene : EndGameCutscene
	{
		// Token: 0x06003D6A RID: 15722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6A")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "30")]
		protected virtual void OnTriggerEnterPassed(Collider other)
		{
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6B")]
		[Address(RVA = "0x2F1BD00", Offset = "0x2F1AD00", VA = "0x182F1BD00")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x2F1BC40", Offset = "0x2F1AC40", VA = "0x182F1BC40", Slot = "31")]
		internal virtual void InteractionTriggered()
		{
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6D")]
		[Address(RVA = "0x2F1BE20", Offset = "0x2F1AE20", VA = "0x182F1BE20", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6E")]
		[Address(RVA = "0x2F1BE40", Offset = "0x2F1AE40", VA = "0x182F1BE40")]
		protected EndGameTriggeredCutscene()
		{
		}

		// Token: 0x04004144 RID: 16708
		[Token(Token = "0x4004144")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		protected LayerMask _triggerLayerMask;

		// Token: 0x04004145 RID: 16709
		[Token(Token = "0x4004145")]
		[FieldOffset(Offset = "0x16C")]
		private bool _triggered;
	}
}

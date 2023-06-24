using System;
using Il2CppDummyDll;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000957 RID: 2391
	[Token(Token = "0x2000957")]
	public class OpenHellDoorTrigger : OpenSecurityDoorTrigger
	{
		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x0600453B RID: 17723 RVA: 0x00015228 File Offset: 0x00013428
		[Token(Token = "0x17000903")]
		protected override int EnterAnimHash
		{
			[Token(Token = "0x600453B")]
			[Address(RVA = "0x3660700", Offset = "0x365ED00", VA = "0x183660700", Slot = "20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x0600453C RID: 17724 RVA: 0x00015240 File Offset: 0x00013440
		[Token(Token = "0x17000904")]
		protected override int EnterAnimBoolHash
		{
			[Token(Token = "0x600453C")]
			[Address(RVA = "0x3660760", Offset = "0x365ED60", VA = "0x183660760", Slot = "21")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x0600453D RID: 17725 RVA: 0x00015258 File Offset: 0x00013458
		[Token(Token = "0x17000905")]
		protected override int IdleOpenAnimHash
		{
			[Token(Token = "0x600453D")]
			[Address(RVA = "0x36607C0", Offset = "0x365EDC0", VA = "0x1836607C0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x0600453E RID: 17726 RVA: 0x00015270 File Offset: 0x00013470
		[Token(Token = "0x17000906")]
		internal override bool SyncAnimators
		{
			[Token(Token = "0x600453E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x0600453F RID: 17727 RVA: 0x00015288 File Offset: 0x00013488
		[Token(Token = "0x17000907")]
		protected override float AnimationStateWaitTimeout
		{
			[Token(Token = "0x600453F")]
			[Address(RVA = "0x310F9A0", Offset = "0x310DFA0", VA = "0x18310F9A0", Slot = "25")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x000152A0 File Offset: 0x000134A0
		[Token(Token = "0x6004540")]
		[Address(RVA = "0x3660820", Offset = "0x365EE20", VA = "0x183660820", Slot = "24")]
		protected override bool CheckCanOpen()
		{
			return default(bool);
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x000152B8 File Offset: 0x000134B8
		[Token(Token = "0x6004541")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "37")]
		internal override bool IsHoldingKeyItem()
		{
			return default(bool);
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004542")]
		[Address(RVA = "0x3660920", Offset = "0x365EF20", VA = "0x183660920", Slot = "38")]
		internal override void DoEquipKeyItem()
		{
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004543")]
		[Address(RVA = "0x36534B0", Offset = "0x3651AB0", VA = "0x1836534B0")]
		public OpenHellDoorTrigger()
		{
		}
	}
}

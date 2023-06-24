using System;
using Endnight.Animation;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200076F RID: 1903
	[Token(Token = "0x200076F")]
	public class FootstepStateMachineEvents : SonsAnimStateEvents<FootstepStateMachineEvents.StepEvent>
	{
		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06003368 RID: 13160 RVA: 0x0000F630 File Offset: 0x0000D830
		[Token(Token = "0x17000692")]
		protected override bool EventsBeforeTransitionStart
		{
			[Token(Token = "0x6003368")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x0000F648 File Offset: 0x0000D848
		[Token(Token = "0x6003369")]
		[Address(RVA = "0x34B8A60", Offset = "0x34B7060", VA = "0x1834B8A60", Slot = "18")]
		protected override bool InitEventReceiver(Animator animator)
		{
			return default(bool);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600336A")]
		[Address(RVA = "0x34B8BB0", Offset = "0x34B71B0", VA = "0x1834B8BB0", Slot = "20")]
		protected override void SendSingleEvent(AnimStateEventBase ev)
		{
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600336B")]
		[Address(RVA = "0x34B8D00", Offset = "0x34B7300", VA = "0x1834B8D00")]
		public FootstepStateMachineEvents()
		{
		}

		// Token: 0x04002C72 RID: 11378
		[Token(Token = "0x4002C72")]
		[FieldOffset(Offset = "0x30")]
		private FootstepAnimEvents _eventReceiver;

		// Token: 0x02000770 RID: 1904
		[Token(Token = "0x2000770")]
		internal enum StepType
		{
			// Token: 0x04002C74 RID: 11380
			[Token(Token = "0x4002C74")]
			StepLeft,
			// Token: 0x04002C75 RID: 11381
			[Token(Token = "0x4002C75")]
			StepRight,
			// Token: 0x04002C76 RID: 11382
			[Token(Token = "0x4002C76")]
			SneakLeft,
			// Token: 0x04002C77 RID: 11383
			[Token(Token = "0x4002C77")]
			SneakRight,
			// Token: 0x04002C78 RID: 11384
			[Token(Token = "0x4002C78")]
			RunLeft,
			// Token: 0x04002C79 RID: 11385
			[Token(Token = "0x4002C79")]
			RunRight
		}

		// Token: 0x02000771 RID: 1905
		[Token(Token = "0x2000771")]
		[Serializable]
		public class StepEvent : AnimStateEventBase
		{
			// Token: 0x0600336C RID: 13164 RVA: 0x0000F660 File Offset: 0x0000D860
			[Token(Token = "0x600336C")]
			[Address(RVA = "0x34B8D40", Offset = "0x34B7340", VA = "0x1834B8D40", Slot = "7")]
			public virtual Color GetGuiColor()
			{
				return default(Color);
			}

			// Token: 0x0600336D RID: 13165 RVA: 0x0000F678 File Offset: 0x0000D878
			[Token(Token = "0x600336D")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "4")]
			public override bool IsRange()
			{
				return default(bool);
			}

			// Token: 0x0600336E RID: 13166 RVA: 0x0000F690 File Offset: 0x0000D890
			[Token(Token = "0x600336E")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "5")]
			public override bool EndOnExitStart()
			{
				return default(bool);
			}

			// Token: 0x0600336F RID: 13167 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600336F")]
			[Address(RVA = "0x34B8D60", Offset = "0x34B7360", VA = "0x1834B8D60", Slot = "6")]
			public override AnimStateEventBase Clone()
			{
				return null;
			}

			// Token: 0x06003370 RID: 13168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003370")]
			[Address(RVA = "0xAB20A0", Offset = "0xAB06A0", VA = "0x180AB20A0")]
			public StepEvent()
			{
			}

			// Token: 0x04002C7A RID: 11386
			[Token(Token = "0x4002C7A")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			internal FootstepStateMachineEvents.StepType _type;
		}
	}
}

using System;
using Endnight.Animation;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000651 RID: 1617
	[Token(Token = "0x2000651")]
	public class FootstepStateMachineEvents : SonsAnimStateEvents<FootstepStateMachineEvents.StepEvent>
	{
		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Token(Token = "0x17000566")]
		protected override bool EventsBeforeTransitionStart
		{
			[Token(Token = "0x6002987")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x0000BF88 File Offset: 0x0000A188
		[Token(Token = "0x6002988")]
		[Address(RVA = "0x2DCCD60", Offset = "0x2DCBD60", VA = "0x182DCCD60", Slot = "18")]
		protected override bool InitEventReceiver(Animator animator)
		{
			return default(bool);
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002989")]
		[Address(RVA = "0x2DCCE00", Offset = "0x2DCBE00", VA = "0x182DCCE00", Slot = "20")]
		protected override void SendSingleEvent(AnimStateEventBase ev)
		{
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298A")]
		[Address(RVA = "0x2DCCF50", Offset = "0x2DCBF50", VA = "0x182DCCF50")]
		public FootstepStateMachineEvents()
		{
		}

		// Token: 0x04002529 RID: 9513
		[Token(Token = "0x4002529")]
		[FieldOffset(Offset = "0x30")]
		private FootstepAnimEvents _eventReceiver;

		// Token: 0x02000652 RID: 1618
		[Token(Token = "0x2000652")]
		internal enum StepType
		{
			// Token: 0x0400252B RID: 9515
			[Token(Token = "0x400252B")]
			StepLeft,
			// Token: 0x0400252C RID: 9516
			[Token(Token = "0x400252C")]
			StepRight,
			// Token: 0x0400252D RID: 9517
			[Token(Token = "0x400252D")]
			SneakLeft,
			// Token: 0x0400252E RID: 9518
			[Token(Token = "0x400252E")]
			SneakRight,
			// Token: 0x0400252F RID: 9519
			[Token(Token = "0x400252F")]
			RunLeft,
			// Token: 0x04002530 RID: 9520
			[Token(Token = "0x4002530")]
			RunRight
		}

		// Token: 0x02000653 RID: 1619
		[Token(Token = "0x2000653")]
		[Serializable]
		public class StepEvent : AnimStateEventBase
		{
			// Token: 0x0600298B RID: 10635 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
			[Token(Token = "0x600298B")]
			[Address(RVA = "0x2DDFD70", Offset = "0x2DDED70", VA = "0x182DDFD70", Slot = "7")]
			public virtual Color GetGuiColor()
			{
				return default(Color);
			}

			// Token: 0x0600298C RID: 10636 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
			[Token(Token = "0x600298C")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "4")]
			public override bool IsRange()
			{
				return default(bool);
			}

			// Token: 0x0600298D RID: 10637 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
			[Token(Token = "0x600298D")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "5")]
			public override bool EndOnExitStart()
			{
				return default(bool);
			}

			// Token: 0x0600298E RID: 10638 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600298E")]
			[Address(RVA = "0x2DDFCF0", Offset = "0x2DDECF0", VA = "0x182DDFCF0", Slot = "6")]
			public override AnimStateEventBase Clone()
			{
				return null;
			}

			// Token: 0x0600298F RID: 10639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600298F")]
			[Address(RVA = "0x2666370", Offset = "0x2665370", VA = "0x182666370")]
			public StepEvent()
			{
			}

			// Token: 0x04002531 RID: 9521
			[Token(Token = "0x4002531")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			internal FootstepStateMachineEvents.StepType _type;
		}
	}
}

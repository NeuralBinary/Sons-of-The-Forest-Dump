using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ashkatchap.AnimatorEvents
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public abstract class StateMachineBehaviourExtended : StateMachineBehaviour
	{
		// Token: 0x06000038 RID: 56
		[Token(Token = "0x6000038")]
		protected abstract void InitData(byte dataIndex);

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "19")]
		public virtual void StateUpdate(Animator animator, ref AnimatorStateInfo stateInfo, int layerIndex, StateMachineBehaviourExtended.State prevFrame, StateMachineBehaviourExtended.State thisFrame, byte stateDataIndex)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x5C6060", Offset = "0x5C4660", VA = "0x1805C6060", Slot = "4")]
		public sealed override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x5C61F0", Offset = "0x5C47F0", VA = "0x1805C61F0", Slot = "6")]
		public sealed override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x5C6380", Offset = "0x5C4980", VA = "0x1805C6380")]
		private void OnStateExit2(Animator animator, ref AnimatorStateInfo stateInfo, int layerIndex, ref StateMachineBehaviourExtended.Group group)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x5C63D0", Offset = "0x5C49D0", VA = "0x1805C63D0", Slot = "5")]
		public sealed override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x5C64F0", Offset = "0x5C4AF0", VA = "0x1805C64F0")]
		private void OnStateUpdate2(Animator animator, ref AnimatorStateInfo stateInfo, int layerIndex, ref StateMachineBehaviourExtended.Group group)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		protected StateMachineBehaviourExtended()
		{
		}

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x18")]
		private StateMachineBehaviourExtended.Group stateNow;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x1B")]
		private StateMachineBehaviourExtended.Group statePrev;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x1E")]
		private bool pendingInterruptToSelf;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x1F")]
		private bool firstUpdateDone;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x20")]
		private int _onStateExitFrame;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x24")]
		private AnimatorStateInfo _onStateExitStateInfo;

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		public enum State : byte
		{
			// Token: 0x04000070 RID: 112
			[Token(Token = "0x4000070")]
			_0_NotPlaying,
			// Token: 0x04000071 RID: 113
			[Token(Token = "0x4000071")]
			_1_StartTransitioning,
			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			_2_Updating,
			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			_3_ExitTransitioning,
			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4000074")]
			_4_ExitLastFrame
		}

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		private struct Group
		{
			// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x5C6660", Offset = "0x5C4C60", VA = "0x1805C6660")]
			public void Advance(StateMachineBehaviourExtended.State newState)
			{
			}

			// Token: 0x04000075 RID: 117
			[Token(Token = "0x4000075")]
			[FieldOffset(Offset = "0x0")]
			public byte dataIndex;

			// Token: 0x04000076 RID: 118
			[Token(Token = "0x4000076")]
			[FieldOffset(Offset = "0x1")]
			public StateMachineBehaviourExtended.State prevFrame;

			// Token: 0x04000077 RID: 119
			[Token(Token = "0x4000077")]
			[FieldOffset(Offset = "0x2")]
			public StateMachineBehaviourExtended.State thisFrame;
		}
	}
}

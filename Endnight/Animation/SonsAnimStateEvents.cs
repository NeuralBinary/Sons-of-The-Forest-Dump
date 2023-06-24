using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Endnight.Animation
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	public abstract class SonsAnimStateEvents<T> : StateMachineBehaviour where T : AnimStateEventBase
	{
		// Token: 0x060004F9 RID: 1273
		[Token(Token = "0x60004F9")]
		protected abstract bool InitEventReceiver(Animator animator);

		// Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FA")]
		protected virtual void SendRangeEvent(AnimStateEventBase ev, bool active, int stateNameHash)
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FB")]
		protected virtual void SendSingleEvent(AnimStateEventBase ev)
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FC")]
		private void ResetSingleEvents()
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x17000050")]
		protected virtual bool EventsBeforeTransitionStart
		{
			[Token(Token = "0x60004FD")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FE")]
		private void EndRangeEvents(AnimatorStateInfo stateInfo, SonsAnimStateEvents<T>.TransitionState transitionState)
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FF")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000500")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000501")]
		private void UpdateStateEvents(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000502")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000503")]
		protected virtual void CheckErrors(AnimatorStateInfo stateInfo)
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000504")]
		protected SonsAnimStateEvents()
		{
		}

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("_vailEvents")]
		[SerializeField]
		protected List<T> _eventList;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x0")]
		private bool _initialized;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x0")]
		private float _lastNormalizedTime;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x0")]
		private float _startNormalizedTime;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x0")]
		private float _startedExitNormalizedTime;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		private const float MaxNormalizedTime = 10000f;

		// Token: 0x020000D5 RID: 213
		[Token(Token = "0x20000D5")]
		private enum TransitionState
		{
			// Token: 0x04000333 RID: 819
			[Token(Token = "0x4000333")]
			ExitStart,
			// Token: 0x04000334 RID: 820
			[Token(Token = "0x4000334")]
			ExitEnd
		}
	}
}

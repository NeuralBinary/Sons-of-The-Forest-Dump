using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation;

namespace Construction.Anim
{
	// Token: 0x020002B9 RID: 697
	[Token(Token = "0x20002B9")]
	public interface IAnimationSequencer
	{
		// Token: 0x06001505 RID: 5381
		[Token(Token = "0x6001505")]
		IEnumerator StateSequencingRoutine();

		// Token: 0x06001506 RID: 5382
		[Token(Token = "0x6001506")]
		void BeginLiveUpdate();

		// Token: 0x06001507 RID: 5383
		[Token(Token = "0x6001507")]
		void LiveUpdate();

		// Token: 0x06001508 RID: 5384
		[Token(Token = "0x6001508")]
		void LateUpdate();

		// Token: 0x06001509 RID: 5385
		[Token(Token = "0x6001509")]
		void PostIkUpdate();

		// Token: 0x0600150A RID: 5386
		[Token(Token = "0x600150A")]
		void ReachedTriggerTime();

		// Token: 0x0600150B RID: 5387
		[Token(Token = "0x600150B")]
		void ReachedBouncePartialExitTime();

		// Token: 0x0600150C RID: 5388
		[Token(Token = "0x600150C")]
		void Terminate();

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600150D RID: 5389
		[Token(Token = "0x1700045E")]
		bool WasTriggered { [Token(Token = "0x600150D")] get; }

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x0600150E RID: 5390
		[Token(Token = "0x1700045F")]
		bool AnimEventsOnly { [Token(Token = "0x600150E")] get; }

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x0600150F RID: 5391
		[Token(Token = "0x17000460")]
		ILayerBehaviourActivator[] LayerActivators { [Token(Token = "0x600150F")] get; }

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001510 RID: 5392
		[Token(Token = "0x17000461")]
		ILayerBehaviourActivator[] LayerDisablers { [Token(Token = "0x6001510")] get; }

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001511 RID: 5393
		[Token(Token = "0x17000462")]
		bool IsLiveUpdating { [Token(Token = "0x6001511")] get; }

		// Token: 0x06001512 RID: 5394
		[Token(Token = "0x6001512")]
		void StopLiveUpdate();

		// Token: 0x06001513 RID: 5395
		[Token(Token = "0x6001513")]
		void BeginPerfectFinishIk();

		// Token: 0x06001514 RID: 5396
		[Token(Token = "0x6001514")]
		void SetTargetInfo(TargetInfo managerCurrentTarget);

		// Token: 0x06001515 RID: 5397
		[Token(Token = "0x6001515")]
		void Cancel(bool forceCancel);
	}
}

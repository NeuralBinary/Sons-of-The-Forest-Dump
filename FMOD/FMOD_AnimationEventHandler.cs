using System;
using System.Collections.Generic;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;
using UnityEngine.Events;

namespace FMOD
{
	// Token: 0x020004D6 RID: 1238
	[Token(Token = "0x20004D6")]
	public class FMOD_AnimationEventHandler : MonoBehaviour, IActorSeed, IActorAudioPlayer
	{
		// Token: 0x06001FBE RID: 8126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBE")]
		[Address(RVA = "0x2D28EA0", Offset = "0x2D27EA0", VA = "0x182D28EA0")]
		private void Start()
		{
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBF")]
		[Address(RVA = "0x2D28DC0", Offset = "0x2D27DC0", VA = "0x182D28DC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0x2D28AB0", Offset = "0x2D27AB0", VA = "0x182D28AB0")]
		private void OnDisable()
		{
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC1")]
		[Address(RVA = "0x2D28F50", Offset = "0x2D27F50", VA = "0x182D28F50")]
		private void Update()
		{
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC2")]
		[Address(RVA = "0x2D28A50", Offset = "0x2D27A50", VA = "0x182D28A50")]
		private void CleanupOneshotEvents()
		{
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC3")]
		[Address(RVA = "0x2D298F0", Offset = "0x2D288F0", VA = "0x182D298F0", Slot = "6")]
		public void stopFMODEvent(string path)
		{
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC4")]
		[Address(RVA = "0x2D29270", Offset = "0x2D28270", VA = "0x182D29270")]
		public void playFMODEventWithTimeOut(string path)
		{
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0x2D29220", Offset = "0x2D28220", VA = "0x182D29220")]
		public void playFMODEvent(string path)
		{
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC6")]
		[Address(RVA = "0x2D29240", Offset = "0x2D28240", VA = "0x182D29240")]
		public void playFMODEventLocal(string path)
		{
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC7")]
		[Address(RVA = "0x2D29220", Offset = "0x2D28220", VA = "0x182D29220", Slot = "5")]
		public void playFMODEventFromVail(string path)
		{
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC8")]
		[Address(RVA = "0x2D29290", Offset = "0x2D28290", VA = "0x182D29290")]
		private void playFMODEvent(string path, bool enableTimeout, bool autoStopLooping)
		{
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0x2D28A30", Offset = "0x2D27A30", VA = "0x182D28A30", Slot = "4")]
		public void ApplySeed(int seed, int subVariationSet)
		{
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0x2D29190", Offset = "0x2D28190", VA = "0x182D29190")]
		public FMOD_AnimationEventHandler()
		{
		}

		// Token: 0x04001D44 RID: 7492
		[Token(Token = "0x4001D44")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform eventTransform;

		// Token: 0x04001D45 RID: 7493
		[Token(Token = "0x4001D45")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool oneshotsFollowTransform;

		// Token: 0x04001D46 RID: 7494
		[Token(Token = "0x4001D46")]
		[FieldOffset(Offset = "0x29")]
		[Tooltip("Stop oneshots after 10 seconds in case they don't stop by themselves")]
		[SerializeField]
		private bool stopOneshotsAfterTimeout;

		// Token: 0x04001D47 RID: 7495
		[Token(Token = "0x4001D47")]
		[FieldOffset(Offset = "0x2A")]
		[Tooltip("If animator is disabled, stop events instead of letting them play out")]
		[SerializeField]
		private bool _stopOnAnimatorDisable;

		// Token: 0x04001D48 RID: 7496
		[Token(Token = "0x4001D48")]
		[FieldOffset(Offset = "0x2B")]
		[SerializeField]
		private bool _remotePlayer;

		// Token: 0x04001D49 RID: 7497
		[Token(Token = "0x4001D49")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _voiceEnabled;

		// Token: 0x04001D4A RID: 7498
		[Token(Token = "0x4001D4A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FMOD_AnimationEventHandler.ActorSoundType _type;

		// Token: 0x04001D4B RID: 7499
		[Token(Token = "0x4001D4B")]
		[FieldOffset(Offset = "0x34")]
		private int _voiceActor;

		// Token: 0x04001D4C RID: 7500
		[Token(Token = "0x4001D4C")]
		[FieldOffset(Offset = "0x38")]
		private List<FMODCommon.OneshotEventInfo> _oneshotEvents;

		// Token: 0x04001D4D RID: 7501
		[Token(Token = "0x4001D4D")]
		[FieldOffset(Offset = "0x40")]
		private List<FMODCommon.LoopingEventInfo> _loopingEvents;

		// Token: 0x04001D4E RID: 7502
		[Token(Token = "0x4001D4E")]
		[FieldOffset(Offset = "0x48")]
		private Animator _animator;

		// Token: 0x04001D4F RID: 7503
		[Token(Token = "0x4001D4F")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent<EventInstance, string> OneShotEventCreated;

		// Token: 0x020004D7 RID: 1239
		[Token(Token = "0x20004D7")]
		private enum ActorSoundType
		{
			// Token: 0x04001D51 RID: 7505
			[Token(Token = "0x4001D51")]
			None = -1,
			// Token: 0x04001D52 RID: 7506
			[Token(Token = "0x4001D52")]
			FemaleCannibal,
			// Token: 0x04001D53 RID: 7507
			[Token(Token = "0x4001D53")]
			FemaleMuddy,
			// Token: 0x04001D54 RID: 7508
			[Token(Token = "0x4001D54")]
			MaleCannibal,
			// Token: 0x04001D55 RID: 7509
			[Token(Token = "0x4001D55")]
			MaleMuddy,
			// Token: 0x04001D56 RID: 7510
			[Token(Token = "0x4001D56")]
			FemaleFat,
			// Token: 0x04001D57 RID: 7511
			[Token(Token = "0x4001D57")]
			MaleFat,
			// Token: 0x04001D58 RID: 7512
			[Token(Token = "0x4001D58")]
			MaleHeavy,
			// Token: 0x04001D59 RID: 7513
			[Token(Token = "0x4001D59")]
			MalePuffy,
			// Token: 0x04001D5A RID: 7514
			[Token(Token = "0x4001D5A")]
			FemalePuffy
		}
	}
}

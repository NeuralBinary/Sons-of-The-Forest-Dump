using System;
using System.Collections.Generic;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;
using UnityEngine.Events;

namespace FMOD
{
	// Token: 0x020004CB RID: 1227
	[Token(Token = "0x20004CB")]
	public class FMOD_AnimationEventHandler : MonoBehaviour, IActorSeed, IActorAudioPlayer
	{
		// Token: 0x06002022 RID: 8226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002022")]
		[Address(RVA = "0x33100E0", Offset = "0x330E6E0", VA = "0x1833100E0")]
		private void Start()
		{
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002023")]
		[Address(RVA = "0x3310260", Offset = "0x330E860", VA = "0x183310260")]
		private void OnEnable()
		{
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002024")]
		[Address(RVA = "0x3310420", Offset = "0x330EA20", VA = "0x183310420")]
		private void OnDisable()
		{
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002025")]
		[Address(RVA = "0x3310920", Offset = "0x330EF20", VA = "0x183310920")]
		private void Update()
		{
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002026")]
		[Address(RVA = "0x3310CE0", Offset = "0x330F2E0", VA = "0x183310CE0")]
		private void CleanupOneshotEvents()
		{
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002027")]
		[Address(RVA = "0x3310D40", Offset = "0x330F340", VA = "0x183310D40", Slot = "6")]
		public void stopFMODEvent(string path)
		{
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002028")]
		[Address(RVA = "0x3311030", Offset = "0x330F630", VA = "0x183311030")]
		public void playFMODEventWithTimeOut(string path)
		{
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002029")]
		[Address(RVA = "0x3311050", Offset = "0x330F650", VA = "0x183311050")]
		public void playFMODEvent(string path)
		{
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202A")]
		[Address(RVA = "0x3311070", Offset = "0x330F670", VA = "0x183311070")]
		public void playFMODEventLocal(string path)
		{
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202B")]
		[Address(RVA = "0x3311050", Offset = "0x330F650", VA = "0x183311050", Slot = "5")]
		public void playFMODEventFromVail(string path)
		{
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202C")]
		[Address(RVA = "0x33110A0", Offset = "0x330F6A0", VA = "0x1833110A0")]
		private void playFMODEvent(string path, bool enableTimeout, bool autoStopLooping)
		{
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202D")]
		[Address(RVA = "0x3311980", Offset = "0x330FF80", VA = "0x183311980", Slot = "4")]
		public void ApplySeed(int seed, int subVariationSet)
		{
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202E")]
		[Address(RVA = "0x33119A0", Offset = "0x330FFA0", VA = "0x1833119A0")]
		public FMOD_AnimationEventHandler()
		{
		}

		// Token: 0x04001D80 RID: 7552
		[Token(Token = "0x4001D80")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform eventTransform;

		// Token: 0x04001D81 RID: 7553
		[Token(Token = "0x4001D81")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool oneshotsFollowTransform;

		// Token: 0x04001D82 RID: 7554
		[Token(Token = "0x4001D82")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		[Tooltip("Stop oneshots after 10 seconds in case they don't stop by themselves")]
		private bool stopOneshotsAfterTimeout;

		// Token: 0x04001D83 RID: 7555
		[Token(Token = "0x4001D83")]
		[FieldOffset(Offset = "0x2A")]
		[Tooltip("If animator is disabled, stop events instead of letting them play out")]
		[SerializeField]
		private bool _stopOnAnimatorDisable;

		// Token: 0x04001D84 RID: 7556
		[Token(Token = "0x4001D84")]
		[FieldOffset(Offset = "0x2B")]
		[SerializeField]
		private bool _remotePlayer;

		// Token: 0x04001D85 RID: 7557
		[Token(Token = "0x4001D85")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _voiceEnabled;

		// Token: 0x04001D86 RID: 7558
		[Token(Token = "0x4001D86")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FMOD_AnimationEventHandler.ActorSoundType _type;

		// Token: 0x04001D87 RID: 7559
		[Token(Token = "0x4001D87")]
		[FieldOffset(Offset = "0x34")]
		private int _voiceActor;

		// Token: 0x04001D88 RID: 7560
		[Token(Token = "0x4001D88")]
		[FieldOffset(Offset = "0x38")]
		private List<FMODCommon.OneshotEventInfo> _oneshotEvents;

		// Token: 0x04001D89 RID: 7561
		[Token(Token = "0x4001D89")]
		[FieldOffset(Offset = "0x40")]
		private List<FMODCommon.LoopingEventInfo> _loopingEvents;

		// Token: 0x04001D8A RID: 7562
		[Token(Token = "0x4001D8A")]
		[FieldOffset(Offset = "0x48")]
		private Animator _animator;

		// Token: 0x04001D8B RID: 7563
		[Token(Token = "0x4001D8B")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent<EventInstance, string> OneShotEventCreated;

		// Token: 0x020004CC RID: 1228
		[Token(Token = "0x20004CC")]
		private enum ActorSoundType
		{
			// Token: 0x04001D8D RID: 7565
			[Token(Token = "0x4001D8D")]
			None = -1,
			// Token: 0x04001D8E RID: 7566
			[Token(Token = "0x4001D8E")]
			FemaleCannibal,
			// Token: 0x04001D8F RID: 7567
			[Token(Token = "0x4001D8F")]
			FemaleMuddy,
			// Token: 0x04001D90 RID: 7568
			[Token(Token = "0x4001D90")]
			MaleCannibal,
			// Token: 0x04001D91 RID: 7569
			[Token(Token = "0x4001D91")]
			MaleMuddy,
			// Token: 0x04001D92 RID: 7570
			[Token(Token = "0x4001D92")]
			FemaleFat,
			// Token: 0x04001D93 RID: 7571
			[Token(Token = "0x4001D93")]
			MaleFat,
			// Token: 0x04001D94 RID: 7572
			[Token(Token = "0x4001D94")]
			MaleHeavy,
			// Token: 0x04001D95 RID: 7573
			[Token(Token = "0x4001D95")]
			MalePuffy,
			// Token: 0x04001D96 RID: 7574
			[Token(Token = "0x4001D96")]
			FemalePuffy
		}
	}
}

using System;
using System.Collections;
using Endnight.Animation;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Save;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000940 RID: 2368
	[Token(Token = "0x2000940")]
	public abstract class DoorTriggerCutsceneBase : GameStateSyncedCutscene
	{
		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06004426 RID: 17446
		[Token(Token = "0x170008C7")]
		protected abstract int IdleOpenAnimHash { [Token(Token = "0x6004426")] get; }

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06004427 RID: 17447
		[Token(Token = "0x170008C8")]
		protected abstract int IdleClosedAnimHash { [Token(Token = "0x6004427")] get; }

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06004428 RID: 17448
		[Token(Token = "0x170008C9")]
		protected abstract int EnterAnimHash { [Token(Token = "0x6004428")] get; }

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06004429 RID: 17449
		[Token(Token = "0x170008CA")]
		protected abstract int EnterAnimBoolHash { [Token(Token = "0x6004429")] get; }

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x0600442A RID: 17450
		[Token(Token = "0x170008CB")]
		protected abstract int DenyEntryAnimHash { [Token(Token = "0x600442A")] get; }

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x0600442B RID: 17451
		[Token(Token = "0x170008CC")]
		protected abstract int DenyEntryBoolHash { [Token(Token = "0x600442B")] get; }

		// Token: 0x0600442C RID: 17452
		[Token(Token = "0x600442C")]
		protected abstract bool CheckCanOpen();

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x0600442D RID: 17453 RVA: 0x00014CA0 File Offset: 0x00012EA0
		[Token(Token = "0x170008CD")]
		protected virtual float AnimationStateWaitTimeout
		{
			[Token(Token = "0x600442D")]
			[Address(RVA = "0x36506D0", Offset = "0x364ECD0", VA = "0x1836506D0", Slot = "25")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x0600442E RID: 17454 RVA: 0x00014CB8 File Offset: 0x00012EB8
		[Token(Token = "0x170008CE")]
		internal virtual bool SyncAnimators
		{
			[Token(Token = "0x600442E")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600442F")]
		[Address(RVA = "0x36506E0", Offset = "0x364ECE0", VA = "0x1836506E0")]
		private void TestSetOpen()
		{
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004430")]
		[Address(RVA = "0x3650710", Offset = "0x364ED10", VA = "0x183650710")]
		private void TestSetClosed()
		{
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004431")]
		[Address(RVA = "0x3650740", Offset = "0x364ED40", VA = "0x183650740")]
		private void TestSetOpenSequence()
		{
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004432")]
		[Address(RVA = "0x3650770", Offset = "0x364ED70", VA = "0x183650770")]
		private void TestSetDenyEntry()
		{
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004433")]
		[Address(RVA = "0x26FC740", Offset = "0x26FAD40", VA = "0x1826FC740")]
		private void ResetAnim()
		{
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004434")]
		[Address(RVA = "0x36507A0", Offset = "0x364EDA0", VA = "0x1836507A0", Slot = "5")]
		internal override void OnValidate()
		{
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004435")]
		[Address(RVA = "0x36508E0", Offset = "0x364EEE0", VA = "0x1836508E0", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004436")]
		[Address(RVA = "0x3650A20", Offset = "0x364F020", VA = "0x183650A20", Slot = "17")]
		protected override void InitializeState(NamedIntData saveValue)
		{
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004437")]
		[Address(RVA = "0x3650AF0", Offset = "0x364F0F0", VA = "0x183650AF0")]
		protected void SetDoorState(DoorState state, bool updateBolt = true)
		{
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004438")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		protected virtual void OnDoorSateChanged(DoorState doorState)
		{
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x00014CD0 File Offset: 0x00012ED0
		[Token(Token = "0x6004439")]
		[Address(RVA = "0x3650BC0", Offset = "0x364F1C0", VA = "0x183650BC0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443A")]
		[Address(RVA = "0x3650C00", Offset = "0x364F200", VA = "0x183650C00")]
		protected void RefreshGuiDisplay()
		{
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443B")]
		[Address(RVA = "0x3650D00", Offset = "0x364F300", VA = "0x183650D00", Slot = "28")]
		internal virtual void LocalOpenInputReceived()
		{
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443C")]
		[Address(RVA = "0x3650DF0", Offset = "0x364F3F0", VA = "0x183650DF0", Slot = "29")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443D")]
		[Address(RVA = "0x3650F20", Offset = "0x364F520", VA = "0x183650F20", Slot = "30")]
		protected virtual void RefreshDoorStateVisuals()
		{
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443E")]
		[Address(RVA = "0x36510B0", Offset = "0x364F6B0", VA = "0x1836510B0", Slot = "16")]
		protected override void AppliedState(NamedIntData saveValue)
		{
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443F")]
		[Address(RVA = "0x3651100", Offset = "0x364F700", VA = "0x183651100", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004440")]
		[Address(RVA = "0x36511B0", Offset = "0x364F7B0", VA = "0x1836511B0", Slot = "31")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004441")]
		[Address(RVA = "0x36512D0", Offset = "0x364F8D0", VA = "0x1836512D0")]
		private void Update()
		{
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004442")]
		[Address(RVA = "0x3651480", Offset = "0x364FA80", VA = "0x183651480")]
		private void JumpToClosed(bool updateBolt = false)
		{
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004443")]
		[Address(RVA = "0x36514B0", Offset = "0x364FAB0", VA = "0x1836514B0")]
		private void JumpToClosedVisuals()
		{
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004444")]
		[Address(RVA = "0x36506E0", Offset = "0x364ECE0", VA = "0x1836506E0")]
		public void ForceOpen()
		{
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004445")]
		[Address(RVA = "0x3650710", Offset = "0x364ED10", VA = "0x183650710")]
		public void ForceClose()
		{
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004446")]
		[Address(RVA = "0x3651720", Offset = "0x364FD20", VA = "0x183651720")]
		private void JumpToOpen(bool updateBolt = false)
		{
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004447")]
		[Address(RVA = "0x3651750", Offset = "0x364FD50", VA = "0x183651750")]
		protected void JumpToOpenVisuals()
		{
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004448")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "32")]
		internal virtual void OpenHook()
		{
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004449")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "33")]
		internal virtual void CloseHook()
		{
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444A")]
		[Address(RVA = "0x3651960", Offset = "0x364FF60", VA = "0x183651960", Slot = "34")]
		protected virtual IEnumerator PlayOpenDoorSequenceSynced()
		{
			return null;
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "35")]
		protected virtual void DoorAnimating()
		{
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444C")]
		[Address(RVA = "0x36519F0", Offset = "0x364FFF0", VA = "0x1836519F0", Slot = "36")]
		protected virtual IEnumerator PostOpenPlayerSequence()
		{
			return null;
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444D")]
		[Address(RVA = "0x3651A30", Offset = "0x3650030", VA = "0x183651A30")]
		private IEnumerator PlayDenyEntryDoorSequenceSynced()
		{
			return null;
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444E")]
		[Address(RVA = "0x3651AC0", Offset = "0x36500C0", VA = "0x183651AC0")]
		private IEnumerator PlayDenyEntryDoorSequence(bool updateBolt = false)
		{
			return null;
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444F")]
		[Address(RVA = "0x3651B80", Offset = "0x3650180", VA = "0x183651B80")]
		private IEnumerator PlayOpenDoorSequence(bool updateBolt = false)
		{
			return null;
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004450")]
		[Address(RVA = "0x3651C40", Offset = "0x3650240", VA = "0x183651C40")]
		private void StartDenyEntryDoorAnimation()
		{
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004451")]
		[Address(RVA = "0x3651D20", Offset = "0x3650320", VA = "0x183651D20")]
		private void StartOpenDoorAnimation()
		{
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004452")]
		[Address(RVA = "0x3651E00", Offset = "0x3650400", VA = "0x183651E00")]
		private void OnPlayerAnimatorMove()
		{
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004453")]
		[Address(RVA = "0x3651F90", Offset = "0x3650590", VA = "0x183651F90")]
		internal static IEnumerator WaitForStateStartToggleBool(Animator animator, int layerIndex, int stateHash, int boolHash)
		{
			return null;
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004454")]
		[Address(RVA = "0x3652060", Offset = "0x3650660", VA = "0x183652060")]
		private IEnumerator WaitForDoorSequenceCompleted(int animHash)
		{
			return null;
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004455")]
		[Address(RVA = "0x3652120", Offset = "0x3650720", VA = "0x183652120")]
		protected static void OnWaitTimeout(string source)
		{
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004456")]
		[Address(RVA = "0x3652190", Offset = "0x3650790", VA = "0x183652190")]
		private static void StashHeldItems()
		{
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004457")]
		[Address(RVA = "0x3652270", Offset = "0x3650870", VA = "0x183652270")]
		private void TryStashKeyItem()
		{
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x00014CE8 File Offset: 0x00012EE8
		[Token(Token = "0x6004458")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "37")]
		internal virtual bool IsHoldingKeyItem()
		{
			return default(bool);
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004459")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "38")]
		internal virtual void DoEquipKeyItem()
		{
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445A")]
		[Address(RVA = "0x3652300", Offset = "0x3650900", VA = "0x183652300")]
		private void StartPlayerSequence()
		{
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445B")]
		[Address(RVA = "0x36529E0", Offset = "0x3650FE0", VA = "0x1836529E0")]
		public static void SetPlayerLocked(bool locked)
		{
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445C")]
		[Address(RVA = "0x3652D10", Offset = "0x3651310", VA = "0x183652D10")]
		private void UpdatePlayerAlign()
		{
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445D")]
		[Address(RVA = "0x3652D90", Offset = "0x3651390", VA = "0x183652D90")]
		private void UpdateAnimatorSync()
		{
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445E")]
		[Address(RVA = "0x3652FD0", Offset = "0x36515D0", VA = "0x183652FD0", Slot = "39")]
		protected virtual void FinalizePlayer()
		{
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445F")]
		[Address(RVA = "0x36534B0", Offset = "0x3651AB0", VA = "0x1836534B0")]
		protected DoorTriggerCutsceneBase()
		{
		}

		// Token: 0x04004739 RID: 18233
		[Token(Token = "0x4004739")]
		[FieldOffset(Offset = "0xC0")]
		protected DoorState _doorState;

		// Token: 0x0400473A RID: 18234
		[Token(Token = "0x400473A")]
		[FieldOffset(Offset = "0xC4")]
		protected PlayerDoorState _localPlayerDoorState;

		// Token: 0x0400473B RID: 18235
		[Token(Token = "0x400473B")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		protected GenericInteraction _interaction;

		// Token: 0x0400473C RID: 18236
		[Token(Token = "0x400473C")]
		[FieldOffset(Offset = "0xD0")]
		[FormerlySerializedAs("_targetAnimator")]
		[SerializeField]
		protected Animator _doorAnimator;

		// Token: 0x0400473D RID: 18237
		[Token(Token = "0x400473D")]
		[FieldOffset(Offset = "0xD8")]
		private DoorState _lastUpdatedDoorState;

		// Token: 0x0400473E RID: 18238
		[Token(Token = "0x400473E")]
		[FieldOffset(Offset = "0xE0")]
		[FormerlySerializedAs("_alignTransform")]
		[SerializeField]
		private Transform _playerLocator;

		// Token: 0x0400473F RID: 18239
		[Token(Token = "0x400473F")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _playerAlignTimer;

		// Token: 0x04004740 RID: 18240
		[Token(Token = "0x4004740")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private float _fov;

		// Token: 0x04004741 RID: 18241
		[Token(Token = "0x4004741")]
		[FieldOffset(Offset = "0xF0")]
		private Animator _playerAnimator;

		// Token: 0x04004742 RID: 18242
		[Token(Token = "0x4004742")]
		[FieldOffset(Offset = "0xF8")]
		private Vector3 _playerMovementOffset;

		// Token: 0x04004743 RID: 18243
		[Token(Token = "0x4004743")]
		[FieldOffset(Offset = "0x104")]
		private Quaternion _playerRotationOffset;

		// Token: 0x04004744 RID: 18244
		[Token(Token = "0x4004744")]
		[FieldOffset(Offset = "0x114")]
		private bool _localPlayerHasStashedItem;

		// Token: 0x04004745 RID: 18245
		[Token(Token = "0x4004745")]
		[FieldOffset(Offset = "0x115")]
		private bool _isRemotePlayerInteraction;

		// Token: 0x04004746 RID: 18246
		[Token(Token = "0x4004746")]
		[FieldOffset(Offset = "0x118")]
		private float _originalFov;

		// Token: 0x04004747 RID: 18247
		[Token(Token = "0x4004747")]
		[FieldOffset(Offset = "0x120")]
		private AnimationSyncData _closedToOpenSyncData;
	}
}

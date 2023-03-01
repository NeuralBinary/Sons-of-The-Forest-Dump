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
	// Token: 0x020008CB RID: 2251
	[Token(Token = "0x20008CB")]
	public abstract class DoorTriggerCutsceneBase : StateSyncedCutscene
	{
		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06003CD1 RID: 15569
		[Token(Token = "0x17000799")]
		protected abstract int IdleOpenAnimHash
		{
			[Token(Token = "0x6003CD1")]
			get;
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06003CD2 RID: 15570
		[Token(Token = "0x1700079A")]
		protected abstract int IdleClosedAnimHash
		{
			[Token(Token = "0x6003CD2")]
			get;
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06003CD3 RID: 15571
		[Token(Token = "0x1700079B")]
		protected abstract int EnterAnimHash
		{
			[Token(Token = "0x6003CD3")]
			get;
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06003CD4 RID: 15572
		[Token(Token = "0x1700079C")]
		protected abstract int EnterAnimBoolHash
		{
			[Token(Token = "0x6003CD4")]
			get;
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06003CD5 RID: 15573
		[Token(Token = "0x1700079D")]
		protected abstract int DenyEntryAnimHash
		{
			[Token(Token = "0x6003CD5")]
			get;
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06003CD6 RID: 15574
		[Token(Token = "0x1700079E")]
		protected abstract int DenyEntryBoolHash
		{
			[Token(Token = "0x6003CD6")]
			get;
		}

		// Token: 0x06003CD7 RID: 15575
		[Token(Token = "0x6003CD7")]
		protected abstract bool CheckCanOpen();

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06003CD8 RID: 15576 RVA: 0x00011D30 File Offset: 0x0000FF30
		[Token(Token = "0x1700079F")]
		protected virtual float AnimationStateWaitTimeout
		{
			[Token(Token = "0x6003CD8")]
			[Address(RVA = "0x2F18C90", Offset = "0x2F17C90", VA = "0x182F18C90", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06003CD9 RID: 15577 RVA: 0x00011D48 File Offset: 0x0000FF48
		[Token(Token = "0x170007A0")]
		internal virtual bool SyncAnimators
		{
			[Token(Token = "0x6003CD9")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CDA")]
		[Address(RVA = "0x2F18760", Offset = "0x2F17760", VA = "0x182F18760")]
		private void TestSetOpen()
		{
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CDB")]
		[Address(RVA = "0x2F185F0", Offset = "0x2F175F0", VA = "0x182F185F0")]
		private void TestSetClosed()
		{
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CDC")]
		[Address(RVA = "0x2F186E0", Offset = "0x2F176E0", VA = "0x182F186E0")]
		private void TestSetOpenSequence()
		{
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CDD")]
		[Address(RVA = "0x2F18660", Offset = "0x2F17660", VA = "0x182F18660")]
		private void TestSetDenyEntry()
		{
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CDE")]
		[Address(RVA = "0x22AB2B0", Offset = "0x22AA2B0", VA = "0x1822AB2B0")]
		private void ResetAnim()
		{
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CDF")]
		[Address(RVA = "0x2F17520", Offset = "0x2F16520", VA = "0x182F17520", Slot = "5")]
		internal override void OnValidate()
		{
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE0")]
		[Address(RVA = "0x2F178B0", Offset = "0x2F168B0", VA = "0x182F178B0", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE1")]
		[Address(RVA = "0x2F16C20", Offset = "0x2F15C20", VA = "0x182F16C20", Slot = "17")]
		protected override void InitializeState(NamedIntData saveValue)
		{
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE2")]
		[Address(RVA = "0x2F17C20", Offset = "0x2F16C20", VA = "0x182F17C20")]
		protected void SetDoorState(DoorState state, bool updateBolt = true)
		{
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE3")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "27")]
		protected virtual void OnDoorSateChanged(DoorState doorState)
		{
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00011D60 File Offset: 0x0000FF60
		[Token(Token = "0x6003CE4")]
		[Address(RVA = "0x2F17820", Offset = "0x2F16820", VA = "0x182F17820", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE5")]
		[Address(RVA = "0x2F17B20", Offset = "0x2F16B20", VA = "0x182F17B20")]
		protected void RefreshGuiDisplay()
		{
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE6")]
		[Address(RVA = "0x2F17070", Offset = "0x2F16070", VA = "0x182F17070", Slot = "28")]
		internal virtual void LocalOpenInputReceived()
		{
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE7")]
		[Address(RVA = "0x2F171F0", Offset = "0x2F161F0", VA = "0x182F171F0", Slot = "29")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE8")]
		[Address(RVA = "0x2F17A20", Offset = "0x2F16A20", VA = "0x182F17A20", Slot = "30")]
		protected virtual void RefreshDoorStateVisuals()
		{
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE9")]
		[Address(RVA = "0x2F167C0", Offset = "0x2F157C0", VA = "0x182F167C0", Slot = "16")]
		protected override void AppliedState(NamedIntData saveValue)
		{
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEA")]
		[Address(RVA = "0x2F17BB0", Offset = "0x2F16BB0", VA = "0x182F17BB0", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEB")]
		[Address(RVA = "0x2F17130", Offset = "0x2F16130", VA = "0x182F17130", Slot = "31")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEC")]
		[Address(RVA = "0x2F18A00", Offset = "0x2F17A00", VA = "0x182F18A00")]
		private void Update()
		{
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CED")]
		[Address(RVA = "0x2F16E10", Offset = "0x2F15E10", VA = "0x182F16E10")]
		private void JumpToClosed(bool updateBolt = false)
		{
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEE")]
		[Address(RVA = "0x2F16CB0", Offset = "0x2F15CB0", VA = "0x182F16CB0")]
		private void JumpToClosedVisuals()
		{
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEF")]
		[Address(RVA = "0x2F16FE0", Offset = "0x2F15FE0", VA = "0x182F16FE0")]
		private void JumpToOpen(bool updateBolt = false)
		{
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF0")]
		[Address(RVA = "0x2F16E90", Offset = "0x2F15E90", VA = "0x182F16E90")]
		protected void JumpToOpenVisuals()
		{
		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF1")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "32")]
		internal virtual void OpenHook()
		{
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF2")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "33")]
		internal virtual void CloseHook()
		{
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF3")]
		[Address(RVA = "0x2F17730", Offset = "0x2F16730", VA = "0x182F17730")]
		private IEnumerator PlayOpenDoorSequenceSynced()
		{
			return null;
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF4")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "34")]
		protected virtual void DoorAnimating()
		{
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF5")]
		[Address(RVA = "0x2F17860", Offset = "0x2F16860", VA = "0x182F17860", Slot = "35")]
		protected virtual IEnumerator PostOpenPlayerSequence()
		{
			return null;
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF6")]
		[Address(RVA = "0x2F17640", Offset = "0x2F16640", VA = "0x182F17640")]
		private IEnumerator PlayDenyEntryDoorSequenceSynced()
		{
			return null;
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF7")]
		[Address(RVA = "0x2F176B0", Offset = "0x2F166B0", VA = "0x182F176B0")]
		private IEnumerator PlayDenyEntryDoorSequence(bool updateBolt = false)
		{
			return null;
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF8")]
		[Address(RVA = "0x2F177A0", Offset = "0x2F167A0", VA = "0x182F177A0")]
		private IEnumerator PlayOpenDoorSequence(bool updateBolt = false)
		{
			return null;
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF9")]
		[Address(RVA = "0x2F17ED0", Offset = "0x2F16ED0", VA = "0x182F17ED0")]
		private void StartDenyEntryDoorAnimation()
		{
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFA")]
		[Address(RVA = "0x2F17F40", Offset = "0x2F16F40", VA = "0x182F17F40")]
		private void StartOpenDoorAnimation()
		{
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFB")]
		[Address(RVA = "0x2F172D0", Offset = "0x2F162D0", VA = "0x182F172D0")]
		private void OnPlayerAnimatorMove()
		{
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFC")]
		[Address(RVA = "0x2F18BC0", Offset = "0x2F17BC0", VA = "0x182F18BC0")]
		internal static IEnumerator WaitForStateStartToggleBool(Animator animator, int layerIndex, int stateHash, int boolHash)
		{
			return null;
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFD")]
		[Address(RVA = "0x2F18B40", Offset = "0x2F17B40", VA = "0x182F18B40")]
		private IEnumerator WaitForDoorSequenceCompleted(int animHash)
		{
			return null;
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFE")]
		[Address(RVA = "0x2F175D0", Offset = "0x2F165D0", VA = "0x182F175D0")]
		protected static void OnWaitTimeout(string source)
		{
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFF")]
		[Address(RVA = "0x2F18510", Offset = "0x2F17510", VA = "0x182F18510")]
		private static void StashHeldItems()
		{
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D00")]
		[Address(RVA = "0x2F18560", Offset = "0x2F17560", VA = "0x182F18560")]
		private static void StashKeyItem()
		{
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D01")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "36")]
		internal virtual void DoEquipKeyItem()
		{
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D02")]
		[Address(RVA = "0x2F17FB0", Offset = "0x2F16FB0", VA = "0x182F17FB0")]
		private void StartPlayerSequence()
		{
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D03")]
		[Address(RVA = "0x2F17CA0", Offset = "0x2F16CA0", VA = "0x182F17CA0")]
		public static void SetPlayerLocked(bool locked)
		{
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D04")]
		[Address(RVA = "0x2F18980", Offset = "0x2F17980", VA = "0x182F18980")]
		private void UpdatePlayerAlign()
		{
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D05")]
		[Address(RVA = "0x2F187E0", Offset = "0x2F177E0", VA = "0x182F187E0")]
		private void UpdateAnimatorSync()
		{
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D06")]
		[Address(RVA = "0x2F16830", Offset = "0x2F15830", VA = "0x182F16830", Slot = "37")]
		protected virtual void FinalizePlayer()
		{
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D07")]
		[Address(RVA = "0x2F18C60", Offset = "0x2F17C60", VA = "0x182F18C60")]
		protected DoorTriggerCutsceneBase()
		{
		}

		// Token: 0x040040F3 RID: 16627
		[Token(Token = "0x40040F3")]
		[FieldOffset(Offset = "0xC0")]
		protected DoorState _doorState;

		// Token: 0x040040F4 RID: 16628
		[Token(Token = "0x40040F4")]
		[FieldOffset(Offset = "0xC4")]
		protected PlayerDoorState _localPlayerDoorState;

		// Token: 0x040040F5 RID: 16629
		[Token(Token = "0x40040F5")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		protected GenericInteraction _interaction;

		// Token: 0x040040F6 RID: 16630
		[Token(Token = "0x40040F6")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[FormerlySerializedAs("_targetAnimator")]
		protected Animator _doorAnimator;

		// Token: 0x040040F7 RID: 16631
		[Token(Token = "0x40040F7")]
		[FieldOffset(Offset = "0xD8")]
		private DoorState _lastUpdatedDoorState;

		// Token: 0x040040F8 RID: 16632
		[Token(Token = "0x40040F8")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[FormerlySerializedAs("_alignTransform")]
		private Transform _playerLocator;

		// Token: 0x040040F9 RID: 16633
		[Token(Token = "0x40040F9")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _playerAlignTimer;

		// Token: 0x040040FA RID: 16634
		[Token(Token = "0x40040FA")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private float _fov;

		// Token: 0x040040FB RID: 16635
		[Token(Token = "0x40040FB")]
		[FieldOffset(Offset = "0xF0")]
		private Animator _playerAnimator;

		// Token: 0x040040FC RID: 16636
		[Token(Token = "0x40040FC")]
		[FieldOffset(Offset = "0xF8")]
		private Vector3 _playerMovementOffset;

		// Token: 0x040040FD RID: 16637
		[Token(Token = "0x40040FD")]
		[FieldOffset(Offset = "0x104")]
		private Quaternion _playerRotationOffset;

		// Token: 0x040040FE RID: 16638
		[Token(Token = "0x40040FE")]
		[FieldOffset(Offset = "0x114")]
		private bool _localPlayerHasStashedItem;

		// Token: 0x040040FF RID: 16639
		[Token(Token = "0x40040FF")]
		[FieldOffset(Offset = "0x115")]
		private bool _isRemotePlayerInteraction;

		// Token: 0x04004100 RID: 16640
		[Token(Token = "0x4004100")]
		[FieldOffset(Offset = "0x118")]
		private float _originalFov;

		// Token: 0x04004101 RID: 16641
		[Token(Token = "0x4004101")]
		[FieldOffset(Offset = "0x120")]
		private AnimationSyncData _closedToOpenSyncData;
	}
}

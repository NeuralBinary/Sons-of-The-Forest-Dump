using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x0200095C RID: 2396
	[Token(Token = "0x200095C")]
	public class PlayerNetworkInteraction : BoltEntityListenerBehaviourWrapper<IMultiplayerInteractionState>
	{
		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06004561 RID: 17761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000917")]
		public string Id
		{
			[Token(Token = "0x6004561")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004562")]
		[Address(RVA = "0x3661180", Offset = "0x365F780", VA = "0x183661180")]
		public void SendActiveEventState()
		{
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004563")]
		[Address(RVA = "0x3661240", Offset = "0x365F840", VA = "0x183661240")]
		public void SendNoneEventState()
		{
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004564")]
		[Address(RVA = "0x3661300", Offset = "0x365F900", VA = "0x183661300")]
		private void DebugRemovedCallback()
		{
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004565")]
		[Address(RVA = "0x3661390", Offset = "0x365F990", VA = "0x183661390")]
		private void DebugAddedCallback()
		{
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004566")]
		[Address(RVA = "0x3661420", Offset = "0x365FA20", VA = "0x183661420")]
		public void GetCounts(out int activeCount, out int total)
		{
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004567")]
		[Address(RVA = "0x3661650", Offset = "0x365FC50", VA = "0x183661650", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004568")]
		[Address(RVA = "0x36618F0", Offset = "0x365FEF0", VA = "0x1836618F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004569")]
		[Address(RVA = "0x3661950", Offset = "0x365FF50", VA = "0x183661950")]
		private void OnInteractionIdChanged()
		{
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456A")]
		[Address(RVA = "0x3661960", Offset = "0x365FF60", VA = "0x183661960")]
		private void InteractionIdChanged(bool force = false)
		{
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x00015468 File Offset: 0x00013668
		[Token(Token = "0x600456B")]
		[Address(RVA = "0x3661AD0", Offset = "0x36600D0", VA = "0x183661AD0")]
		private bool HasInteractionIdChanged()
		{
			return default(bool);
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456C")]
		[Address(RVA = "0x3661BC0", Offset = "0x36601C0", VA = "0x183661BC0")]
		private void UnregisterId(PlayerNetworkInteraction source, string interactionId)
		{
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456D")]
		[Address(RVA = "0x3661E60", Offset = "0x3660460", VA = "0x183661E60")]
		private void RegisterId(PlayerNetworkInteraction source, string interactionId)
		{
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456E")]
		[Address(RVA = "0x36620C0", Offset = "0x36606C0", VA = "0x1836620C0")]
		private static void CleanUpNullRegisteredInteractions()
		{
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456F")]
		[Address(RVA = "0x3662490", Offset = "0x3660A90", VA = "0x183662490")]
		private void InitializeInternalCache()
		{
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004570")]
		[Address(RVA = "0x36627D0", Offset = "0x3660DD0", VA = "0x1836627D0")]
		private void OnActivePlayersChanged(IState sourceState, string propertyPath, ArrayIndices arrayIndices)
		{
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004571")]
		[Address(RVA = "0x3662A20", Offset = "0x3661020", VA = "0x183662A20")]
		private void OnActivePlayersChanged(ulong oldValue, ulong newValue, int index)
		{
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004572")]
		[Address(RVA = "0x3662D70", Offset = "0x3661370", VA = "0x183662D70")]
		private void CheckAllPlayersActive()
		{
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004573")]
		[Address(RVA = "0x36630E0", Offset = "0x36616E0", VA = "0x1836630E0")]
		private void Start()
		{
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004574")]
		[Address(RVA = "0x3663120", Offset = "0x3661720", VA = "0x183663120")]
		private void OnEnable()
		{
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004575")]
		[Address(RVA = "0x3663160", Offset = "0x3661760", VA = "0x183663160")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004576")]
		[Address(RVA = "0x3663170", Offset = "0x3661770", VA = "0x183663170")]
		private void OnDisable()
		{
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004577")]
		[Address(RVA = "0x3663280", Offset = "0x3661880", VA = "0x183663280")]
		public void SetReady(bool value)
		{
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004578")]
		[Address(RVA = "0x3663590", Offset = "0x3661B90", VA = "0x183663590")]
		public void SendInteractionEvent(PlayerNetworkInteractionState interactionState, Action addedCallback, Action removedCallback)
		{
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004579")]
		[Address(RVA = "0x3663870", Offset = "0x3661E70", VA = "0x183663870", Slot = "320")]
		public override void OnEvent(PlayerInteractionEvent playerInteractionEvent)
		{
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457A")]
		[Address(RVA = "0x3663BE0", Offset = "0x36621E0", VA = "0x183663BE0")]
		private void ProcessInteractionEvent(PlayerInteractionEvent playerInteractionEvent)
		{
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457B")]
		[Address(RVA = "0x3663CD0", Offset = "0x36622D0", VA = "0x183663CD0")]
		private void AddInteractionActive(NetworkId sentBy)
		{
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457C")]
		[Address(RVA = "0x3663F50", Offset = "0x3662550", VA = "0x183663F50")]
		private void RemoveInteractionActive(NetworkId sentBy)
		{
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457D")]
		[Address(RVA = "0x3664160", Offset = "0x3662760", VA = "0x183664160")]
		public void AddPerformedCallback(Action callback)
		{
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457E")]
		[Address(RVA = "0x3664240", Offset = "0x3662840", VA = "0x183664240")]
		public void RemovePerformedCallback(Action callback)
		{
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457F")]
		[Address(RVA = "0x3664320", Offset = "0x3662920", VA = "0x183664320")]
		public void AddInteractionActiveCallback(Action<int> callback)
		{
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004580")]
		[Address(RVA = "0x3664410", Offset = "0x3662A10", VA = "0x183664410")]
		public void RemoveInteractionActiveCallback(Action<int> callback)
		{
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004581")]
		[Address(RVA = "0x3664500", Offset = "0x3662B00", VA = "0x183664500")]
		public void AddInteractionRemoveCallback(Action<int> callback)
		{
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004582")]
		[Address(RVA = "0x36645F0", Offset = "0x3662BF0", VA = "0x1836645F0")]
		public void RemoveInteractionRemoveCallback(Action<int> callback)
		{
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x00015480 File Offset: 0x00013680
		[Token(Token = "0x6004583")]
		[Address(RVA = "0x36646E0", Offset = "0x3662CE0", VA = "0x1836646E0")]
		public static bool TryFind(string interactionId, out PlayerNetworkInteraction playerNetworkInteraction)
		{
			return default(bool);
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004584")]
		[Address(RVA = "0x3664930", Offset = "0x3662F30", VA = "0x183664930")]
		public PlayerNetworkInteraction()
		{
		}

		// Token: 0x040047E1 RID: 18401
		[Token(Token = "0x40047E1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _interactionId;

		// Token: 0x040047E2 RID: 18402
		[Token(Token = "0x40047E2")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("_onAllPlayersActiveUnityEvent")]
		[SerializeField]
		private UnityEvent _onPerformedUnityEvent;

		// Token: 0x040047E3 RID: 18403
		[Token(Token = "0x40047E3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent<ulong> _onPlayerInteractionActiveUnityEvent;

		// Token: 0x040047E4 RID: 18404
		[Token(Token = "0x40047E4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent<ulong> _onPlayerInteractionRemovedUnityEvent;

		// Token: 0x040047E5 RID: 18405
		[Token(Token = "0x40047E5")]
		[FieldOffset(Offset = "0x50")]
		private ulong[] _internalCacheActivePlayers;

		// Token: 0x040047E6 RID: 18406
		[Token(Token = "0x40047E6")]
		[FieldOffset(Offset = "0x58")]
		private Action _onPerformedCallback;

		// Token: 0x040047E7 RID: 18407
		[Token(Token = "0x40047E7")]
		[FieldOffset(Offset = "0x60")]
		private Action<int> _onPlayerInteractionActive;

		// Token: 0x040047E8 RID: 18408
		[Token(Token = "0x40047E8")]
		[FieldOffset(Offset = "0x68")]
		private Action<int> _onPlayerInteractionRemoved;

		// Token: 0x040047E9 RID: 18409
		[Token(Token = "0x40047E9")]
		[FieldOffset(Offset = "0x70")]
		private ulong _localRegisteredPlayerId;

		// Token: 0x040047EA RID: 18410
		[Token(Token = "0x40047EA")]
		[FieldOffset(Offset = "0x78")]
		private Action _localPlayerAddedCallback;

		// Token: 0x040047EB RID: 18411
		[Token(Token = "0x40047EB")]
		[FieldOffset(Offset = "0x80")]
		private Action _localPlayerRemovedCallback;

		// Token: 0x040047EC RID: 18412
		[Token(Token = "0x40047EC")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, PlayerNetworkInteraction> _registeredInteractions;

		// Token: 0x040047ED RID: 18413
		[Token(Token = "0x40047ED")]
		[FieldOffset(Offset = "0x88")]
		private uint _lastKnownPerformedFrame;
	}
}

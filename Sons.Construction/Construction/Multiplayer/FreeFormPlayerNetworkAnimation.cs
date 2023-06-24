using System;
using System.Runtime.CompilerServices;
using Bolt;
using Construction.Anim;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Multiplayer
{
	// Token: 0x0200027F RID: 639
	[Token(Token = "0x200027F")]
	[AddComponentMenu("Sons/Construction/FreeFormPlayerNetworkAnimation")]
	public class FreeFormPlayerNetworkAnimation : EntityBehaviour<IFreeFormPlayerAnimationState>, IEquipAccessoryListener, IPlaceActionCompletedReceiver
	{
		// Token: 0x06001388 RID: 5000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001388")]
		[Address(RVA = "0x2F59040", Offset = "0x2F57640", VA = "0x182F59040")]
		private void OnLeftHandAccessoryChanged()
		{
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001389")]
		[Address(RVA = "0x2F59180", Offset = "0x2F57780", VA = "0x182F59180")]
		private void OnRightHandAccessoryChanged()
		{
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600138A")]
		[Address(RVA = "0x2F592C0", Offset = "0x2F578C0", VA = "0x182F592C0", Slot = "24")]
		private void OnEquipped(LeftHandAccessories leftHandAccessory)
		{
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600138B")]
		[Address(RVA = "0x2F59360", Offset = "0x2F57960", VA = "0x182F59360", Slot = "25")]
		private void OnEquipped(RightHandAccessories rightHandAccessory)
		{
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000434")]
		public PlayerBuildingModeAction BuildAction
		{
			[Token(Token = "0x600138C")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600138D")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000435")]
		public RemotelyAnticipatedStructures RemotelyAnticipatedStructures
		{
			[Token(Token = "0x600138E")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600138F")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000436")]
		public string PlayerName
		{
			[Token(Token = "0x6001390")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001391")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001392")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void Awake()
		{
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001393")]
		[Address(RVA = "0x2F59400", Offset = "0x2F57A00", VA = "0x182F59400")]
		private void Update()
		{
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001394")]
		[Address(RVA = "0x2F59470", Offset = "0x2F57A70", VA = "0x182F59470")]
		public void InitForOwner(ConstructionManager manager)
		{
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001395")]
		[Address(RVA = "0x2F597B0", Offset = "0x2F57DB0", VA = "0x182F597B0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001396")]
		[Address(RVA = "0x2F59B40", Offset = "0x2F58140", VA = "0x182F59B40")]
		private void OnPlayerSet()
		{
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001397")]
		[Address(RVA = "0x2F5A6C0", Offset = "0x2F58CC0", VA = "0x182F5A6C0")]
		public void SendPlaceAnimData(IConstructionModule module, TargetInfo targetInfo, int placementMode)
		{
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001398")]
		[Address(RVA = "0x2F5A8D0", Offset = "0x2F58ED0", VA = "0x182F5A8D0")]
		public void SendStoppedAnimation(AnimStatus status)
		{
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001399")]
		[Address(RVA = "0x2F5AAE0", Offset = "0x2F590E0", VA = "0x182F5AAE0", Slot = "26")]
		private void PlaceActionCompletedNoReset()
		{
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600139A")]
		[Address(RVA = "0x2F5AAE0", Offset = "0x2F590E0", VA = "0x182F5AAE0", Slot = "27")]
		private void PlaceActionCompleted()
		{
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600139B")]
		[Address(RVA = "0x2F5AAF0", Offset = "0x2F590F0", VA = "0x182F5AAF0")]
		private void BeginForceCancelDelay()
		{
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600139C")]
		[Address(RVA = "0x2F5AC30", Offset = "0x2F59230", VA = "0x182F5AC30")]
		public void ForceCancelAndRevert()
		{
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600139D")]
		[Address(RVA = "0x2F5ACA0", Offset = "0x2F592A0", VA = "0x182F5ACA0")]
		public void ValidatedPlacement()
		{
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600139E")]
		[Address(RVA = "0x2F5AD20", Offset = "0x2F59320", VA = "0x182F5AD20")]
		public FreeFormPlayerNetworkAnimation()
		{
		}

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4000982")]
		[FieldOffset(Offset = "0x28")]
		private float _forceCancelTime;

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4000983")]
		[FieldOffset(Offset = "0x30")]
		private ConstructionManager _ownerConstructionManager;
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Items.Core;
using UdpKit;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Inventory
{
	// Token: 0x0200062B RID: 1579
	[Token(Token = "0x200062B")]
	[Serializable]
	public class PerishableItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		[Token(Token = "0x1700055C")]
		public float TimeRemainingInState
		{
			[Token(Token = "0x6002904")]
			[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x0000C210 File Offset: 0x0000A410
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055D")]
		public bool PauseDecay
		{
			[Token(Token = "0x6002905")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002906")]
			[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055E")]
		public PerishableItemData.StateData CurrentStateData
		{
			[Token(Token = "0x6002907")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002908")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002909")]
		[Address(RVA = "0x33E6DE0", Offset = "0x33E53E0", VA = "0x1833E6DE0", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290A")]
		[Address(RVA = "0x33E6EB0", Offset = "0x33E54B0", VA = "0x1833E6EB0", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290B")]
		[Address(RVA = "0x33E6F40", Offset = "0x33E5540", VA = "0x1833E6F40", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290C")]
		[Address(RVA = "0x33E7210", Offset = "0x33E5810", VA = "0x1833E7210")]
		public void SetState(PerishableItemData.State newState, float remainingDuration = -1f, bool force = false)
		{
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290D")]
		[Address(RVA = "0x33E7A70", Offset = "0x33E6070", VA = "0x1833E7A70")]
		private void Decay()
		{
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290E")]
		[Address(RVA = "0x33E7B30", Offset = "0x33E6130", VA = "0x1833E7B30", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290F")]
		[Address(RVA = "0x33E7BE0", Offset = "0x33E61E0", VA = "0x1833E7BE0", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002910")]
		[Address(RVA = "0x33E7C80", Offset = "0x33E6280", VA = "0x1833E7C80", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002911")]
		[Address(RVA = "0x33E7D00", Offset = "0x33E6300", VA = "0x1833E7D00", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002912")]
		[Address(RVA = "0x33E7DA0", Offset = "0x33E63A0", VA = "0x1833E7DA0")]
		public PerishableItemInstanceModule()
		{
		}

		// Token: 0x040024C1 RID: 9409
		[Token(Token = "0x40024C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PerishableItemData.State _currentState;

		// Token: 0x040024C2 RID: 9410
		[Token(Token = "0x40024C2")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _remainingSecondsUntilDecay;

		// Token: 0x040024C4 RID: 9412
		[Token(Token = "0x40024C4")]
		[FieldOffset(Offset = "0x30")]
		private PerishableItemData _data;

		// Token: 0x040024C5 RID: 9413
		[Token(Token = "0x40024C5")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<PerishableItemData.State> OnStateChanged;

		// Token: 0x040024C7 RID: 9415
		[Token(Token = "0x40024C7")]
		[FieldOffset(Offset = "0x48")]
		private GameObject _itemObject;

		// Token: 0x0200062C RID: 1580
		[Token(Token = "0x200062C")]
		[Serializable]
		public class PerishableSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x06002913 RID: 10515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002913")]
			[Address(RVA = "0x33CE370", Offset = "0x33CC970", VA = "0x1833CE370")]
			public PerishableSaveData()
			{
			}

			// Token: 0x040024C8 RID: 9416
			[Token(Token = "0x40024C8")]
			[FieldOffset(Offset = "0x20")]
			public int CurrentState;

			// Token: 0x040024C9 RID: 9417
			[Token(Token = "0x40024C9")]
			[FieldOffset(Offset = "0x24")]
			public float TimeRemainingInState;

			// Token: 0x040024CA RID: 9418
			[Token(Token = "0x40024CA")]
			[FieldOffset(Offset = "0x28")]
			public bool PauseDecay;
		}
	}
}

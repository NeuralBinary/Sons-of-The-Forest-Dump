using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Items.Core;
using UdpKit;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Inventory
{
	// Token: 0x02000615 RID: 1557
	[Token(Token = "0x2000615")]
	[Serializable]
	public class PerishableItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x0000BA48 File Offset: 0x00009C48
		[Token(Token = "0x17000544")]
		public float TimeRemainingInState
		{
			[Token(Token = "0x60027DC")]
			[Address(RVA = "0x567910", Offset = "0x566910", VA = "0x180567910")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x0000BA60 File Offset: 0x00009C60
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000545")]
		public bool PauseDecay
		{
			[Token(Token = "0x60027DD")]
			[Address(RVA = "0x5BA880", Offset = "0x5B9880", VA = "0x1805BA880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60027DE")]
			[Address(RVA = "0x5BA890", Offset = "0x5B9890", VA = "0x1805BA890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000546")]
		public PerishableItemData.StateData CurrentStateData
		{
			[Token(Token = "0x60027DF")]
			[Address(RVA = "0x52F1A0", Offset = "0x52E1A0", VA = "0x18052F1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027E0")]
			[Address(RVA = "0x692A50", Offset = "0x691A50", VA = "0x180692A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x2DC1EC0", Offset = "0x2DC0EC0", VA = "0x182DC1EC0", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x2DC18D0", Offset = "0x2DC08D0", VA = "0x182DC18D0", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E3")]
		[Address(RVA = "0x2DC1630", Offset = "0x2DC0630", VA = "0x182DC1630", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E4")]
		[Address(RVA = "0x2DC19D0", Offset = "0x2DC09D0", VA = "0x182DC19D0")]
		public void SetState(PerishableItemData.State newState, float remainingDuration = -1f, bool force = false)
		{
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E5")]
		[Address(RVA = "0x2DC14D0", Offset = "0x2DC04D0", VA = "0x182DC14D0")]
		private void Decay()
		{
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E6")]
		[Address(RVA = "0x2DC1930", Offset = "0x2DC0930", VA = "0x182DC1930", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E7")]
		[Address(RVA = "0x2DC1870", Offset = "0x2DC0870", VA = "0x182DC1870", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E8")]
		[Address(RVA = "0x2DC1590", Offset = "0x2DC0590", VA = "0x182DC1590", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E9")]
		[Address(RVA = "0x2DC17D0", Offset = "0x2DC07D0", VA = "0x182DC17D0", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EA")]
		[Address(RVA = "0x2DC1F90", Offset = "0x2DC0F90", VA = "0x182DC1F90")]
		public PerishableItemInstanceModule()
		{
		}

		// Token: 0x040023CB RID: 9163
		[Token(Token = "0x40023CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PerishableItemData.State _currentState;

		// Token: 0x040023CC RID: 9164
		[Token(Token = "0x40023CC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _remainingSecondsUntilDecay;

		// Token: 0x040023CE RID: 9166
		[Token(Token = "0x40023CE")]
		[FieldOffset(Offset = "0x30")]
		private PerishableItemData _data;

		// Token: 0x040023CF RID: 9167
		[Token(Token = "0x40023CF")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<PerishableItemData.State> OnStateChanged;

		// Token: 0x040023D1 RID: 9169
		[Token(Token = "0x40023D1")]
		[FieldOffset(Offset = "0x48")]
		private GameObject _itemObject;

		// Token: 0x02000616 RID: 1558
		[Token(Token = "0x2000616")]
		[Serializable]
		public class PerishableSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x060027EB RID: 10219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60027EB")]
			[Address(RVA = "0x2DC2180", Offset = "0x2DC1180", VA = "0x182DC2180")]
			public PerishableSaveData()
			{
			}

			// Token: 0x040023D2 RID: 9170
			[Token(Token = "0x40023D2")]
			[FieldOffset(Offset = "0x20")]
			public int CurrentState;

			// Token: 0x040023D3 RID: 9171
			[Token(Token = "0x40023D3")]
			[FieldOffset(Offset = "0x24")]
			public float TimeRemainingInState;

			// Token: 0x040023D4 RID: 9172
			[Token(Token = "0x40023D4")]
			[FieldOffset(Offset = "0x28")]
			public bool PauseDecay;
		}
	}
}

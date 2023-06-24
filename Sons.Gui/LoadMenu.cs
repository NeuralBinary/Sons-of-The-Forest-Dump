using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gui
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[AddComponentMenu("Sons/Gui/LoadMenu")]
	public class LoadMenu : SaveLoadMenuBase
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000A")]
		public event Action<int> OnLoadSlotSelected
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x30108C0", Offset = "0x300EEC0", VA = "0x1830108C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x3010A30", Offset = "0x300F030", VA = "0x183010A30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x3010BA0", Offset = "0x300F1A0", VA = "0x183010BA0", Slot = "4")]
		protected override void SetupSlots()
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x3010E10", Offset = "0x300F410", VA = "0x183010E10")]
		private void LoadSlotActivated(int slotIndex, GameStateData data)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x3010EE0", Offset = "0x300F4E0", VA = "0x183010EE0")]
		public LoadMenu()
		{
		}

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UnityEvent<int> _slotSelectedEvent;
	}
}

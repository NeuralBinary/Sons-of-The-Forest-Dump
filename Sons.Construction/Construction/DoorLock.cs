using System;
using Il2CppDummyDll;
using Sons.Gui.Input;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000162 RID: 354
	[Token(Token = "0x2000162")]
	[AddComponentMenu("Sons/Construction/DoorLock")]
	public class DoorLock : SwitchStateBase
	{
		// Token: 0x06000A91 RID: 2705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x2E9C340", Offset = "0x2E9A940", VA = "0x182E9C340")]
		private void Update()
		{
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x2E9C3E0", Offset = "0x2E9A9E0", VA = "0x182E9C3E0", Slot = "6")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x2E9C450", Offset = "0x2E9AA50", VA = "0x182E9C450")]
		public void SwitchLockState(Vector3 playerPosition)
		{
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00006E54 File Offset: 0x00005054
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x2E9C860", Offset = "0x2E9AE60", VA = "0x182E9C860")]
		private bool IsInFront(Vector3 playerPosition)
		{
			return default(bool);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x2E9C980", Offset = "0x2E9AF80", VA = "0x182E9C980", Slot = "7")]
		public override void SwitchState(Vector3 playerPosition)
		{
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DoorLock()
		{
		}

		// Token: 0x040006B6 RID: 1718
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LinkUiElement _icon;

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ElementProfile _switchTo;

		// Token: 0x040006B8 RID: 1720
		[Token(Token = "0x40006B8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClipProfile _sfx;
	}
}

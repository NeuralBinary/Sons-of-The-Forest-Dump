using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008D6 RID: 2262
	[Token(Token = "0x20008D6")]
	[AddComponentMenu("Sons/Items/SeveredHeadController")]
	public class SeveredHeadController : HeldControllerBase
	{
		// Token: 0x060040B3 RID: 16563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B3")]
		[Address(RVA = "0x36048F0", Offset = "0x3602EF0", VA = "0x1836048F0", Slot = "10")]
		protected virtual void Update()
		{
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B4")]
		[Address(RVA = "0x3604A70", Offset = "0x3603070", VA = "0x183604A70")]
		private void CheckFireInput()
		{
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B5")]
		[Address(RVA = "0x3604DE0", Offset = "0x36033E0", VA = "0x183604DE0")]
		private void HoldHead()
		{
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x00013C50 File Offset: 0x00011E50
		[Token(Token = "0x60040B6")]
		[Address(RVA = "0x3604F90", Offset = "0x3603590", VA = "0x183604F90", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B7")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SeveredHeadController()
		{
		}

		// Token: 0x040035D6 RID: 13782
		[Token(Token = "0x40035D6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private EventStimuli _holdEvent;

		// Token: 0x040035D7 RID: 13783
		[Token(Token = "0x40035D7")]
		[FieldOffset(Offset = "0x70")]
		private bool _currentReloadHasTriggered;
	}
}

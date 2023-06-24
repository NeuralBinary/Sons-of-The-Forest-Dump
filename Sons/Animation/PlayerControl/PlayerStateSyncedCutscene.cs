using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Save;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x0200095F RID: 2399
	[Token(Token = "0x200095F")]
	public class PlayerStateSyncedCutscene : Cutscene
	{
		// Token: 0x0600458A RID: 17802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458A")]
		[Address(RVA = "0x3664DD0", Offset = "0x36633D0", VA = "0x183664DD0")]
		public static List<string> ListForDropdown()
		{
			return null;
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458B")]
		[Address(RVA = "0x3664E10", Offset = "0x3663410", VA = "0x183664E10", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458C")]
		[Address(RVA = "0x3664E10", Offset = "0x3663410", VA = "0x183664E10")]
		protected void SetupStateSync()
		{
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x000154B0 File Offset: 0x000136B0
		[Token(Token = "0x600458D")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "15")]
		internal virtual int GetDefaultStateValue()
		{
			return 0;
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		protected virtual void AppliedState(NamedIntData saveValue)
		{
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "17")]
		protected virtual void InitializeState(NamedIntData saveValue)
		{
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004590")]
		[Address(RVA = "0x3648F30", Offset = "0x3647530", VA = "0x183648F30")]
		public PlayerStateSyncedCutscene()
		{
		}

		// Token: 0x040047F5 RID: 18421
		[Token(Token = "0x40047F5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _saveDataId;

		// Token: 0x040047F6 RID: 18422
		[Token(Token = "0x40047F6")]
		[FieldOffset(Offset = "0xB8")]
		protected NamedIntData _namedIntData;
	}
}

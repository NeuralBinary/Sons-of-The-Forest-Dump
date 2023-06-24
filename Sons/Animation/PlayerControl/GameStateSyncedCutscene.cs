using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Save;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x0200094C RID: 2380
	[Token(Token = "0x200094C")]
	public class GameStateSyncedCutscene : Cutscene
	{
		// Token: 0x060044CC RID: 17612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044CC")]
		[Address(RVA = "0x3658E90", Offset = "0x3657490", VA = "0x183658E90")]
		public static List<string> ListForDropdown()
		{
			return null;
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CD")]
		[Address(RVA = "0x3658ED0", Offset = "0x36574D0", VA = "0x183658ED0", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CE")]
		[Address(RVA = "0x3658EE0", Offset = "0x36574E0", VA = "0x183658EE0")]
		protected void SetupStateSync()
		{
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x00014F40 File Offset: 0x00013140
		[Token(Token = "0x60044CF")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "15")]
		internal virtual int GetDefaultStateValue()
		{
			return 0;
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		protected virtual void AppliedState(NamedIntData saveValue)
		{
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "17")]
		protected virtual void InitializeState(NamedIntData saveValue)
		{
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D2")]
		[Address(RVA = "0x3648F30", Offset = "0x3647530", VA = "0x183648F30")]
		public GameStateSyncedCutscene()
		{
		}

		// Token: 0x0400478D RID: 18317
		[Token(Token = "0x400478D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _saveDataId;

		// Token: 0x0400478E RID: 18318
		[Token(Token = "0x400478E")]
		[FieldOffset(Offset = "0xB8")]
		protected NamedIntData _namedIntData;
	}
}

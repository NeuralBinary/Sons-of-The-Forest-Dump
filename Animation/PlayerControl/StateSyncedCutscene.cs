using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Save;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008E0 RID: 2272
	[Token(Token = "0x20008E0")]
	public class StateSyncedCutscene : Cutscene
	{
		// Token: 0x06003DCC RID: 15820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DCC")]
		[Address(RVA = "0x2F25160", Offset = "0x2F24160", VA = "0x182F25160")]
		public static List<string> ListForDropdown()
		{
			return null;
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DCD")]
		[Address(RVA = "0x2F251A0", Offset = "0x2F241A0", VA = "0x182F251A0", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DCE")]
		[Address(RVA = "0x2F251A0", Offset = "0x2F241A0", VA = "0x182F251A0")]
		protected void SetupStateSync()
		{
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x00012300 File Offset: 0x00010500
		[Token(Token = "0x6003DCF")]
		[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "15")]
		internal virtual int GetDefaultStateValue()
		{
			return default(int);
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD0")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "16")]
		protected virtual void AppliedState(NamedIntData saveValue)
		{
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD1")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "17")]
		protected virtual void InitializeState(NamedIntData saveValue)
		{
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD2")]
		[Address(RVA = "0x2F12370", Offset = "0x2F11370", VA = "0x182F12370")]
		public StateSyncedCutscene()
		{
		}

		// Token: 0x0400418E RID: 16782
		[Token(Token = "0x400418E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _saveDataId;

		// Token: 0x0400418F RID: 16783
		[Token(Token = "0x400418F")]
		[FieldOffset(Offset = "0xB8")]
		protected NamedIntData _namedIntData;
	}
}

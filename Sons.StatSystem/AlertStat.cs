using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.StatSystem
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[Serializable]
	public class AlertStat : Stat
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x3144BE0", Offset = "0x31431E0", VA = "0x183144BE0", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x3144C10", Offset = "0x3143210", VA = "0x183144C10", Slot = "7")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x3144C40", Offset = "0x3143240", VA = "0x183144C40")]
		public AlertStat()
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x3144CC0", Offset = "0x31432C0", VA = "0x183144CC0", Slot = "8")]
		public override void OnValidate()
		{
		}

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color GUIColor;
	}
}

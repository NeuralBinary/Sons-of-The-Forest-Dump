using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.StatSystem
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[Serializable]
	public class AffectionStat : Stat
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x31449C0", Offset = "0x3142FC0", VA = "0x1831449C0", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x31449F0", Offset = "0x3142FF0", VA = "0x1831449F0", Slot = "7")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x3144A20", Offset = "0x3143020", VA = "0x183144A20", Slot = "5")]
		public override string EditorGuiIconPath()
		{
			return null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x3144A50", Offset = "0x3143050", VA = "0x183144A50")]
		public AffectionStat()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x3144AD0", Offset = "0x31430D0", VA = "0x183144AD0", Slot = "8")]
		public override void OnValidate()
		{
		}

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color GUIColor;
	}
}

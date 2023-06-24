using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.StatSystem
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[Serializable]
	public class AngerStat : Stat
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x3144DD0", Offset = "0x31433D0", VA = "0x183144DD0", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x3144E00", Offset = "0x3143400", VA = "0x183144E00", Slot = "7")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x3144E30", Offset = "0x3143430", VA = "0x183144E30", Slot = "5")]
		public override string EditorGuiIconPath()
		{
			return null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x3144E60", Offset = "0x3143460", VA = "0x183144E60")]
		public AngerStat()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x3144EE0", Offset = "0x31434E0", VA = "0x183144EE0", Slot = "8")]
		public override void OnValidate()
		{
		}

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color GUIColor;
	}
}

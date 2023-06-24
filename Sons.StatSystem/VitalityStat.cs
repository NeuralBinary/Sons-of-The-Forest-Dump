using System;
using Il2CppDummyDll;

namespace Sons.StatSystem
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[Serializable]
	public class VitalityStat : Stat
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x3145F20", Offset = "0x3144520", VA = "0x183145F20")]
		public VitalityStat()
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x31467D0", Offset = "0x3144DD0", VA = "0x1831467D0", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x3146800", Offset = "0x3144E00", VA = "0x183146800", Slot = "7")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x3146830", Offset = "0x3144E30", VA = "0x183146830", Slot = "5")]
		public override string EditorGuiIconPath()
		{
			return null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x3146860", Offset = "0x3144E60", VA = "0x183146860", Slot = "8")]
		public override void OnValidate()
		{
		}
	}
}

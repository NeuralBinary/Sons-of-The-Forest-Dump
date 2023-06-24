using System;
using Il2CppDummyDll;

namespace Sons.StatSystem
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[Serializable]
	public class StrengthStat : Stat
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x31463D0", Offset = "0x31449D0", VA = "0x1831463D0")]
		public StrengthStat()
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x31463F0", Offset = "0x31449F0", VA = "0x1831463F0", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x3146420", Offset = "0x3144A20", VA = "0x183146420", Slot = "7")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x3146450", Offset = "0x3144A50", VA = "0x183146450", Slot = "5")]
		public override string EditorGuiIconPath()
		{
			return null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x3146480", Offset = "0x3144A80", VA = "0x183146480", Slot = "8")]
		public override void OnValidate()
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
		public new void SetMax(float value)
		{
		}
	}
}

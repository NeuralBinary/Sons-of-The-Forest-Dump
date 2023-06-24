using System;
using Il2CppDummyDll;

namespace Sons.StatSystem
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[Serializable]
	public class StaminaStat : Stat
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x31460A0", Offset = "0x31446A0", VA = "0x1831460A0", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x31460D0", Offset = "0x31446D0", VA = "0x1831460D0", Slot = "7")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x3146100", Offset = "0x3144700", VA = "0x183146100", Slot = "5")]
		public override string EditorGuiIconPath()
		{
			return null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x3146130", Offset = "0x3144730", VA = "0x183146130")]
		public StaminaStat()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x3146150", Offset = "0x3144750", VA = "0x183146150", Slot = "8")]
		public override void OnValidate()
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
		public new void SetMax(float value)
		{
		}
	}
}

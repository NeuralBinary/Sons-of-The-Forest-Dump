using System;
using Il2CppDummyDll;

namespace Sons.StatSystem
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[Serializable]
	public class HealthStat : Stat
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x3145800", Offset = "0x3143E00", VA = "0x183145800", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x3145830", Offset = "0x3143E30", VA = "0x183145830", Slot = "7")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x3145860", Offset = "0x3143E60", VA = "0x183145860", Slot = "5")]
		public override string EditorGuiIconPath()
		{
			return null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x3145890", Offset = "0x3143E90", VA = "0x183145890")]
		public HealthStat()
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x31458B0", Offset = "0x3143EB0", VA = "0x1831458B0", Slot = "8")]
		public override void OnValidate()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x3145970", Offset = "0x3143F70", VA = "0x183145970")]
		public new void SetMax(float value)
		{
		}
	}
}

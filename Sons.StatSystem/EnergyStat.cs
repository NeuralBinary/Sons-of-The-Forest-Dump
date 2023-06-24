using System;
using Il2CppDummyDll;

namespace Sons.StatSystem
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[Serializable]
	public class EnergyStat : Stat
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x31452E0", Offset = "0x31438E0", VA = "0x1831452E0", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x3145310", Offset = "0x3143910", VA = "0x183145310", Slot = "7")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x3145340", Offset = "0x3143940", VA = "0x183145340", Slot = "5")]
		public override string EditorGuiIconPath()
		{
			return null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x3145370", Offset = "0x3143970", VA = "0x183145370")]
		public EnergyStat()
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x3145390", Offset = "0x3143990", VA = "0x183145390", Slot = "8")]
		public override void OnValidate()
		{
		}
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[Serializable]
	public class HoldAt : ActionTemplate
	{
		// Token: 0x06000059 RID: 89 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2D1E330", Offset = "0x2D1C930", VA = "0x182D1E330", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2D1E350", Offset = "0x2D1C950", VA = "0x182D1E350", Slot = "6")]
		public override bool AllowInterrupt()
		{
			return default(bool);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x213CBB0", Offset = "0x213B1B0", VA = "0x18213CBB0", Slot = "9")]
		public override bool NoRootMotion()
		{
			return default(bool);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2D1E360", Offset = "0x2D1C960", VA = "0x182D1E360", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2BC0FA0", Offset = "0x2BBF5A0", VA = "0x182BC0FA0")]
		public HoldAt()
		{
		}

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _disableInterrupts;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool _disableRootMotion;
	}
}

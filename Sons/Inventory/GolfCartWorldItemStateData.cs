using System;
using Il2CppDummyDll;

namespace Sons.Inventory
{
	// Token: 0x020005FB RID: 1531
	[Token(Token = "0x20005FB")]
	[Serializable]
	public class GolfCartWorldItemStateData : WorldItemStateData
	{
		// Token: 0x060027D5 RID: 10197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D5")]
		[Address(RVA = "0x33CE380", Offset = "0x33CC980", VA = "0x1833CE380")]
		public GolfCartWorldItemStateData()
		{
		}

		// Token: 0x0400240D RID: 9229
		[Token(Token = "0x400240D")]
		public const int GolfCartWorldItemStateDataTypeId = 1;

		// Token: 0x0400240E RID: 9230
		[Token(Token = "0x400240E")]
		[FieldOffset(Offset = "0x20")]
		public float Power;

		// Token: 0x0400240F RID: 9231
		[Token(Token = "0x400240F")]
		[FieldOffset(Offset = "0x24")]
		public new int StateDataTypeId;
	}
}

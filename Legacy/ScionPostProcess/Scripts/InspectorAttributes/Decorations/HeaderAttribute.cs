using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations
{
	// Token: 0x0200059E RID: 1438
	[Token(Token = "0x200059E")]
	public class HeaderAttribute : DecorationAttribute
	{
		// Token: 0x06002527 RID: 9511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002527")]
		[Address(RVA = "0x2D83770", Offset = "0x2D82770", VA = "0x182D83770")]
		public HeaderAttribute(int order, string header)
		{
		}

		// Token: 0x0400217C RID: 8572
		[Token(Token = "0x400217C")]
		[FieldOffset(Offset = "0x20")]
		public readonly string header;
	}
}

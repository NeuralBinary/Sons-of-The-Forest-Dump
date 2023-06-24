using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations
{
	// Token: 0x020005AE RID: 1454
	[Token(Token = "0x20005AE")]
	public class HeaderAttribute : DecorationAttribute
	{
		// Token: 0x06002626 RID: 9766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002626")]
		[Address(RVA = "0x33A6600", Offset = "0x33A4C00", VA = "0x1833A6600")]
		public HeaderAttribute(int order, string header)
		{
		}

		// Token: 0x04002250 RID: 8784
		[Token(Token = "0x4002250")]
		[FieldOffset(Offset = "0x20")]
		public readonly string header;
	}
}

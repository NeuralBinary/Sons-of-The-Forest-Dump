using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes
{
	// Token: 0x020005A9 RID: 1449
	[Token(Token = "0x20005A9")]
	public class GroupAttribute : InspectorAttribute
	{
		// Token: 0x0600261D RID: 9757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261D")]
		[Address(RVA = "0x33A63A0", Offset = "0x33A49A0", VA = "0x1833A63A0")]
		public GroupAttribute()
		{
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261E")]
		[Address(RVA = "0x33A6400", Offset = "0x33A4A00", VA = "0x1833A6400")]
		public GroupAttribute(string label)
		{
		}

		// Token: 0x04002249 RID: 8777
		[Token(Token = "0x4002249")]
		[FieldOffset(Offset = "0x48")]
		public bool drawFoldout;
	}
}

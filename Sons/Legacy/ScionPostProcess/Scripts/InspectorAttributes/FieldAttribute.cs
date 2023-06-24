using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes
{
	// Token: 0x020005A6 RID: 1446
	[Token(Token = "0x20005A6")]
	public class FieldAttribute : InspectorAttribute
	{
		// Token: 0x06002616 RID: 9750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002616")]
		[Address(RVA = "0x33A63A0", Offset = "0x33A49A0", VA = "0x1833A63A0")]
		public FieldAttribute()
		{
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x33A6400", Offset = "0x33A4A00", VA = "0x1833A6400")]
		public FieldAttribute(string label)
		{
		}

		// Token: 0x04002245 RID: 8773
		[Token(Token = "0x4002245")]
		[FieldOffset(Offset = "0x48")]
		public bool allowSceneObjects;
	}
}

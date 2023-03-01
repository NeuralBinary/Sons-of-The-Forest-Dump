using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes
{
	// Token: 0x02000596 RID: 1430
	[Token(Token = "0x2000596")]
	public class FieldAttribute : InspectorAttribute
	{
		// Token: 0x06002517 RID: 9495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002517")]
		[Address(RVA = "0x2D82FE0", Offset = "0x2D81FE0", VA = "0x182D82FE0")]
		public FieldAttribute()
		{
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002518")]
		[Address(RVA = "0x2D83010", Offset = "0x2D82010", VA = "0x182D83010")]
		public FieldAttribute(string label)
		{
		}

		// Token: 0x04002171 RID: 8561
		[Token(Token = "0x4002171")]
		[FieldOffset(Offset = "0x48")]
		public bool allowSceneObjects;
	}
}

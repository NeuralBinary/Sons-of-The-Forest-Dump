using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes
{
	// Token: 0x02000599 RID: 1433
	[Token(Token = "0x2000599")]
	public class GroupAttribute : InspectorAttribute
	{
		// Token: 0x0600251E RID: 9502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251E")]
		[Address(RVA = "0x2D82FE0", Offset = "0x2D81FE0", VA = "0x182D82FE0")]
		public GroupAttribute()
		{
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251F")]
		[Address(RVA = "0x2D83010", Offset = "0x2D82010", VA = "0x182D83010")]
		public GroupAttribute(string label)
		{
		}

		// Token: 0x04002175 RID: 8565
		[Token(Token = "0x4002175")]
		[FieldOffset(Offset = "0x48")]
		public bool drawFoldout;
	}
}

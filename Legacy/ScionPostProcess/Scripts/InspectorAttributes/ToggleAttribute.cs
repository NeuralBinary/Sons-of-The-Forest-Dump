using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes
{
	// Token: 0x02000598 RID: 1432
	[Token(Token = "0x2000598")]
	public class ToggleAttribute : InspectorAttribute
	{
		// Token: 0x0600251C RID: 9500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251C")]
		[Address(RVA = "0x2D82F60", Offset = "0x2D81F60", VA = "0x182D82F60")]
		public ToggleAttribute()
		{
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251D")]
		[Address(RVA = "0x8FF070", Offset = "0x8FE070", VA = "0x1808FF070")]
		public ToggleAttribute(string label)
		{
		}

		// Token: 0x04002174 RID: 8564
		[Token(Token = "0x4002174")]
		[FieldOffset(Offset = "0x48")]
		public bool flipped;
	}
}

using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x0200082F RID: 2095
	[Token(Token = "0x200082F")]
	[Flags]
	[Serializable]
	public enum TreeCutCellRemovedFlags
	{
		// Token: 0x04003248 RID: 12872
		[Token(Token = "0x4003248")]
		Undefined = 0,
		// Token: 0x04003249 RID: 12873
		[Token(Token = "0x4003249")]
		Self = 16,
		// Token: 0x0400324A RID: 12874
		[Token(Token = "0x400324A")]
		Dir0 = 32,
		// Token: 0x0400324B RID: 12875
		[Token(Token = "0x400324B")]
		Dir1 = 64,
		// Token: 0x0400324C RID: 12876
		[Token(Token = "0x400324C")]
		Dir2 = 128,
		// Token: 0x0400324D RID: 12877
		[Token(Token = "0x400324D")]
		Dir3 = 256,
		// Token: 0x0400324E RID: 12878
		[Token(Token = "0x400324E")]
		Dir4 = 512,
		// Token: 0x0400324F RID: 12879
		[Token(Token = "0x400324F")]
		Dir5 = 1024,
		// Token: 0x04003250 RID: 12880
		[Token(Token = "0x4003250")]
		Dir6 = 2048,
		// Token: 0x04003251 RID: 12881
		[Token(Token = "0x4003251")]
		Dir7 = 4096
	}
}

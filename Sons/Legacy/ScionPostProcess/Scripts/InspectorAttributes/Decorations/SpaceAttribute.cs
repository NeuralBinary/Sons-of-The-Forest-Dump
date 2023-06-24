using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations
{
	// Token: 0x020005AD RID: 1453
	[Token(Token = "0x20005AD")]
	public class SpaceAttribute : DecorationAttribute
	{
		// Token: 0x06002625 RID: 9765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002625")]
		[Address(RVA = "0x33A65F0", Offset = "0x33A4BF0", VA = "0x1833A65F0")]
		public SpaceAttribute(int order, int height)
		{
		}

		// Token: 0x0400224F RID: 8783
		[Token(Token = "0x400224F")]
		[FieldOffset(Offset = "0x20")]
		public readonly int height;
	}
}

using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations
{
	// Token: 0x0200059D RID: 1437
	[Token(Token = "0x200059D")]
	public class SpaceAttribute : DecorationAttribute
	{
		// Token: 0x06002526 RID: 9510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002526")]
		[Address(RVA = "0x2D905E0", Offset = "0x2D8F5E0", VA = "0x182D905E0")]
		public SpaceAttribute(int order, int height)
		{
		}

		// Token: 0x0400217B RID: 8571
		[Token(Token = "0x400217B")]
		[FieldOffset(Offset = "0x20")]
		public readonly int height;
	}
}

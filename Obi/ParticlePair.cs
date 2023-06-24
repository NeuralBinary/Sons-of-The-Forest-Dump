using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	public struct ParticlePair
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x60DE80", Offset = "0x60C480", VA = "0x18060DE80")]
		public ParticlePair(int first, int second)
		{
		}

		// Token: 0x17000105 RID: 261
		[Token(Token = "0x17000105")]
		public int this[int index]
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x1E2AB80", Offset = "0x1E29180", VA = "0x181E2AB80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x1E2AB90", Offset = "0x1E29190", VA = "0x181E2AB90")]
			set
			{
			}
		}

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x0")]
		public int first;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x4")]
		public int second;
	}
}

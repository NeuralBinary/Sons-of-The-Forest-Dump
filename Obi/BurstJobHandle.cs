using System;
using Il2CppDummyDll;
using Unity.Jobs;

namespace Obi
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public class BurstJobHandle : IObiJobHandle
	{
		// Token: 0x06000250 RID: 592 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x74B710", Offset = "0x749D10", VA = "0x18074B710")]
		public BurstJobHandle(JobHandle handle)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2765B20", Offset = "0x2764120", VA = "0x182765B20", Slot = "4")]
		public void Complete()
		{
		}

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x10")]
		public JobHandle handle;
	}
}

using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000300 RID: 768
	[Token(Token = "0x2000300")]
	public class MeshBoundaryLoopsException : Exception
	{
		// Token: 0x060019E3 RID: 6627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019E3")]
		[Address(RVA = "0x1F16E30", Offset = "0x1F15430", VA = "0x181F16E30")]
		public MeshBoundaryLoopsException(string message)
		{
		}

		// Token: 0x04000DAE RID: 3502
		[Token(Token = "0x4000DAE")]
		[FieldOffset(Offset = "0x90")]
		public bool UnclosedLoop;

		// Token: 0x04000DAF RID: 3503
		[Token(Token = "0x4000DAF")]
		[FieldOffset(Offset = "0x91")]
		public bool BowtieFailure;

		// Token: 0x04000DB0 RID: 3504
		[Token(Token = "0x4000DB0")]
		[FieldOffset(Offset = "0x92")]
		public bool RepeatedEdge;
	}
}

using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000318 RID: 792
	[Token(Token = "0x2000318")]
	public static class MeshValidation
	{
		// Token: 0x06001AB3 RID: 6835 RVA: 0x0001343C File Offset: 0x0001163C
		[Token(Token = "0x6001AB3")]
		[Address(RVA = "0x1F30500", Offset = "0x1F2EB00", VA = "0x181F30500")]
		public static ValidationStatus IsEdgeLoop(DMesh3 mesh, EdgeLoop loop)
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x00013454 File Offset: 0x00011654
		[Token(Token = "0x6001AB4")]
		[Address(RVA = "0x1F30610", Offset = "0x1F2EC10", VA = "0x181F30610")]
		public static ValidationStatus IsBoundaryLoop(DMesh3 mesh, EdgeLoop loop)
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0001346C File Offset: 0x0001166C
		[Token(Token = "0x6001AB5")]
		[Address(RVA = "0x1F30780", Offset = "0x1F2ED80", VA = "0x181F30780")]
		public static ValidationStatus HasDuplicateTriangles(DMesh3 mesh)
		{
			return ValidationStatus.Ok;
		}
	}
}

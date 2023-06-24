using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public class QueryDisplacements : QueryBase, ICollProvider
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000007")]
		protected override string QueryShaderName
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x9CAA00", Offset = "0x9C9000", VA = "0x1809CAA00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000008")]
		protected override string QueryKernelName
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x9CAA30", Offset = "0x9C9030", VA = "0x1809CAA30", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x9CAA60", Offset = "0x9C9060", VA = "0x1809CAA60", Slot = "7")]
		protected override void BindInputsAndOutputs(PropertyWrapperComputeStandalone wrapper, ComputeBuffer resultsBuffer)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x9CAC70", Offset = "0x9C9270", VA = "0x1809CAC70", Slot = "12")]
		public int Query(int i_ownerHash, float i_minSpatialLength, Vector3[] i_queryPoints, float[] o_resultHeights, Vector3[] o_resultNorms, Vector3[] o_resultVels)
		{
			return 0;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x9CAD30", Offset = "0x9C9330", VA = "0x1809CAD30")]
		public QueryDisplacements()
		{
		}

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xA8")]
		private readonly int sp_LD_TexArray_AnimatedWaves;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xAC")]
		private readonly int sp_ResultDisplacements;
	}
}

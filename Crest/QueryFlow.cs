using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class QueryFlow : QueryBase, IFlowProvider
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000009")]
		protected override string QueryShaderName
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x9CAE40", Offset = "0x9C9440", VA = "0x1809CAE40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700000A")]
		protected override string QueryKernelName
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x9CAE70", Offset = "0x9C9470", VA = "0x1809CAE70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x9CAEA0", Offset = "0x9C94A0", VA = "0x1809CAEA0", Slot = "7")]
		protected override void BindInputsAndOutputs(PropertyWrapperComputeStandalone wrapper, ComputeBuffer resultsBuffer)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x9CAF50", Offset = "0x9C9550", VA = "0x1809CAF50", Slot = "12")]
		public int Query(int i_ownerHash, float i_minSpatialLength, Vector3[] i_queryPoints, Vector3[] o_resultFlows)
		{
			return 0;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x9CAFD0", Offset = "0x9C95D0", VA = "0x1809CAFD0")]
		public QueryFlow()
		{
		}

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xA8")]
		private readonly int sp_LD_TexArray_Flow;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xAC")]
		private readonly int sp_ResultFlows;
	}
}

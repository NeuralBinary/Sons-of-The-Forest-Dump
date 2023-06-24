using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class SampleFlowHelper
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x9CC4D0", Offset = "0x9CAAD0", VA = "0x1809CC4D0")]
		public void Init(Vector3 i_queryPos, float i_minLength)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x9CC510", Offset = "0x9CAB10", VA = "0x1809CC510")]
		public bool Sample(out Vector2 o_flow)
		{
			return default(bool);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x9CC6E0", Offset = "0x9CACE0", VA = "0x1809CC6E0")]
		public SampleFlowHelper()
		{
		}

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x10")]
		private Vector3[] _queryPos;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x18")]
		private Vector3[] _queryResult;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x20")]
		private float _minLength;
	}
}

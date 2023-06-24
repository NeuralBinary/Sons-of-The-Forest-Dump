using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class RayTraceHelper
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x9CB0E0", Offset = "0x9C96E0", VA = "0x1809CB0E0")]
		public RayTraceHelper(float rayLength, float rayStepSize = 2f)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x9CB2E0", Offset = "0x9C98E0", VA = "0x1809CB2E0")]
		public void Init(Vector3 i_rayOrigin, Vector3 i_rayDirection)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x9CB470", Offset = "0x9C9A70", VA = "0x1809CB470")]
		public bool Trace(out float o_distance)
		{
			return default(bool);
		}

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x10")]
		private Vector3[] _queryPos;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x18")]
		private Vector3[] _queryResult;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x20")]
		private float _rayLength;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x24")]
		private float _rayStepSize;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x28")]
		private float _minLength;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x2C")]
		private bool _valid;
	}
}

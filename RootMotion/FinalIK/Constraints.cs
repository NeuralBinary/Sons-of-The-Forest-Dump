using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[Serializable]
	public class Constraints
	{
		// Token: 0x0600013D RID: 317 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x28F9160", Offset = "0x28F7760", VA = "0x1828F9160")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x28F9220", Offset = "0x28F7820", VA = "0x1828F9220")]
		public void Initiate(Transform transform)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x28F9380", Offset = "0x28F7980", VA = "0x1828F9380")]
		public void Update()
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Constraints()
		{
		}

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x10")]
		public Transform transform;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;
	}
}

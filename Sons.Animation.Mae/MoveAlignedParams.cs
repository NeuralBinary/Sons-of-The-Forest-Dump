using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class MoveAlignedParams
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public MoveAlignedParams()
		{
		}

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x10")]
		public SpeedRangeSet Speeds;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x18")]
		public float StopDistance;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x1C")]
		public bool StopIgnoreY;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 MinMaxDegrees;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 MinMaxDistance;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x38")]
		public Action CompletedCallback;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x40")]
		public Action InterruptedCallback;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[Serializable]
	public class SpeedRangeSet
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2D200F0", Offset = "0x2D1E6F0", VA = "0x182D200F0")]
		private void ReorderSet()
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2D20340", Offset = "0x2D1E940", VA = "0x182D20340")]
		public float Evaluate(float distance)
		{
			return 0f;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2D20530", Offset = "0x2D1EB30", VA = "0x182D20530")]
		public static SpeedRangeSet Convert(float speed)
		{
			return null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2D206D0", Offset = "0x2D1ECD0", VA = "0x182D206D0")]
		private void Add(SpeedRange speedRange)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2D20800", Offset = "0x2D1EE00", VA = "0x182D20800")]
		public SpeedRangeSet()
		{
		}

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _threshold;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<SpeedRange> _ranges;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x20")]
		private float _lastEvalDistance;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x24")]
		private float _lastEvalSpeed;
	}
}

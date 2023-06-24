using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[Serializable]
	internal class LookAtRange
	{
		// Token: 0x06000431 RID: 1073 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x2B10DF0", Offset = "0x2B0F3F0", VA = "0x182B10DF0")]
		public float GetLerped(float distance)
		{
			return 0f;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x1700004C")]
		public float MaxRange
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LookAtRange()
		{
		}

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _maxRange;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _minRange;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LookAtWeight _lookAtWeightMax;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LookAtWeight _lookAtWeightMin;
	}
}

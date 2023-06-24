using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[Serializable]
	public class SpeedRange
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2A89A90", Offset = "0x2A88090", VA = "0x182A89A90")]
		public SpeedRange(float distance, float speed)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x1700000D")]
		public float Speed
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x1700000E")]
		public float Distance
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _distance;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _speed;
	}
}

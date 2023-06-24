using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lighting
{
	// Token: 0x02000583 RID: 1411
	[Token(Token = "0x2000583")]
	[Serializable]
	public class DirectionColor
	{
		// Token: 0x06002532 RID: 9522 RVA: 0x0000AD10 File Offset: 0x00008F10
		[Token(Token = "0x6002532")]
		[Address(RVA = "0x74B700", Offset = "0x749D00", VA = "0x18074B700")]
		public Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002533")]
		[Address(RVA = "0x3399110", Offset = "0x3397710", VA = "0x183399110")]
		public DirectionColor(Vector3 zero, Color ambient, float f)
		{
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x0000AD28 File Offset: 0x00008F28
		[Token(Token = "0x6002534")]
		[Address(RVA = "0x29A0830", Offset = "0x299EE30", VA = "0x1829A0830")]
		public Vector3 GetDirection()
		{
			return default(Vector3);
		}

		// Token: 0x0400215E RID: 8542
		[Token(Token = "0x400215E")]
		[FieldOffset(Offset = "0x10")]
		[ColorUsage(false, true)]
		[SerializeField]
		private Color _color;

		// Token: 0x0400215F RID: 8543
		[Token(Token = "0x400215F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _direction;

		// Token: 0x04002160 RID: 8544
		[Token(Token = "0x4002160")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _intensity;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lighting
{
	// Token: 0x02000573 RID: 1395
	[Token(Token = "0x2000573")]
	[Serializable]
	public class DirectionColor
	{
		// Token: 0x06002433 RID: 9267 RVA: 0x0000A650 File Offset: 0x00008850
		[Token(Token = "0x6002433")]
		[Address(RVA = "0x68CFB0", Offset = "0x68BFB0", VA = "0x18068CFB0")]
		public Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002434")]
		[Address(RVA = "0x2D82990", Offset = "0x2D81990", VA = "0x182D82990")]
		public DirectionColor(Vector3 zero, Color ambient, float f)
		{
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x0000A668 File Offset: 0x00008868
		[Token(Token = "0x6002435")]
		[Address(RVA = "0x24E3070", Offset = "0x24E2070", VA = "0x1824E3070")]
		public Vector3 GetDirection()
		{
			return default(Vector3);
		}

		// Token: 0x0400208A RID: 8330
		[Token(Token = "0x400208A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[ColorUsage(false, true)]
		private Color _color;

		// Token: 0x0400208B RID: 8331
		[Token(Token = "0x400208B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _direction;

		// Token: 0x0400208C RID: 8332
		[Token(Token = "0x400208C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _intensity;
	}
}

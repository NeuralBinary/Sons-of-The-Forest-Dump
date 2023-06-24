using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	public struct Aabb
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x000044B4 File Offset: 0x000026B4
		[Token(Token = "0x170000F5")]
		public Vector4 center
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x27D4330", Offset = "0x27D2930", VA = "0x1827D4330")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x000044CC File Offset: 0x000026CC
		[Token(Token = "0x170000F6")]
		public Vector4 size
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x27D43F0", Offset = "0x27D29F0", VA = "0x1827D43F0")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x15C8940", Offset = "0x15C6F40", VA = "0x1815C8940")]
		public Aabb(Vector4 min, Vector4 max)
		{
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x27D4460", Offset = "0x27D2A60", VA = "0x1827D4460")]
		public Aabb(Vector4 point)
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x27D4470", Offset = "0x27D2A70", VA = "0x1827D4470")]
		public void Encapsulate(Vector4 point)
		{
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x27D4540", Offset = "0x27D2B40", VA = "0x1827D4540")]
		public void Encapsulate(Aabb other)
		{
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x27D4610", Offset = "0x27D2C10", VA = "0x1827D4610")]
		public void FromBounds(Bounds bounds, float thickness, bool is2D = false)
		{
		}

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x0")]
		public Vector4 min;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x10")]
		public Vector4 max;
	}
}

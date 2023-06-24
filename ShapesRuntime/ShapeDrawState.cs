using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	internal struct ShapeDrawState
	{
		// Token: 0x06000B75 RID: 2933 RVA: 0x000046F4 File Offset: 0x000028F4
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x2A44A40", Offset = "0x2A43040", VA = "0x182A44A40")]
		internal bool CompatibleWith(ShapeDrawState other)
		{
			return default(bool);
		}

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x0")]
		public Mesh mesh;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x8")]
		public Material mat;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x10")]
		public int submesh;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public class ContOrientedBox3
	{
		// Token: 0x0600019A RID: 410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1E28540", Offset = "0x1E26B40", VA = "0x181E28540")]
		public ContOrientedBox3(IEnumerable<Vector3d> points)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1E28620", Offset = "0x1E26C20", VA = "0x181E28620")]
		public ContOrientedBox3(IEnumerable<Vector3d> points, IEnumerable<double> pointWeights)
		{
		}

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x10")]
		public Box3d Box;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x88")]
		public bool ResultValid;
	}
}

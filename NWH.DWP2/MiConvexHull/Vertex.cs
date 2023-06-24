using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public class Vertex : IVertex
	{
		// Token: 0x06000233 RID: 563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2722240", Offset = "0x2720840", VA = "0x182722240")]
		public Vertex(double x, double y, double z)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2722330", Offset = "0x2720930", VA = "0x182722330")]
		public Vertex(Vector3 ver)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000235 RID: 565 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006E")]
		public double[] Position
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000308C File Offset: 0x0000128C
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2722410", Offset = "0x2720A10", VA = "0x182722410")]
		public Vector3 ToVec()
		{
			return default(Vector3);
		}
	}
}

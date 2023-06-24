using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	internal sealed class FaceList
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000061")]
		public ConvexFaceInternal First
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2718CD0", Offset = "0x27172D0", VA = "0x182718CD0")]
		private void AddFirst(ConvexFaceInternal face)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2718E00", Offset = "0x2717400", VA = "0x182718E00")]
		public void Add(ConvexFaceInternal face)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x27190F0", Offset = "0x27176F0", VA = "0x1827190F0")]
		public void Remove(ConvexFaceInternal face)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FaceList()
		{
		}

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x10")]
		private ConvexFaceInternal last;
	}
}

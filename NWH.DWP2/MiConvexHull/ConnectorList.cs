using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	internal sealed class ConnectorList
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000062")]
		public FaceConnector First
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x27192B0", Offset = "0x27178B0", VA = "0x1827192B0")]
		private void AddFirst(FaceConnector connector)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x27193E0", Offset = "0x27179E0", VA = "0x1827193E0")]
		public void Add(FaceConnector element)
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2719560", Offset = "0x2717B60", VA = "0x182719560")]
		public void Remove(FaceConnector connector)
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ConnectorList()
		{
		}

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x10")]
		private FaceConnector last;
	}
}

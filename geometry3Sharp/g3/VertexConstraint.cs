using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000250 RID: 592
	[Token(Token = "0x2000250")]
	public struct VertexConstraint
	{
		// Token: 0x06001502 RID: 5378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x1E8C670", Offset = "0x1E8AC70", VA = "0x181E8C670")]
		public VertexConstraint(bool isFixed, int setID = -1)
		{
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x1E8C6D0", Offset = "0x1E8ACD0", VA = "0x181E8C6D0")]
		public VertexConstraint(IProjectionTarget target)
		{
		}

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		[FieldOffset(Offset = "0x0")]
		public bool Fixed;

		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x40009CE")]
		[FieldOffset(Offset = "0x4")]
		public int FixedSetID;

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		[FieldOffset(Offset = "0x8")]
		public IProjectionTarget Target;

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		public const int InvalidSetID = -1;

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly VertexConstraint Unconstrained;

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0x10")]
		public static readonly VertexConstraint Pinned;
	}
}

using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Serializable]
	public struct GraphMask
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x1700008E")]
		public static GraphMask everything
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x634E60", Offset = "0x633460", VA = "0x180634E60")]
			get
			{
				return default(GraphMask);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public GraphMask(int value)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static implicit operator int(GraphMask mask)
		{
			return 0;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static implicit operator GraphMask(int mask)
		{
			return default(GraphMask);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x634E90", Offset = "0x633490", VA = "0x180634E90")]
		public static GraphMask operator &(GraphMask lhs, GraphMask rhs)
		{
			return default(GraphMask);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002F9C File Offset: 0x0000119C
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x634EA0", Offset = "0x6334A0", VA = "0x180634EA0")]
		public static GraphMask operator |(GraphMask lhs, GraphMask rhs)
		{
			return default(GraphMask);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002FB4 File Offset: 0x000011B4
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x634EB0", Offset = "0x6334B0", VA = "0x180634EB0")]
		public static GraphMask operator ~(GraphMask lhs)
		{
			return default(GraphMask);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x634EC0", Offset = "0x6334C0", VA = "0x180634EC0")]
		public bool Contains(int graphIndex)
		{
			return default(bool);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002FE4 File Offset: 0x000011E4
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x634ED0", Offset = "0x6334D0", VA = "0x180634ED0")]
		public static GraphMask FromGraph(NavGraph graph)
		{
			return default(GraphMask);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x634F00", Offset = "0x633500", VA = "0x180634F00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x634F10", Offset = "0x633510", VA = "0x180634F10")]
		public static GraphMask FromGraphName(string graphName)
		{
			return default(GraphMask);
		}

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x0")]
		public int value;
	}
}

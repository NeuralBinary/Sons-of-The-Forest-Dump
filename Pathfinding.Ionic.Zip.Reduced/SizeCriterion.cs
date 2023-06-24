using System;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	internal class SizeCriterion : SelectionCriterion
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SizeCriterion()
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2851BF0", Offset = "0x28501F0", VA = "0x182851BF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2851D20", Offset = "0x2850320", VA = "0x182851D20", Slot = "6")]
		internal override bool Evaluate(string filename)
		{
			return default(bool);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2851DC0", Offset = "0x28503C0", VA = "0x182851DC0")]
		private bool _Evaluate(long Length)
		{
			return default(bool);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2851EA0", Offset = "0x28504A0", VA = "0x182851EA0", Slot = "7")]
		internal override bool Evaluate(ZipEntry entry)
		{
			return default(bool);
		}

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x18")]
		internal ComparisonOperator Operator;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x20")]
		internal long Size;
	}
}

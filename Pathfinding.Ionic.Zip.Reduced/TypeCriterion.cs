using System;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	internal class TypeCriterion : SelectionCriterion
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TypeCriterion()
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		internal string AttributeString
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2852C60", Offset = "0x2851260", VA = "0x182852C60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2852CC0", Offset = "0x28512C0", VA = "0x182852CC0")]
			set
			{
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2852D50", Offset = "0x2851350", VA = "0x182852D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2852EC0", Offset = "0x28514C0", VA = "0x182852EC0", Slot = "6")]
		internal override bool Evaluate(string filename)
		{
			return default(bool);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2852F00", Offset = "0x2851500", VA = "0x182852F00", Slot = "7")]
		internal override bool Evaluate(ZipEntry entry)
		{
			return default(bool);
		}

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x18")]
		private char ObjectType;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x1C")]
		internal ComparisonOperator Operator;
	}
}

using System;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;

namespace Pathfinding.Ionic
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	internal class TimeCriterion : SelectionCriterion
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TimeCriterion()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2851ED0", Offset = "0x28504D0", VA = "0x182851ED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2852090", Offset = "0x2850690", VA = "0x182852090", Slot = "6")]
		internal override bool Evaluate(string filename)
		{
			return default(bool);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x28522C0", Offset = "0x28508C0", VA = "0x1828522C0")]
		private bool _Evaluate(DateTime x)
		{
			return default(bool);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x28524D0", Offset = "0x2850AD0", VA = "0x1828524D0", Slot = "7")]
		internal override bool Evaluate(ZipEntry entry)
		{
			return default(bool);
		}

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x18")]
		internal ComparisonOperator Operator;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x1C")]
		internal WhichTime Which;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x20")]
		internal DateTime Time;
	}
}

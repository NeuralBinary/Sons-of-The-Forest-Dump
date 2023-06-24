using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations
{
	// Token: 0x020005AC RID: 1452
	[Token(Token = "0x20005AC")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public abstract class DecorationAttribute : Attribute
	{
		// Token: 0x06002624 RID: 9764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002624")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public DecorationAttribute(int order)
		{
		}

		// Token: 0x0400224D RID: 8781
		[Token(Token = "0x400224D")]
		[FieldOffset(Offset = "0x10")]
		public readonly int order;

		// Token: 0x0400224E RID: 8782
		[Token(Token = "0x400224E")]
		[FieldOffset(Offset = "0x18")]
		public string visibleCheck;
	}
}

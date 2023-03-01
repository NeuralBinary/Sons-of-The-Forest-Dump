using System;
using Il2CppDummyDll;

namespace Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations
{
	// Token: 0x0200059C RID: 1436
	[Token(Token = "0x200059C")]
	[AttributeUsage(256, AllowMultiple = true)]
	public abstract class DecorationAttribute : Attribute
	{
		// Token: 0x06002525 RID: 9509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002525")]
		[Address(RVA = "0x6C3270", Offset = "0x6C2270", VA = "0x1806C3270")]
		public DecorationAttribute(int order)
		{
		}

		// Token: 0x04002179 RID: 8569
		[Token(Token = "0x4002179")]
		[FieldOffset(Offset = "0x10")]
		public readonly int order;

		// Token: 0x0400217A RID: 8570
		[Token(Token = "0x400217A")]
		[FieldOffset(Offset = "0x18")]
		public string visibleCheck;
	}
}

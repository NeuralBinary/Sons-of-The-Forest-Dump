using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public sealed class ValueAttribute : BaseAttribute
	{
		// Token: 0x060002CC RID: 716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x995D60", Offset = "0x994360", VA = "0x180995D60")]
		public ValueAttribute(int index)
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x17000086")]
		public int Index
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000087")]
		public string MetaName
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x995E00", Offset = "0x994400", VA = "0x180995E00")]
			set
			{
			}
		}

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x40")]
		private readonly int index;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x48")]
		private string metaName;
	}
}

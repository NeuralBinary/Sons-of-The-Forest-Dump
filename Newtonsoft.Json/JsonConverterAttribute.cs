using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
	[Nullable(0)]
	[NullableContext(1)]
	public sealed class JsonConverterAttribute : Attribute
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000015")]
		public Type ConverterType
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000016")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] ConverterParameters
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x24F1910", Offset = "0x24EFF10", VA = "0x1824F1910")]
		public JsonConverterAttribute(Type converterType)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x24F1A00", Offset = "0x24F0000", VA = "0x1824F1A00")]
		public JsonConverterAttribute(Type converterType, params object[] converterParameters)
		{
		}

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _converterType;
	}
}

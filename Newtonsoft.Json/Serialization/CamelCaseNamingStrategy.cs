using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	public class CamelCaseNamingStrategy : NamingStrategy
	{
		// Token: 0x06000735 RID: 1845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x2572010", Offset = "0x2570610", VA = "0x182572010")]
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x2572020", Offset = "0x2570620", VA = "0x182572020")]
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CamelCaseNamingStrategy()
		{
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x2572030", Offset = "0x2570630", VA = "0x182572030", Slot = "7")]
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name)
		{
			return null;
		}
	}
}

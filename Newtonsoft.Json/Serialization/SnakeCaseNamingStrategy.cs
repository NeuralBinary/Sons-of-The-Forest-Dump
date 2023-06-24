using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200013A RID: 314
	[Token(Token = "0x200013A")]
	public class SnakeCaseNamingStrategy : NamingStrategy
	{
		// Token: 0x06000997 RID: 2455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x2572010", Offset = "0x2570610", VA = "0x182572010")]
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x2572020", Offset = "0x2570620", VA = "0x182572020")]
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
		{
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SnakeCaseNamingStrategy()
		{
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x25A3A50", Offset = "0x25A2050", VA = "0x1825A3A50", Slot = "7")]
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name)
		{
			return null;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000733")]
		[NullableContext(1)]
		public static T GetAttribute(object type)
		{
			return null;
		}

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x0")]
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		private static readonly ThreadSafeStore<object, T> TypeAttributeCache;
	}
}

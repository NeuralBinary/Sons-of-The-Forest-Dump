using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	[NullableContext(1)]
	[Nullable(0)]
	internal static class DynamicUtils
	{
		// Token: 0x060005ED RID: 1517 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x255C3F0", Offset = "0x255A9F0", VA = "0x18255C3F0")]
		public static IEnumerable<string> GetDynamicMemberNames(this IDynamicMetaObjectProvider dynamicProvider)
		{
			return null;
		}

		// Token: 0x020000BD RID: 189
		[Token(Token = "0x20000BD")]
		[Nullable(0)]
		internal static class BinderWrapper
		{
			// Token: 0x060005EE RID: 1518 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x255C4B0", Offset = "0x255AAB0", VA = "0x18255C4B0")]
			private static void Init()
			{
			}

			// Token: 0x060005EF RID: 1519 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x255C750", Offset = "0x255AD50", VA = "0x18255C750")]
			private static object CreateSharpArgumentInfoArray(params int[] values)
			{
				return null;
			}

			// Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x255CE70", Offset = "0x255B470", VA = "0x18255CE70")]
			private static void CreateMemberCalls()
			{
			}

			// Token: 0x060005F1 RID: 1521 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x255D5C0", Offset = "0x255BBC0", VA = "0x18255D5C0")]
			public static CallSiteBinder GetMember(string name, Type context)
			{
				return null;
			}

			// Token: 0x060005F2 RID: 1522 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x255D860", Offset = "0x255BE60", VA = "0x18255D860")]
			public static CallSiteBinder SetMember(string name, Type context)
			{
				return null;
			}

			// Token: 0x04000430 RID: 1072
			[Token(Token = "0x4000430")]
			public const string CSharpAssemblyName = "Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x04000431 RID: 1073
			[Token(Token = "0x4000431")]
			private const string BinderTypeName = "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x04000432 RID: 1074
			[Token(Token = "0x4000432")]
			private const string CSharpArgumentInfoTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x04000433 RID: 1075
			[Token(Token = "0x4000433")]
			private const string CSharpArgumentInfoFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x04000434 RID: 1076
			[Token(Token = "0x4000434")]
			private const string CSharpBinderFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x04000435 RID: 1077
			[Token(Token = "0x4000435")]
			[FieldOffset(Offset = "0x0")]
			[Nullable(2)]
			private static object _getCSharpArgumentInfoArray;

			// Token: 0x04000436 RID: 1078
			[Token(Token = "0x4000436")]
			[FieldOffset(Offset = "0x8")]
			[Nullable(2)]
			private static object _setCSharpArgumentInfoArray;

			// Token: 0x04000437 RID: 1079
			[Token(Token = "0x4000437")]
			[FieldOffset(Offset = "0x10")]
			[Nullable(2)]
			private static MethodCall<object, object> _getMemberCall;

			// Token: 0x04000438 RID: 1080
			[Token(Token = "0x4000438")]
			[FieldOffset(Offset = "0x18")]
			[Nullable(2)]
			private static MethodCall<object, object> _setMemberCall;

			// Token: 0x04000439 RID: 1081
			[Token(Token = "0x4000439")]
			[FieldOffset(Offset = "0x20")]
			private static bool _init;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	[NullableContext(1)]
	[Nullable(0)]
	internal static class ImmutableCollectionsUtils
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x2561B50", Offset = "0x2560150", VA = "0x182561B50")]
		internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out Type createdType, [Nullable(new byte[]
		{
			2,
			1
		})] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out ObjectConstructor<object> parameterizedCreator)
		{
			return default(bool);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x2562100", Offset = "0x2560700", VA = "0x182562100")]
		internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out Type createdType, [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] [Nullable(new byte[]
		{
			2,
			1
		})] out ObjectConstructor<object> parameterizedCreator)
		{
			return default(bool);
		}

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		private const string ImmutableListGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableList`1";

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		private const string ImmutableQueueGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableQueue`1";

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		private const string ImmutableStackGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableStack`1";

		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		private const string ImmutableSetGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableSet`1";

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		private const string ImmutableArrayTypeName = "System.Collections.Immutable.ImmutableArray";

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		private const string ImmutableArrayGenericTypeName = "System.Collections.Immutable.ImmutableArray`1";

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		private const string ImmutableListTypeName = "System.Collections.Immutable.ImmutableList";

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		private const string ImmutableListGenericTypeName = "System.Collections.Immutable.ImmutableList`1";

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		private const string ImmutableQueueTypeName = "System.Collections.Immutable.ImmutableQueue";

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		private const string ImmutableQueueGenericTypeName = "System.Collections.Immutable.ImmutableQueue`1";

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		private const string ImmutableStackTypeName = "System.Collections.Immutable.ImmutableStack";

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		private const string ImmutableStackGenericTypeName = "System.Collections.Immutable.ImmutableStack`1";

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		private const string ImmutableSortedSetTypeName = "System.Collections.Immutable.ImmutableSortedSet";

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		private const string ImmutableSortedSetGenericTypeName = "System.Collections.Immutable.ImmutableSortedSet`1";

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		private const string ImmutableHashSetTypeName = "System.Collections.Immutable.ImmutableHashSet";

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		private const string ImmutableHashSetGenericTypeName = "System.Collections.Immutable.ImmutableHashSet`1";

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		private const string ImmutableDictionaryGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableDictionary`2";

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		private const string ImmutableDictionaryTypeName = "System.Collections.Immutable.ImmutableDictionary";

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		private const string ImmutableDictionaryGenericTypeName = "System.Collections.Immutable.ImmutableDictionary`2";

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		private const string ImmutableSortedDictionaryTypeName = "System.Collections.Immutable.ImmutableSortedDictionary";

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		private const string ImmutableSortedDictionaryGenericTypeName = "System.Collections.Immutable.ImmutableSortedDictionary`2";

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions;

		// Token: 0x020000CB RID: 203
		[Token(Token = "0x20000CB")]
		[Nullable(0)]
		internal class ImmutableCollectionTypeInfo
		{
			// Token: 0x06000635 RID: 1589 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x612090", Offset = "0x610690", VA = "0x180612090")]
			public ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName)
			{
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x06000636 RID: 1590 RVA: 0x00002082 File Offset: 0x00000282
			// (set) Token: 0x06000637 RID: 1591 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000D4")]
			public string ContractTypeName
			{
				[Token(Token = "0x6000636")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000637")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x06000638 RID: 1592 RVA: 0x00002082 File Offset: 0x00000282
			// (set) Token: 0x06000639 RID: 1593 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000D5")]
			public string CreatedTypeName
			{
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000639")]
				[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x0600063A RID: 1594 RVA: 0x00002082 File Offset: 0x00000282
			// (set) Token: 0x0600063B RID: 1595 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000D6")]
			public string BuilderTypeName
			{
				[Token(Token = "0x600063A")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600063B")]
				[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
				[CompilerGenerated]
				set
				{
				}
			}
		}
	}
}

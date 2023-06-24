using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[Nullable(0)]
	[NullableContext(1)]
	internal static class CollectionUtils
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x6000505")]
		public static bool IsNullOrEmpty<T>(ICollection<T> collection)
		{
			return default(bool);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000506")]
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection)
		{
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2550AC0", Offset = "0x254F0C0", VA = "0x182550AC0")]
		public static bool IsDictionaryType(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2550CE0", Offset = "0x254F2E0", VA = "0x182550CE0")]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			return null;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2550E40", Offset = "0x254F440", VA = "0x182550E40")]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
		{
			return null;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x600050A")]
		public static bool AddDistinct<T>(this IList<T> list, T value)
		{
			return default(bool);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x600050B")]
		public static bool AddDistinct<T>(this IList<T> list, T value, IEqualityComparer<T> comparer)
		{
			return default(bool);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x600050C")]
		public static bool ContainsValue<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			return default(bool);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x600050D")]
		public static bool AddRangeDistinct<T>(this IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
		{
			return default(bool);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x600050E")]
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			return 0;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x600050F")]
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x6000510")]
		public static int IndexOfReference<T>(this List<T> list, T item)
		{
			return 0;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000511")]
		public static void FastReverse<T>(this List<T> list)
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2551100", Offset = "0x254F700", VA = "0x182551100")]
		private static IList<int> GetDimensions(IList values, int dimensionsCount)
		{
			return null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x25514F0", Offset = "0x254FAF0", VA = "0x1825514F0")]
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices)
		{
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x2551780", Offset = "0x254FD80", VA = "0x182551780")]
		private static object JaggedArrayGetValue(IList values, int[] indices)
		{
			return null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x2551880", Offset = "0x254FE80", VA = "0x182551880")]
		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			return null;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000516")]
		public static T[] ArrayEmpty<T>()
		{
			return null;
		}

		// Token: 0x0200009B RID: 155
		[Token(Token = "0x200009B")]
		[NullableContext(0)]
		private static class EmptyArrayContainer<T>
		{
			// Token: 0x0400039D RID: 925
			[Token(Token = "0x400039D")]
			[FieldOffset(Offset = "0x0")]
			[Nullable(1)]
			public static readonly T[] Empty;
		}
	}
}

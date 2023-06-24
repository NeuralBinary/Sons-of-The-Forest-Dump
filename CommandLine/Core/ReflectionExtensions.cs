using System;
using System.Collections.Generic;
using System.Reflection;
using CommandLine.Text;
using CSharpx;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	internal static class ReflectionExtensions
	{
		// Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CE")]
		public static IEnumerable<T> GetSpecifications<T>(this Type type, Func<PropertyInfo, T> selector)
		{
			return null;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x9AC430", Offset = "0x9AAA30", VA = "0x1809AC430")]
		public static Maybe<VerbAttribute> GetVerbSpecification(this Type type)
		{
			return null;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x9AC8A0", Offset = "0x9AAEA0", VA = "0x1809AC8A0")]
		public static Maybe<Tuple<PropertyInfo, UsageAttribute>> GetUsageData(this Type type)
		{
			return null;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x9ACE30", Offset = "0x9AB430", VA = "0x1809ACE30")]
		private static IEnumerable<Type> FlattenHierarchy(this Type type)
		{
			return null;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x9ACED0", Offset = "0x9AB4D0", VA = "0x1809ACED0")]
		private static IEnumerable<Type> SafeGetInterfaces(this Type type)
		{
			return null;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x9ACF60", Offset = "0x9AB560", VA = "0x1809ACF60")]
		public static TargetType ToTargetType(this Type type)
		{
			return TargetType.Switch;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D4")]
		public static IEnumerable<Error> SetProperties<T>(this T instance, IEnumerable<SpecificationProperty> specProps, Func<SpecificationProperty, bool> predicate, Func<SpecificationProperty, object> selector)
		{
			return null;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D5")]
		private static IEnumerable<Error> SetValue<T>(this SpecificationProperty specProp, T instance, object value)
		{
			return null;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x9AD0F0", Offset = "0x9AB6F0", VA = "0x1809AD0F0")]
		public static object CreateEmptyArray(this Type type)
		{
			return null;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x9AD100", Offset = "0x9AB700", VA = "0x1809AD100")]
		public static object GetDefaultValue(this Type type)
		{
			return null;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x9AD150", Offset = "0x9AB750", VA = "0x1809AD150")]
		public static bool IsMutable(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x9AD5E0", Offset = "0x9ABBE0", VA = "0x1809AD5E0")]
		public static object CreateDefaultForImmutable(this Type type)
		{
			return null;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x9AD740", Offset = "0x9ABD40", VA = "0x1809AD740")]
		public static object AutoDefault(this Type type)
		{
			return null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x9AD950", Offset = "0x9ABF50", VA = "0x1809AD950")]
		public static TypeInfo ToTypeInfo(this Type type)
		{
			return null;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x9AD960", Offset = "0x9ABF60", VA = "0x1809AD960")]
		public static object StaticMethod(this Type type, string name, params object[] args)
		{
			return null;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x9AD9D0", Offset = "0x9ABFD0", VA = "0x1809AD9D0")]
		public static object StaticProperty(this Type type, string name)
		{
			return null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x9ADA70", Offset = "0x9AC070", VA = "0x1809ADA70")]
		public static object InstanceProperty(this Type type, string name, object target)
		{
			return null;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x9ADB20", Offset = "0x9AC120", VA = "0x1809ADB20")]
		public static bool IsPrimitiveEx(this Type type)
		{
			return default(bool);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x9ADEB0", Offset = "0x9AC4B0", VA = "0x1809ADEB0")]
		public static bool IsCustomStruct(this Type type)
		{
			return default(bool);
		}
	}
}

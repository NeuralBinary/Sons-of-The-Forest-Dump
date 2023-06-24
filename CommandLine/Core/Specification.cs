using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpx;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	internal abstract class Specification
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x9AF010", Offset = "0x9AD610", VA = "0x1809AF010")]
		protected Specification(SpecificationType tag, bool required, Maybe<int> min, Maybe<int> max, Maybe<object> defaultValue, string helpText, string metaValue, IEnumerable<string> enumValues, Type conversionType, TargetType targetType, bool hidden = false)
		{
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x170000CD")]
		public SpecificationType Tag
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return SpecificationType.Option;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x170000CE")]
		public bool Required
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CF")]
		public Maybe<int> Min
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D0")]
		public Maybe<int> Max
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D1")]
		public Maybe<object> DefaultValue
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D2")]
		public string HelpText
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D3")]
		public string MetaValue
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D4")]
		public IEnumerable<string> EnumValues
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D5")]
		public Type ConversionType
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x170000D6")]
		public TargetType TargetType
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x9AF280", Offset = "0x9AD880", VA = "0x1809AF280")]
			get
			{
				return TargetType.Switch;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x170000D7")]
		public bool Hidden
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x9944D0", Offset = "0x992AD0", VA = "0x1809944D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x9AF290", Offset = "0x9AD890", VA = "0x1809AF290")]
		public static Specification FromProperty(PropertyInfo property)
		{
			return null;
		}

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x10")]
		private readonly SpecificationType tag;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x14")]
		private readonly bool required;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x15")]
		private readonly bool hidden;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x18")]
		private readonly Maybe<int> min;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x20")]
		private readonly Maybe<int> max;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x28")]
		private readonly Maybe<object> defaultValue;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x30")]
		private readonly string helpText;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x38")]
		private readonly string metaValue;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x40")]
		private readonly IEnumerable<string> enumValues;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x48")]
		private readonly Type conversionType;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x50")]
		private readonly TargetType targetType;
	}
}

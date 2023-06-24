using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000180 RID: 384
	[Token(Token = "0x2000180")]
	[Nullable(0)]
	[NullableContext(1)]
	public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
	{
		// Token: 0x06000CA7 RID: 3239 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x25CB180", Offset = "0x25C9780", VA = "0x1825CB180", Slot = "12")]
		public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x25CB1C0", Offset = "0x25C97C0", VA = "0x1825CB1C0")]
		public Task WriteToAsync(JsonWriter writer, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x25CB1F0", Offset = "0x25C97F0", VA = "0x1825CB1F0")]
		public static Task<JToken> ReadFromAsync(JsonReader reader, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x25CB250", Offset = "0x25C9850", VA = "0x1825CB250")]
		public static Task<JToken> ReadFromAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x25CB490", Offset = "0x25C9A90", VA = "0x1825CB490")]
		public static Task<JToken> LoadAsync(JsonReader reader, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x25CB520", Offset = "0x25C9B20", VA = "0x1825CB520")]
		public static Task<JToken> LoadAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000212")]
		public static JTokenEqualityComparer EqualityComparer
		{
			[Token(Token = "0x6000CAD")]
			[Address(RVA = "0x25CB590", Offset = "0x25C9B90", VA = "0x1825CB590")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000213")]
		[Nullable(2)]
		public JContainer Parent
		{
			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[NullableContext(2)]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[NullableContext(2)]
			internal set
			{
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000214")]
		public JToken Root
		{
			[Token(Token = "0x6000CB0")]
			[Address(RVA = "0x25CB6C0", Offset = "0x25C9CC0", VA = "0x1825CB6C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CB1 RID: 3249
		[Token(Token = "0x6000CB1")]
		internal abstract JToken CloneToken([Nullable(2)] JsonCloneSettings settings);

		// Token: 0x06000CB2 RID: 3250
		[Token(Token = "0x6000CB2")]
		internal abstract bool DeepEquals(JToken node);

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000CB3 RID: 3251
		[Token(Token = "0x17000215")]
		public abstract JTokenType Type { [Token(Token = "0x6000CB3")] get; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000CB4 RID: 3252
		[Token(Token = "0x17000216")]
		public abstract bool HasValues { [Token(Token = "0x6000CB4")] get; }

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x25CB6F0", Offset = "0x25C9CF0", VA = "0x1825CB6F0")]
		[NullableContext(2)]
		public static bool DeepEquals(JToken t1, JToken t2)
		{
			return default(bool);
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000217")]
		[Nullable(2)]
		public JToken Next
		{
			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[NullableContext(2)]
			internal set
			{
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000218")]
		[Nullable(2)]
		public JToken Previous
		{
			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CB9")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[NullableContext(2)]
			internal set
			{
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000219")]
		public string Path
		{
			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x25CB720", Offset = "0x25C9D20", VA = "0x1825CB720")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		internal JToken()
		{
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x25CBB60", Offset = "0x25CA160", VA = "0x1825CBB60")]
		[NullableContext(2)]
		public void AddAfterSelf(object content)
		{
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x25CBC10", Offset = "0x25CA210", VA = "0x1825CBC10")]
		[NullableContext(2)]
		public void AddBeforeSelf(object content)
		{
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x25CBCC0", Offset = "0x25CA2C0", VA = "0x1825CBCC0")]
		public IEnumerable<JToken> Ancestors()
		{
			return null;
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x25CBCD0", Offset = "0x25CA2D0", VA = "0x1825CBCD0")]
		public IEnumerable<JToken> AncestorsAndSelf()
		{
			return null;
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x25CBCE0", Offset = "0x25CA2E0", VA = "0x1825CBCE0")]
		internal IEnumerable<JToken> GetAncestors(bool self)
		{
			return null;
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x25CBDA0", Offset = "0x25CA3A0", VA = "0x1825CBDA0")]
		public IEnumerable<JToken> AfterSelf()
		{
			return null;
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x25CBE40", Offset = "0x25CA440", VA = "0x1825CBE40")]
		public IEnumerable<JToken> BeforeSelf()
		{
			return null;
		}

		// Token: 0x1700021A RID: 538
		[Token(Token = "0x1700021A")]
		[Nullable(2)]
		public virtual JToken this[object key]
		{
			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0x25CBEE0", Offset = "0x25CA4E0", VA = "0x1825CBEE0", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CC4")]
			[Address(RVA = "0x25CBF80", Offset = "0x25CA580", VA = "0x1825CBF80", Slot = "18")]
			[param: Nullable(2)]
			set
			{
			}
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CC5")]
		[NullableContext(2)]
		public virtual T Value<T>([Nullable(1)] object key)
		{
			return null;
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700021B")]
		[Nullable(2)]
		public virtual JToken First
		{
			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x25CC020", Offset = "0x25CA620", VA = "0x1825CC020", Slot = "20")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700021C")]
		[Nullable(2)]
		public virtual JToken Last
		{
			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x25CC0C0", Offset = "0x25CA6C0", VA = "0x1825CC0C0", Slot = "21")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x25CC160", Offset = "0x25CA760", VA = "0x1825CC160", Slot = "22")]
		public virtual JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x000061B0 File Offset: 0x000043B0
		[Token(Token = "0x6000CC9")]
		[NullableContext(0)]
		public JEnumerable<T> Children<T>() where T : JToken
		{
			return default(JEnumerable<T>);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CCA")]
		[NullableContext(2)]
		public virtual IEnumerable<T> Values<T>()
		{
			return null;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x25CC1B0", Offset = "0x25CA7B0", VA = "0x1825CC1B0")]
		public void Remove()
		{
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x25CC230", Offset = "0x25CA830", VA = "0x1825CC230")]
		public void Replace(JToken value)
		{
		}

		// Token: 0x06000CCD RID: 3277
		[Token(Token = "0x6000CCD")]
		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

		// Token: 0x06000CCE RID: 3278 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x25CC2B0", Offset = "0x25CA8B0", VA = "0x1825CC2B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x25CC300", Offset = "0x25CA900", VA = "0x1825CC300")]
		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x25CC530", Offset = "0x25CAB30", VA = "0x1825CC530")]
		private static JValue EnsureValue(JToken value)
		{
			return null;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x25CC650", Offset = "0x25CAC50", VA = "0x1825CC650")]
		private static string GetType(JToken token)
		{
			return null;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000061C8 File Offset: 0x000043C8
		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x25CC770", Offset = "0x25CAD70", VA = "0x1825CC770")]
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable)
		{
			return default(bool);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x25CC8C0", Offset = "0x25CAEC0", VA = "0x1825CC8C0")]
		public static explicit operator bool(JToken value)
		{
			return default(bool);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x25CCBB0", Offset = "0x25CB1B0", VA = "0x1825CCBB0")]
		public static explicit operator DateTimeOffset(JToken value)
		{
			return default(DateTimeOffset);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x6000CD5")]
		[Address(RVA = "0x25CD110", Offset = "0x25CB710", VA = "0x1825CD110")]
		[NullableContext(2)]
		public static explicit operator bool?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x25CD390", Offset = "0x25CB990", VA = "0x1825CD390")]
		public static explicit operator long(JToken value)
		{
			return 0L;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00006240 File Offset: 0x00004440
		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x25CD660", Offset = "0x25CBC60", VA = "0x1825CD660")]
		[NullableContext(2)]
		public static explicit operator DateTime?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00006258 File Offset: 0x00004458
		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x25CD8B0", Offset = "0x25CBEB0", VA = "0x1825CD8B0")]
		[NullableContext(2)]
		public static explicit operator DateTimeOffset?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00006270 File Offset: 0x00004470
		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0x25CDDD0", Offset = "0x25CC3D0", VA = "0x1825CDDD0")]
		[NullableContext(2)]
		public static explicit operator decimal?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00006288 File Offset: 0x00004488
		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x25CE080", Offset = "0x25CC680", VA = "0x1825CE080")]
		[NullableContext(2)]
		public static explicit operator double?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x000062A0 File Offset: 0x000044A0
		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x25CE310", Offset = "0x25CC910", VA = "0x1825CE310")]
		[NullableContext(2)]
		public static explicit operator char?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x000062B8 File Offset: 0x000044B8
		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x25CE590", Offset = "0x25CCB90", VA = "0x1825CE590")]
		public static explicit operator int(JToken value)
		{
			return 0;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x000062D0 File Offset: 0x000044D0
		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x25CE860", Offset = "0x25CCE60", VA = "0x1825CE860")]
		public static explicit operator short(JToken value)
		{
			return 0;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x000062E8 File Offset: 0x000044E8
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x25CEBA0", Offset = "0x25CD1A0", VA = "0x1825CEBA0")]
		[CLSCompliant(false)]
		public static explicit operator ushort(JToken value)
		{
			return 0;
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00006300 File Offset: 0x00004500
		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x25CEEE0", Offset = "0x25CD4E0", VA = "0x1825CEEE0")]
		[CLSCompliant(false)]
		public static explicit operator char(JToken value)
		{
			return '\0';
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00006318 File Offset: 0x00004518
		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x25CF220", Offset = "0x25CD820", VA = "0x1825CF220")]
		public static explicit operator byte(JToken value)
		{
			return 0;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00006330 File Offset: 0x00004530
		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x25CF560", Offset = "0x25CDB60", VA = "0x1825CF560")]
		[CLSCompliant(false)]
		public static explicit operator sbyte(JToken value)
		{
			return 0;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00006348 File Offset: 0x00004548
		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x25CF8A0", Offset = "0x25CDEA0", VA = "0x1825CF8A0")]
		[NullableContext(2)]
		public static explicit operator int?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00006360 File Offset: 0x00004560
		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x25CFB20", Offset = "0x25CE120", VA = "0x1825CFB20")]
		[NullableContext(2)]
		public static explicit operator short?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00006378 File Offset: 0x00004578
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x25CFDA0", Offset = "0x25CE3A0", VA = "0x1825CFDA0")]
		[CLSCompliant(false)]
		[NullableContext(2)]
		public static explicit operator ushort?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00006390 File Offset: 0x00004590
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x25D0020", Offset = "0x25CE620", VA = "0x1825D0020")]
		[NullableContext(2)]
		public static explicit operator byte?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000063A8 File Offset: 0x000045A8
		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x25D0290", Offset = "0x25CE890", VA = "0x1825D0290")]
		[CLSCompliant(false)]
		[NullableContext(2)]
		public static explicit operator sbyte?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000063C0 File Offset: 0x000045C0
		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x25D0500", Offset = "0x25CEB00", VA = "0x1825D0500")]
		public static explicit operator DateTime(JToken value)
		{
			return default(DateTime);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000063D8 File Offset: 0x000045D8
		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0x25D07B0", Offset = "0x25CEDB0", VA = "0x1825D07B0")]
		[NullableContext(2)]
		public static explicit operator long?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x000063F0 File Offset: 0x000045F0
		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0x25D0A20", Offset = "0x25CF020", VA = "0x1825D0A20")]
		[NullableContext(2)]
		public static explicit operator float?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00006408 File Offset: 0x00004608
		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x25D0CE0", Offset = "0x25CF2E0", VA = "0x1825D0CE0")]
		public static explicit operator decimal(JToken value)
		{
			return 0m;
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00006420 File Offset: 0x00004620
		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x25D0FE0", Offset = "0x25CF5E0", VA = "0x1825D0FE0")]
		[CLSCompliant(false)]
		[NullableContext(2)]
		public static explicit operator uint?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00006438 File Offset: 0x00004638
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x25D1260", Offset = "0x25CF860", VA = "0x1825D1260")]
		[CLSCompliant(false)]
		[NullableContext(2)]
		public static explicit operator ulong?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00006450 File Offset: 0x00004650
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x25D14D0", Offset = "0x25CFAD0", VA = "0x1825D14D0")]
		public static explicit operator double(JToken value)
		{
			return 0.0;
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00006468 File Offset: 0x00004668
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x25D17A0", Offset = "0x25CFDA0", VA = "0x1825D17A0")]
		public static explicit operator float(JToken value)
		{
			return 0f;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x25D1AC0", Offset = "0x25D00C0", VA = "0x1825D1AC0")]
		[NullableContext(2)]
		public static explicit operator string(JToken value)
		{
			return null;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00006480 File Offset: 0x00004680
		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x25D1D60", Offset = "0x25D0360", VA = "0x1825D1D60")]
		[CLSCompliant(false)]
		public static explicit operator uint(JToken value)
		{
			return 0U;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00006498 File Offset: 0x00004698
		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0x25D2030", Offset = "0x25D0630", VA = "0x1825D2030")]
		[CLSCompliant(false)]
		public static explicit operator ulong(JToken value)
		{
			return 0UL;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x25D2300", Offset = "0x25D0900", VA = "0x1825D2300")]
		[NullableContext(2)]
		public static explicit operator byte[](JToken value)
		{
			return null;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x000064B0 File Offset: 0x000046B0
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x25D2790", Offset = "0x25D0D90", VA = "0x1825D2790")]
		public static explicit operator Guid(JToken value)
		{
			return default(Guid);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x000064C8 File Offset: 0x000046C8
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x25D2AE0", Offset = "0x25D10E0", VA = "0x1825D2AE0")]
		[NullableContext(2)]
		public static explicit operator Guid?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x000064E0 File Offset: 0x000046E0
		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x25D2E00", Offset = "0x25D1400", VA = "0x1825D2E00")]
		public static explicit operator TimeSpan(JToken value)
		{
			return default(TimeSpan);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x000064F8 File Offset: 0x000046F8
		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0x25D30D0", Offset = "0x25D16D0", VA = "0x1825D30D0")]
		[NullableContext(2)]
		public static explicit operator TimeSpan?(JToken value)
		{
			return null;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0x25D3320", Offset = "0x25D1920", VA = "0x1825D3320")]
		[NullableContext(2)]
		public static explicit operator Uri(JToken value)
		{
			return null;
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00006510 File Offset: 0x00004710
		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0x25D3540", Offset = "0x25D1B40", VA = "0x1825D3540")]
		private static BigInteger ToBigInteger(JToken value)
		{
			return default(BigInteger);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x25D3780", Offset = "0x25D1D80", VA = "0x1825D3780")]
		private static BigInteger? ToBigIntegerNullable(JToken value)
		{
			return null;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x25D3AA0", Offset = "0x25D20A0", VA = "0x1825D3AA0")]
		public static implicit operator JToken(bool value)
		{
			return null;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x25D3B00", Offset = "0x25D2100", VA = "0x1825D3B00")]
		public static implicit operator JToken(DateTimeOffset value)
		{
			return null;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x25D3B90", Offset = "0x25D2190", VA = "0x1825D3B90")]
		public static implicit operator JToken(byte value)
		{
			return null;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0x25D3BF0", Offset = "0x25D21F0", VA = "0x1825D3BF0")]
		public static implicit operator JToken(byte? value)
		{
			return null;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x25D3C80", Offset = "0x25D2280", VA = "0x1825D3C80")]
		[CLSCompliant(false)]
		public static implicit operator JToken(sbyte value)
		{
			return null;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x25D3CE0", Offset = "0x25D22E0", VA = "0x1825D3CE0")]
		[CLSCompliant(false)]
		public static implicit operator JToken(sbyte? value)
		{
			return null;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x25D3D70", Offset = "0x25D2370", VA = "0x1825D3D70")]
		public static implicit operator JToken(bool? value)
		{
			return null;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x25D3E00", Offset = "0x25D2400", VA = "0x1825D3E00")]
		public static implicit operator JToken(long value)
		{
			return null;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x25D3E60", Offset = "0x25D2460", VA = "0x1825D3E60")]
		public static implicit operator JToken(DateTime? value)
		{
			return null;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x25D3EF0", Offset = "0x25D24F0", VA = "0x1825D3EF0")]
		public static implicit operator JToken(DateTimeOffset? value)
		{
			return null;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x25D3F90", Offset = "0x25D2590", VA = "0x1825D3F90")]
		public static implicit operator JToken(decimal? value)
		{
			return null;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x25D4030", Offset = "0x25D2630", VA = "0x1825D4030")]
		public static implicit operator JToken(double? value)
		{
			return null;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x25D40C0", Offset = "0x25D26C0", VA = "0x1825D40C0")]
		[CLSCompliant(false)]
		public static implicit operator JToken(short value)
		{
			return null;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x25D4120", Offset = "0x25D2720", VA = "0x1825D4120")]
		[CLSCompliant(false)]
		public static implicit operator JToken(ushort value)
		{
			return null;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x25D4180", Offset = "0x25D2780", VA = "0x1825D4180")]
		public static implicit operator JToken(int value)
		{
			return null;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x25D41E0", Offset = "0x25D27E0", VA = "0x1825D41E0")]
		public static implicit operator JToken(int? value)
		{
			return null;
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x25D4270", Offset = "0x25D2870", VA = "0x1825D4270")]
		public static implicit operator JToken(DateTime value)
		{
			return null;
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x25D4300", Offset = "0x25D2900", VA = "0x1825D4300")]
		public static implicit operator JToken(long? value)
		{
			return null;
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x25D4390", Offset = "0x25D2990", VA = "0x1825D4390")]
		public static implicit operator JToken(float? value)
		{
			return null;
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x25D4420", Offset = "0x25D2A20", VA = "0x1825D4420")]
		public static implicit operator JToken(decimal value)
		{
			return null;
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x25D44C0", Offset = "0x25D2AC0", VA = "0x1825D44C0")]
		[CLSCompliant(false)]
		public static implicit operator JToken(short? value)
		{
			return null;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0x25D4550", Offset = "0x25D2B50", VA = "0x1825D4550")]
		[CLSCompliant(false)]
		public static implicit operator JToken(ushort? value)
		{
			return null;
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D10")]
		[Address(RVA = "0x25D45E0", Offset = "0x25D2BE0", VA = "0x1825D45E0")]
		[CLSCompliant(false)]
		public static implicit operator JToken(uint? value)
		{
			return null;
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D11")]
		[Address(RVA = "0x25D4670", Offset = "0x25D2C70", VA = "0x1825D4670")]
		[CLSCompliant(false)]
		public static implicit operator JToken(ulong? value)
		{
			return null;
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x25D4700", Offset = "0x25D2D00", VA = "0x1825D4700")]
		public static implicit operator JToken(double value)
		{
			return null;
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D13")]
		[Address(RVA = "0x25D4760", Offset = "0x25D2D60", VA = "0x1825D4760")]
		public static implicit operator JToken(float value)
		{
			return null;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x25D47F0", Offset = "0x25D2DF0", VA = "0x1825D47F0")]
		public static implicit operator JToken([Nullable(2)] string value)
		{
			return null;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x25D4850", Offset = "0x25D2E50", VA = "0x1825D4850")]
		[CLSCompliant(false)]
		public static implicit operator JToken(uint value)
		{
			return null;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x25D48B0", Offset = "0x25D2EB0", VA = "0x1825D48B0")]
		[CLSCompliant(false)]
		public static implicit operator JToken(ulong value)
		{
			return null;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x25D4940", Offset = "0x25D2F40", VA = "0x1825D4940")]
		public static implicit operator JToken(byte[] value)
		{
			return null;
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x25D49B0", Offset = "0x25D2FB0", VA = "0x1825D49B0")]
		public static implicit operator JToken([Nullable(2)] Uri value)
		{
			return null;
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D19")]
		[Address(RVA = "0x25D4A10", Offset = "0x25D3010", VA = "0x1825D4A10")]
		public static implicit operator JToken(TimeSpan value)
		{
			return null;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x25D4AA0", Offset = "0x25D30A0", VA = "0x1825D4AA0")]
		public static implicit operator JToken(TimeSpan? value)
		{
			return null;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x25D4B30", Offset = "0x25D3130", VA = "0x1825D4B30")]
		public static implicit operator JToken(Guid value)
		{
			return null;
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x25D4BC0", Offset = "0x25D31C0", VA = "0x1825D4BC0")]
		public static implicit operator JToken(Guid? value)
		{
			return null;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x25D4C60", Offset = "0x25D3260", VA = "0x1825D4C60", Slot = "6")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x25D4CA0", Offset = "0x25D32A0", VA = "0x1825D4CA0", Slot = "5")]
		private IEnumerator<JToken> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000D1F RID: 3359
		[Token(Token = "0x6000D1F")]
		internal abstract int GetDeepHashCode();

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700021D")]
		private IJEnumerable<JToken> Item
		{
			[Token(Token = "0x6000D20")]
			[Address(RVA = "0x25D4D00", Offset = "0x25D3300", VA = "0x1825D4D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x25D4D20", Offset = "0x25D3320", VA = "0x1825D4D20")]
		public JsonReader CreateReader()
		{
			return null;
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x25D4D80", Offset = "0x25D3380", VA = "0x1825D4D80")]
		internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x25D4F90", Offset = "0x25D3590", VA = "0x1825D4F90")]
		public static JToken FromObject(object o)
		{
			return null;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x25D4FF0", Offset = "0x25D35F0", VA = "0x1825D4FF0")]
		public static JToken FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D25")]
		[NullableContext(2)]
		public T ToObject<T>()
		{
			return null;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x25D5050", Offset = "0x25D3650", VA = "0x1825D5050")]
		public object ToObject(Type objectType)
		{
			return null;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D27")]
		[NullableContext(2)]
		public T ToObject<T>([Nullable(1)] JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x25D6160", Offset = "0x25D4760", VA = "0x1825D6160")]
		[NullableContext(2)]
		public object ToObject(Type objectType, [Nullable(1)] JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x25D63A0", Offset = "0x25D49A0", VA = "0x1825D63A0")]
		public static JToken ReadFrom(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x25D63F0", Offset = "0x25D49F0", VA = "0x1825D63F0")]
		public static JToken ReadFrom(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x25D67A0", Offset = "0x25D4DA0", VA = "0x1825D67A0")]
		public static JToken Parse(string json)
		{
			return null;
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x25D67F0", Offset = "0x25D4DF0", VA = "0x1825D67F0")]
		public static JToken Parse(string json, [Nullable(2)] JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x25D6990", Offset = "0x25D4F90", VA = "0x1825D6990")]
		public static JToken Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x25D69F0", Offset = "0x25D4FF0", VA = "0x1825D69F0")]
		public static JToken Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x25D6A70", Offset = "0x25D5070", VA = "0x1825D6A70")]
		[NullableContext(2)]
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings)
		{
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x25D6B50", Offset = "0x25D5150", VA = "0x1825D6B50")]
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00006540 File Offset: 0x00004740
		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x25D6BC0", Offset = "0x25D51C0", VA = "0x1825D6BC0", Slot = "7")]
		private bool HasLineInfo()
		{
			return default(bool);
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00006558 File Offset: 0x00004758
		[Token(Token = "0x1700021E")]
		private int LineNumber
		{
			[Token(Token = "0x6000D32")]
			[Address(RVA = "0x25D6C00", Offset = "0x25D5200", VA = "0x1825D6C00", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00006570 File Offset: 0x00004770
		[Token(Token = "0x1700021F")]
		private int LinePosition
		{
			[Token(Token = "0x6000D33")]
			[Address(RVA = "0x25D6C50", Offset = "0x25D5250", VA = "0x1825D6C50", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x25D6CA0", Offset = "0x25D52A0", VA = "0x1825D6CA0")]
		public JToken SelectToken(string path)
		{
			return null;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x25D6CB0", Offset = "0x25D52B0", VA = "0x1825D6CB0")]
		public JToken SelectToken(string path, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D36")]
		[Address(RVA = "0x25D6D30", Offset = "0x25D5330", VA = "0x1825D6D30")]
		[NullableContext(2)]
		public JToken SelectToken([Nullable(1)] string path, JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x25D6F10", Offset = "0x25D5510", VA = "0x1825D6F10")]
		public IEnumerable<JToken> SelectTokens(string path)
		{
			return null;
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x25D6F20", Offset = "0x25D5520", VA = "0x1825D6F20")]
		public IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x25D6FA0", Offset = "0x25D55A0", VA = "0x1825D6FA0")]
		public IEnumerable<JToken> SelectTokens(string path, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0x25D7030", Offset = "0x25D5630", VA = "0x1825D7030", Slot = "26")]
		protected virtual DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0x25D70E0", Offset = "0x25D56E0", VA = "0x1825D70E0", Slot = "11")]
		private DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x7AA7D0", Offset = "0x7A8DD0", VA = "0x1807AA7D0", Slot = "10")]
		private object Clone()
		{
			return null;
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x7AA7D0", Offset = "0x7A8DD0", VA = "0x1807AA7D0")]
		public JToken DeepClone()
		{
			return null;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x25D7100", Offset = "0x25D5700", VA = "0x1825D7100")]
		public JToken DeepClone(JsonCloneSettings settings)
		{
			return null;
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x25D7120", Offset = "0x25D5720", VA = "0x1825D7120")]
		public void AddAnnotation(object annotation)
		{
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D40")]
		public T Annotation<T>() where T : class
		{
			return null;
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x25D74A0", Offset = "0x25D5AA0", VA = "0x1825D74A0")]
		public object Annotation(Type type)
		{
			return null;
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D42")]
		public IEnumerable<T> Annotations<T>() where T : class
		{
			return null;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x25D7600", Offset = "0x25D5C00", VA = "0x1825D7600")]
		public IEnumerable<object> Annotations(Type type)
		{
			return null;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D44")]
		public void RemoveAnnotations<T>() where T : class
		{
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x25D7710", Offset = "0x25D5D10", VA = "0x1825D7710")]
		public void RemoveAnnotations(Type type)
		{
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x25D7970", Offset = "0x25D5F70", VA = "0x1825D7970")]
		internal void CopyAnnotations(JToken target, JToken source)
		{
		}

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Nullable(2)]
		private static JTokenEqualityComparer _equalityComparer;

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Nullable(2)]
		private JContainer _parent;

		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Nullable(2)]
		private JToken _previous;

		// Token: 0x04000706 RID: 1798
		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Nullable(2)]
		private JToken _next;

		// Token: 0x04000707 RID: 1799
		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Nullable(2)]
		private object _annotations;

		// Token: 0x04000708 RID: 1800
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly JTokenType[] BooleanTypes;

		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly JTokenType[] NumberTypes;

		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly JTokenType[] BigIntegerTypes;

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly JTokenType[] StringTypes;

		// Token: 0x0400070C RID: 1804
		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly JTokenType[] GuidTypes;

		// Token: 0x0400070D RID: 1805
		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly JTokenType[] TimeSpanTypes;

		// Token: 0x0400070E RID: 1806
		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly JTokenType[] UriTypes;

		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly JTokenType[] CharTypes;

		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly JTokenType[] DateTimeTypes;

		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly JTokenType[] BytesTypes;

		// Token: 0x02000181 RID: 385
		[Token(Token = "0x2000181")]
		[NullableContext(0)]
		private class LineInfoAnnotation
		{
			// Token: 0x06000D48 RID: 3400 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D48")]
			[Address(RVA = "0x1F436F0", Offset = "0x1F41CF0", VA = "0x181F436F0")]
			public LineInfoAnnotation(int lineNumber, int linePosition)
			{
			}

			// Token: 0x04000712 RID: 1810
			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal readonly int LineNumber;

			// Token: 0x04000713 RID: 1811
			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal readonly int LinePosition;
		}
	}
}

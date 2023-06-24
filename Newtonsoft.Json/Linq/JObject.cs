using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	[NullableContext(1)]
	[Nullable(0)]
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
	{
		// Token: 0x06000BD8 RID: 3032 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x25C0280", Offset = "0x25BE880", VA = "0x1825C0280", Slot = "12")]
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x25C04C0", Offset = "0x25BEAC0", VA = "0x1825C04C0")]
		public new static Task<JObject> LoadAsync(JsonReader reader, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x25C04D0", Offset = "0x25BEAD0", VA = "0x1825C04D0")]
		public new static Task<JObject> LoadAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001F1")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0", Slot = "75")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000BDC RID: 3036 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000BDD RID: 3037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000007")]
		[Nullable(2)]
		public event PropertyChangedEventHandler PropertyChanged
		{
			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x25C0710", Offset = "0x25BED10", VA = "0x1825C0710", Slot = "121")]
			[NullableContext(2)]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x25C0800", Offset = "0x25BEE00", VA = "0x1825C0800", Slot = "122")]
			[NullableContext(2)]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000BDE RID: 3038 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000BDF RID: 3039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000008")]
		[Nullable(2)]
		public event PropertyChangingEventHandler PropertyChanging
		{
			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x25C08F0", Offset = "0x25BEEF0", VA = "0x1825C08F0", Slot = "123")]
			[NullableContext(2)]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x25C09E0", Offset = "0x25BEFE0", VA = "0x1825C09E0", Slot = "124")]
			[CompilerGenerated]
			[NullableContext(2)]
			remove
			{
			}
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x25C0AD0", Offset = "0x25BF0D0", VA = "0x1825C0AD0")]
		public JObject()
		{
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x25C0BA0", Offset = "0x25BF1A0", VA = "0x1825C0BA0")]
		public JObject(JObject other)
		{
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x25C0C60", Offset = "0x25BF260", VA = "0x1825C0C60")]
		internal JObject(JObject other, [Nullable(2)] JsonCloneSettings settings)
		{
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x25C0D30", Offset = "0x25BF330", VA = "0x1825C0D30")]
		public JObject(params object[] content)
		{
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x25C0D30", Offset = "0x25BF330", VA = "0x1825C0D30")]
		public JObject(object content)
		{
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x25C0E20", Offset = "0x25BF420", VA = "0x1825C0E20", Slot = "14")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x25C0EB0", Offset = "0x25BF4B0", VA = "0x1825C0EB0", Slot = "80")]
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x25C0FD0", Offset = "0x25BF5D0", VA = "0x1825C0FD0", Slot = "81")]
		[NullableContext(2)]
		internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			return default(bool);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x25C1050", Offset = "0x25BF650", VA = "0x1825C1050", Slot = "90")]
		internal override void ValidateToken(JToken o, [Nullable(2)] JToken existing)
		{
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x25C1340", Offset = "0x25BF940", VA = "0x1825C1340", Slot = "92")]
		internal override void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings)
		{
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00005D30 File Offset: 0x00003F30
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x25C1690", Offset = "0x25BFC90", VA = "0x1825C1690")]
		private static bool IsNull(JToken token)
		{
			return default(bool);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x25C1720", Offset = "0x25BFD20", VA = "0x1825C1720")]
		internal void InternalPropertyChanged(JProperty childProperty)
		{
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x25C18F0", Offset = "0x25BFEF0", VA = "0x1825C18F0")]
		internal void InternalPropertyChanging(JProperty childProperty)
		{
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x25C1920", Offset = "0x25BFF20", VA = "0x1825C1920", Slot = "13")]
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings)
		{
			return null;
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00005D48 File Offset: 0x00003F48
		[Token(Token = "0x170001F2")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "15")]
			get
			{
				return JTokenType.None;
			}
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x25C1A10", Offset = "0x25C0010", VA = "0x1825C1A10")]
		public IEnumerable<JProperty> Properties()
		{
			return null;
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x25C1A50", Offset = "0x25C0050", VA = "0x1825C1A50")]
		public JProperty Property(string name)
		{
			return null;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x25C1A60", Offset = "0x25C0060", VA = "0x1825C1A60")]
		public JProperty Property(string name, StringComparison comparison)
		{
			return null;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00005D60 File Offset: 0x00003F60
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x25C1C90", Offset = "0x25C0290", VA = "0x1825C1C90")]
		public JEnumerable<JToken> PropertyValues()
		{
			return default(JEnumerable<JToken>);
		}

		// Token: 0x170001F3 RID: 499
		[Token(Token = "0x170001F3")]
		[Nullable(2)]
		public override JToken this[object key]
		{
			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x25C1F10", Offset = "0x25C0510", VA = "0x1825C1F10", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x25C2140", Offset = "0x25C0740", VA = "0x1825C2140", Slot = "18")]
			[param: Nullable(2)]
			set
			{
			}
		}

		// Token: 0x170001F4 RID: 500
		[Token(Token = "0x170001F4")]
		[Nullable(2)]
		public JToken this[string propertyName]
		{
			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x25C2290", Offset = "0x25C0890", VA = "0x1825C2290", Slot = "93")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x25C2360", Offset = "0x25C0960", VA = "0x1825C2360", Slot = "94")]
			[param: Nullable(2)]
			set
			{
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x25C2490", Offset = "0x25C0A90", VA = "0x1825C2490")]
		public new static JObject Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x25C24A0", Offset = "0x25C0AA0", VA = "0x1825C24A0")]
		public new static JObject Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x25C2700", Offset = "0x25C0D00", VA = "0x1825C2700")]
		public new static JObject Parse(string json)
		{
			return null;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x25C2710", Offset = "0x25C0D10", VA = "0x1825C2710")]
		public new static JObject Parse(string json, [Nullable(2)] JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x25C2860", Offset = "0x25C0E60", VA = "0x1825C2860")]
		public new static JObject FromObject(object o)
		{
			return null;
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x25C29E0", Offset = "0x25C0FE0", VA = "0x1825C29E0")]
		public new static JObject FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x25C2B60", Offset = "0x25C1160", VA = "0x1825C2B60", Slot = "24")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x25C2CE0", Offset = "0x25C12E0", VA = "0x1825C2CE0")]
		[NullableContext(2)]
		public JToken GetValue(string propertyName)
		{
			return null;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x25C2D20", Offset = "0x25C1320", VA = "0x1825C2D20")]
		[NullableContext(2)]
		public JToken GetValue(string propertyName, StringComparison comparison)
		{
			return null;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00005D78 File Offset: 0x00003F78
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x25C2D60", Offset = "0x25C1360", VA = "0x1825C2D60")]
		public bool TryGetValue(string propertyName, StringComparison comparison, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out JToken value)
		{
			return default(bool);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x25C2DF0", Offset = "0x25C13F0", VA = "0x1825C2DF0", Slot = "98")]
		public void Add(string propertyName, [Nullable(2)] JToken value)
		{
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00005D90 File Offset: 0x00003F90
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x25C2E80", Offset = "0x25C1480", VA = "0x1825C2E80", Slot = "97")]
		public bool ContainsKey(string propertyName)
		{
			return default(bool);
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001F5")]
		private ICollection<string> Keys
		{
			[Token(Token = "0x6000C03")]
			[Address(RVA = "0x25C2F80", Offset = "0x25C1580", VA = "0x1825C2F80", Slot = "95")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x25C2FE0", Offset = "0x25C15E0", VA = "0x1825C2FE0", Slot = "99")]
		public bool Remove(string propertyName)
		{
			return default(bool);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00005DC0 File Offset: 0x00003FC0
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x25C3070", Offset = "0x25C1670", VA = "0x1825C3070", Slot = "100")]
		public bool TryGetValue(string propertyName, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out JToken value)
		{
			return default(bool);
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001F6")]
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private ICollection<JToken> Values
		{
			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x25C3160", Offset = "0x25C1760", VA = "0x1825C3160", Slot = "96")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x25C31A0", Offset = "0x25C17A0", VA = "0x1825C31A0", Slot = "103")]
		private void Add([Nullable(new byte[]
		{
			0,
			1,
			2
		})] KeyValuePair<string, JToken> item)
		{
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x25B5FB0", Offset = "0x25B45B0", VA = "0x1825B5FB0", Slot = "104")]
		private void Clear()
		{
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x25C3230", Offset = "0x25C1830", VA = "0x1825C3230", Slot = "105")]
		private bool Contains([Nullable(new byte[]
		{
			0,
			1,
			2
		})] KeyValuePair<string, JToken> item)
		{
			return default(bool);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x25C32B0", Offset = "0x25C18B0", VA = "0x1825C32B0", Slot = "106")]
		private void CopyTo([Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x170001F7")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000C0B")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00005E08 File Offset: 0x00004008
		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x25C3660", Offset = "0x25C1C60", VA = "0x1825C3660", Slot = "107")]
		private bool Remove([Nullable(new byte[]
		{
			0,
			1,
			2
		})] KeyValuePair<string, JToken> item)
		{
			return default(bool);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00005E20 File Offset: 0x00004020
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x25B6030", Offset = "0x25B4630", VA = "0x1825B6030", Slot = "25")]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x25C3760", Offset = "0x25C1D60", VA = "0x1825C3760", Slot = "108")]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x25C37F0", Offset = "0x25C1DF0", VA = "0x1825C37F0", Slot = "125")]
		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x25C3880", Offset = "0x25C1E80", VA = "0x1825C3880", Slot = "126")]
		protected virtual void OnPropertyChanging(string propertyName)
		{
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x25C3980", Offset = "0x25C1F80", VA = "0x1825C3980", Slot = "118")]
		private PropertyDescriptorCollection GetProperties()
		{
			return null;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x25C39C0", Offset = "0x25C1FC0", VA = "0x1825C39C0", Slot = "119")]
		private PropertyDescriptorCollection GetProperties([Nullable(new byte[]
		{
			2,
			1
		})] Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x25C3CE0", Offset = "0x25C22E0", VA = "0x1825C3CE0", Slot = "109")]
		private AttributeCollection GetAttributes()
		{
			return null;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "110")]
		[NullableContext(2)]
		private string GetClassName()
		{
			return null;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "111")]
		[NullableContext(2)]
		private string GetComponentName()
		{
			return null;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x25C3D30", Offset = "0x25C2330", VA = "0x1825C3D30", Slot = "112")]
		private TypeConverter GetConverter()
		{
			return null;
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "113")]
		[NullableContext(2)]
		private EventDescriptor GetDefaultEvent()
		{
			return null;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "114")]
		[NullableContext(2)]
		private PropertyDescriptor GetDefaultProperty()
		{
			return null;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "115")]
		private object GetEditor(Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x25C3D60", Offset = "0x25C2360", VA = "0x1825C3D60", Slot = "117")]
		private EventDescriptorCollection GetEvents([Nullable(new byte[]
		{
			2,
			1
		})] Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x25C3DB0", Offset = "0x25C23B0", VA = "0x1825C3DB0", Slot = "116")]
		private EventDescriptorCollection GetEvents()
		{
			return null;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x25C3E00", Offset = "0x25C2400", VA = "0x1825C3E00", Slot = "120")]
		[NullableContext(2)]
		private object GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x25C3E80", Offset = "0x25C2480", VA = "0x1825C3E80", Slot = "26")]
		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x25C3F40", Offset = "0x25C2540", VA = "0x1825C3F40")]
		[CompilerGenerated]
		private Task <WriteToAsync>g__AwaitProperties|0_0(Task task, int i, JsonWriter Writer, CancellationToken CancellationToken, JsonConverter[] Converters)
		{
			return null;
		}

		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly JPropertyKeyedCollection _properties;

		// Token: 0x0200016D RID: 365
		[Token(Token = "0x200016D")]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private class JObjectDynamicProxy : DynamicProxy<JObject>
		{
			// Token: 0x06000C1F RID: 3103 RVA: 0x00005E38 File Offset: 0x00004038
			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0x25C4230", Offset = "0x25C2830", VA = "0x1825C4230", Slot = "11")]
			public override bool TryGetMember(JObject instance, GetMemberBinder binder, [Nullable(2)] out object result)
			{
				return default(bool);
			}

			// Token: 0x06000C20 RID: 3104 RVA: 0x00005E50 File Offset: 0x00004050
			[Token(Token = "0x6000C20")]
			[Address(RVA = "0x25C4350", Offset = "0x25C2950", VA = "0x1825C4350", Slot = "15")]
			public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value)
			{
				return default(bool);
			}

			// Token: 0x06000C21 RID: 3105 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000C21")]
			[Address(RVA = "0x25C4430", Offset = "0x25C2A30", VA = "0x1825C4430", Slot = "4")]
			public override IEnumerable<string> GetDynamicMemberNames(JObject instance)
			{
				return null;
			}

			// Token: 0x06000C22 RID: 3106 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C22")]
			[Address(RVA = "0x25C45D0", Offset = "0x25C2BD0", VA = "0x1825C45D0")]
			public JObjectDynamicProxy()
			{
			}
		}
	}
}

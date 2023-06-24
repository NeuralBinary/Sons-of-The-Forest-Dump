using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	[Nullable(0)]
	[NullableContext(1)]
	public class JConstructor : JContainer
	{
		// Token: 0x06000B42 RID: 2882 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x25B6DD0", Offset = "0x25B53D0", VA = "0x1825B6DD0", Slot = "12")]
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x25B7070", Offset = "0x25B5670", VA = "0x1825B7070")]
		public new static Task<JConstructor> LoadAsync(JsonReader reader, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x25B7080", Offset = "0x25B5680", VA = "0x1825B7080")]
		public new static Task<JConstructor> LoadAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001D5")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10", Slot = "75")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00005940 File Offset: 0x00003B40
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x25B72C0", Offset = "0x25B58C0", VA = "0x1825B72C0", Slot = "80")]
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x25B7380", Offset = "0x25B5980", VA = "0x1825B7380", Slot = "92")]
		internal override void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings)
		{
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000B49 RID: 2889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D6")]
		[Nullable(2)]
		public string Name
		{
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x170001D7")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "15")]
			get
			{
				return JTokenType.None;
			}
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x25B7460", Offset = "0x25B5A60", VA = "0x1825B7460")]
		public JConstructor()
		{
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x25B7540", Offset = "0x25B5B40", VA = "0x1825B7540")]
		public JConstructor(JConstructor other)
		{
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x25B7680", Offset = "0x25B5C80", VA = "0x1825B7680")]
		internal JConstructor(JConstructor other, [Nullable(2)] JsonCloneSettings settings)
		{
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x25B77D0", Offset = "0x25B5DD0", VA = "0x1825B77D0")]
		public JConstructor(string name, params object[] content)
		{
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x25B77D0", Offset = "0x25B5DD0", VA = "0x1825B77D0")]
		public JConstructor(string name, object content)
		{
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x25B7810", Offset = "0x25B5E10", VA = "0x1825B7810")]
		public JConstructor(string name)
		{
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x25B7A10", Offset = "0x25B6010", VA = "0x1825B7A10", Slot = "14")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x25B7C10", Offset = "0x25B6210", VA = "0x1825B7C10", Slot = "13")]
		internal override JToken CloneToken([Nullable(2)] [Optional] JsonCloneSettings settings)
		{
			return null;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x25B7D90", Offset = "0x25B6390", VA = "0x1825B7D90", Slot = "24")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x170001D8 RID: 472
		[Token(Token = "0x170001D8")]
		[Nullable(2)]
		public override JToken this[object key]
		{
			[Token(Token = "0x6000B54")]
			[Address(RVA = "0x25B7EA0", Offset = "0x25B64A0", VA = "0x1825B7EA0", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B55")]
			[Address(RVA = "0x25B8010", Offset = "0x25B6610", VA = "0x1825B8010", Slot = "18")]
			[param: Nullable(2)]
			set
			{
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x25B8190", Offset = "0x25B6790", VA = "0x1825B8190", Slot = "25")]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x25B81E0", Offset = "0x25B67E0", VA = "0x1825B81E0")]
		public new static JConstructor Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x25B81F0", Offset = "0x25B67F0", VA = "0x1825B81F0")]
		public new static JConstructor Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Nullable(2)]
		private string _name;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly List<JToken> _values;
	}
}

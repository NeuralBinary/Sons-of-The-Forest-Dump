using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x2000161")]
	[NullableContext(1)]
	[Nullable(0)]
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		// Token: 0x06000B1A RID: 2842 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x25B4740", Offset = "0x25B2D40", VA = "0x1825B4740", Slot = "12")]
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x25B49E0", Offset = "0x25B2FE0", VA = "0x1825B49E0")]
		public new static Task<JArray> LoadAsync(JsonReader reader, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x25B49F0", Offset = "0x25B2FF0", VA = "0x1825B49F0")]
		public new static Task<JArray> LoadAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001D0")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0", Slot = "75")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x170001D1")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "15")]
			get
			{
				return JTokenType.None;
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x25B4C30", Offset = "0x25B3230", VA = "0x1825B4C30")]
		public JArray()
		{
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x25B4D10", Offset = "0x25B3310", VA = "0x1825B4D10")]
		public JArray(JArray other)
		{
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x25B4DE0", Offset = "0x25B33E0", VA = "0x1825B4DE0")]
		internal JArray(JArray other, [Nullable(2)] JsonCloneSettings settings)
		{
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x25B4EC0", Offset = "0x25B34C0", VA = "0x1825B4EC0")]
		public JArray(params object[] content)
		{
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x25B4ED0", Offset = "0x25B34D0", VA = "0x1825B4ED0")]
		public JArray(object content)
		{
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x25B4FD0", Offset = "0x25B35D0", VA = "0x1825B4FD0", Slot = "14")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x25B5180", Offset = "0x25B3780", VA = "0x1825B5180", Slot = "13")]
		internal override JToken CloneToken([Nullable(2)] [Optional] JsonCloneSettings settings)
		{
			return null;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x25B5280", Offset = "0x25B3880", VA = "0x1825B5280")]
		public new static JArray Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x25B5290", Offset = "0x25B3890", VA = "0x1825B5290")]
		public new static JArray Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x25B54A0", Offset = "0x25B3AA0", VA = "0x1825B54A0")]
		public new static JArray Parse(string json)
		{
			return null;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x25B54B0", Offset = "0x25B3AB0", VA = "0x1825B54B0")]
		public new static JArray Parse(string json, [Nullable(2)] JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x25B5600", Offset = "0x25B3C00", VA = "0x1825B5600")]
		public new static JArray FromObject(object o)
		{
			return null;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x25B5780", Offset = "0x25B3D80", VA = "0x1825B5780")]
		public new static JArray FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x25B5900", Offset = "0x25B3F00", VA = "0x1825B5900", Slot = "24")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x170001D2 RID: 466
		[Token(Token = "0x170001D2")]
		[Nullable(2)]
		public override JToken this[object key]
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x25B5A00", Offset = "0x25B4000", VA = "0x1825B5A00", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x25B5B70", Offset = "0x25B4170", VA = "0x1825B5B70", Slot = "18")]
			[param: Nullable(2)]
			set
			{
			}
		}

		// Token: 0x170001D3 RID: 467
		[Token(Token = "0x170001D3")]
		public JToken this[int index]
		{
			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0x25B5CE0", Offset = "0x25B42E0", VA = "0x1825B5CE0", Slot = "27")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x25B5D00", Offset = "0x25B4300", VA = "0x1825B5D00", Slot = "28")]
			set
			{
			}
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x25B5D20", Offset = "0x25B4320", VA = "0x1825B5D20", Slot = "80")]
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x25B5DE0", Offset = "0x25B43E0", VA = "0x1825B5DE0", Slot = "92")]
		internal override void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings)
		{
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x000058C8 File Offset: 0x00003AC8
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x25B5EC0", Offset = "0x25B44C0", VA = "0x1825B5EC0", Slot = "29")]
		public int IndexOf(JToken item)
		{
			return 0;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x25B5EE0", Offset = "0x25B44E0", VA = "0x1825B5EE0", Slot = "30")]
		public void Insert(int index, JToken item)
		{
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x25B5F10", Offset = "0x25B4510", VA = "0x1825B5F10", Slot = "31")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x25B5F30", Offset = "0x25B4530", VA = "0x1825B5F30", Slot = "5")]
		public IEnumerator<JToken> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x25B5F90", Offset = "0x25B4590", VA = "0x1825B5F90", Slot = "34")]
		public void Add(JToken item)
		{
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x25B5FB0", Offset = "0x25B45B0", VA = "0x1825B5FB0", Slot = "35")]
		public void Clear()
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x25B5FD0", Offset = "0x25B45D0", VA = "0x1825B5FD0", Slot = "36")]
		public bool Contains(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x25B5FF0", Offset = "0x25B45F0", VA = "0x1825B5FF0", Slot = "37")]
		public void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x170001D4")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x25B6010", Offset = "0x25B4610", VA = "0x1825B6010", Slot = "38")]
		public bool Remove(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x25B6030", Offset = "0x25B4630", VA = "0x1825B6030", Slot = "25")]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly List<JToken> _values;
	}
}

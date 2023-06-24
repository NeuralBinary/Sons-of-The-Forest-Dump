using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	[Nullable(0)]
	[NullableContext(1)]
	public class JProperty : JContainer
	{
		// Token: 0x06000C34 RID: 3124 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x25C5AE0", Offset = "0x25C40E0", VA = "0x1825C5AE0", Slot = "12")]
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x25C5C00", Offset = "0x25C4200", VA = "0x1825C5C00")]
		private Task WriteToAsync(Task task, JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x25C5EF0", Offset = "0x25C44F0", VA = "0x1825C5EF0")]
		private Task WriteValueAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x25C5F60", Offset = "0x25C4560", VA = "0x1825C5F60")]
		public new static Task<JProperty> LoadAsync(JsonReader reader, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x25C5F70", Offset = "0x25C4570", VA = "0x1825C5F70")]
		public new static Task<JProperty> LoadAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001FA")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0", Slot = "75")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001FB")]
		public string Name
		{
			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FC")]
		public new JToken Value
		{
			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0x25C61B0", Offset = "0x25C47B0", VA = "0x1825C61B0")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3C")]
			[Address(RVA = "0x25C61D0", Offset = "0x25C47D0", VA = "0x1825C61D0")]
			set
			{
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x25C6290", Offset = "0x25C4890", VA = "0x1825C6290")]
		public JProperty(JProperty other)
		{
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x25C63C0", Offset = "0x25C49C0", VA = "0x1825C63C0")]
		internal JProperty(JProperty other, [Nullable(2)] JsonCloneSettings settings)
		{
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x25C64F0", Offset = "0x25C4AF0", VA = "0x1825C64F0", Slot = "84")]
		internal override JToken GetItem(int index)
		{
			return null;
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x25C6560", Offset = "0x25C4B60", VA = "0x1825C6560", Slot = "85")]
		[NullableContext(2)]
		internal override void SetItem(int index, JToken item)
		{
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00005E98 File Offset: 0x00004098
		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x25C6730", Offset = "0x25C4D30", VA = "0x1825C6730", Slot = "83")]
		[NullableContext(2)]
		internal override bool RemoveItem(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x25C67F0", Offset = "0x25C4DF0", VA = "0x1825C67F0", Slot = "82")]
		internal override void RemoveItemAt(int index)
		{
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00005EB0 File Offset: 0x000040B0
		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x25C68B0", Offset = "0x25C4EB0", VA = "0x1825C68B0", Slot = "80")]
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00005EC8 File Offset: 0x000040C8
		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x25C68F0", Offset = "0x25C4EF0", VA = "0x1825C68F0", Slot = "81")]
		[NullableContext(2)]
		internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			return default(bool);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00005EE0 File Offset: 0x000040E0
		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x25C6A20", Offset = "0x25C5020", VA = "0x1825C6A20", Slot = "88")]
		[NullableContext(2)]
		internal override bool ContainsItem(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x25C6A40", Offset = "0x25C5040", VA = "0x1825C6A40", Slot = "92")]
		internal override void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings)
		{
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x25C6B40", Offset = "0x25C5140", VA = "0x1825C6B40", Slot = "86")]
		internal override void ClearItems()
		{
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00005EF8 File Offset: 0x000040F8
		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x25C6C00", Offset = "0x25C5200", VA = "0x1825C6C00", Slot = "14")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x25C6E00", Offset = "0x25C5400", VA = "0x1825C6E00", Slot = "13")]
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings)
		{
			return null;
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00005F10 File Offset: 0x00004110
		[Token(Token = "0x170001FD")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000C4A")]
			[Address(RVA = "0xE51980", Offset = "0xE4FF80", VA = "0x180E51980", Slot = "15")]
			[DebuggerStepThrough]
			get
			{
				return JTokenType.None;
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x25C6F60", Offset = "0x25C5560", VA = "0x1825C6F60")]
		internal JProperty(string name)
		{
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x25C7100", Offset = "0x25C5700", VA = "0x1825C7100")]
		public JProperty(string name, params object[] content)
		{
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x25C7110", Offset = "0x25C5710", VA = "0x1825C7110")]
		public JProperty(string name, [Nullable(2)] object content)
		{
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x25C7390", Offset = "0x25C5990", VA = "0x1825C7390", Slot = "24")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00005F28 File Offset: 0x00004128
		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x25C7430", Offset = "0x25C5A30", VA = "0x1825C7430", Slot = "25")]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x25C74B0", Offset = "0x25C5AB0", VA = "0x1825C74B0")]
		public new static JProperty Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x25C74C0", Offset = "0x25C5AC0", VA = "0x1825C74C0")]
		public new static JProperty Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x040006DB RID: 1755
		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly JProperty.JPropertyList _content;

		// Token: 0x040006DC RID: 1756
		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly string _name;

		// Token: 0x02000174 RID: 372
		[Token(Token = "0x2000174")]
		[Nullable(0)]
		private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
		{
			// Token: 0x06000C52 RID: 3154 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x25C7730", Offset = "0x25C5D30", VA = "0x1825C7730", Slot = "16")]
			public IEnumerator<JToken> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000C53 RID: 3155 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000C53")]
			[Address(RVA = "0x25C7730", Offset = "0x25C5D30", VA = "0x1825C7730", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000C54 RID: 3156 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620", Slot = "11")]
			public void Add(JToken item)
			{
			}

			// Token: 0x06000C55 RID: 3157 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x62FF90", Offset = "0x62E590", VA = "0x18062FF90", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06000C56 RID: 3158 RVA: 0x00005F40 File Offset: 0x00004140
			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x141D8B0", Offset = "0x141BEB0", VA = "0x18141D8B0", Slot = "13")]
			public bool Contains(JToken item)
			{
				return default(bool);
			}

			// Token: 0x06000C57 RID: 3159 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x25C77C0", Offset = "0x25C5DC0", VA = "0x1825C77C0", Slot = "14")]
			public void CopyTo(JToken[] array, int arrayIndex)
			{
			}

			// Token: 0x06000C58 RID: 3160 RVA: 0x00005F58 File Offset: 0x00004158
			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x25C7830", Offset = "0x25C5E30", VA = "0x1825C7830", Slot = "15")]
			public bool Remove(JToken item)
			{
				return default(bool);
			}

			// Token: 0x170001FE RID: 510
			// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00005F70 File Offset: 0x00004170
			[Token(Token = "0x170001FE")]
			public int Count
			{
				[Token(Token = "0x6000C59")]
				[Address(RVA = "0x25C7890", Offset = "0x25C5E90", VA = "0x1825C7890", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170001FF RID: 511
			// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00005F88 File Offset: 0x00004188
			[Token(Token = "0x170001FF")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6000C5A")]
				[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000C5B RID: 3163 RVA: 0x00005FA0 File Offset: 0x000041A0
			[Token(Token = "0x6000C5B")]
			[Address(RVA = "0x25C78A0", Offset = "0x25C5EA0", VA = "0x1825C78A0", Slot = "6")]
			public int IndexOf(JToken item)
			{
				return 0;
			}

			// Token: 0x06000C5C RID: 3164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0x25C78B0", Offset = "0x25C5EB0", VA = "0x1825C78B0", Slot = "7")]
			public void Insert(int index, JToken item)
			{
			}

			// Token: 0x06000C5D RID: 3165 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x25C7910", Offset = "0x25C5F10", VA = "0x1825C7910", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x17000200 RID: 512
			[Token(Token = "0x17000200")]
			public JToken this[int index]
			{
				[Token(Token = "0x6000C5E")]
				[Address(RVA = "0x25C7970", Offset = "0x25C5F70", VA = "0x1825C7970", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000C5F")]
				[Address(RVA = "0x25C79D0", Offset = "0x25C5FD0", VA = "0x1825C79D0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x06000C60 RID: 3168 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public JPropertyList()
			{
			}

			// Token: 0x040006DD RID: 1757
			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Nullable(2)]
			internal JToken _token;
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, ICollection, IList, INotifyCollectionChanged
	{
		// Token: 0x06000B5D RID: 2909 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x25B9290", Offset = "0x25B7890", VA = "0x1825B9290")]
		internal Task ReadTokenFromAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings options, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x25B9530", Offset = "0x25B7B30", VA = "0x1825B9530")]
		private Task ReadContentFromAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000B5F RID: 2911 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B60 RID: 2912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event ListChangedEventHandler ListChanged
		{
			[Token(Token = "0x6000B5F")]
			[Address(RVA = "0x25B97D0", Offset = "0x25B7DD0", VA = "0x1825B97D0", Slot = "71")]
			add
			{
			}
			[Token(Token = "0x6000B60")]
			[Address(RVA = "0x25B98B0", Offset = "0x25B7EB0", VA = "0x1825B98B0", Slot = "72")]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000B61 RID: 2913 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B62 RID: 2914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public event AddingNewEventHandler AddingNew
		{
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0x25B9990", Offset = "0x25B7F90", VA = "0x1825B9990")]
			add
			{
			}
			[Token(Token = "0x6000B62")]
			[Address(RVA = "0x25B9A70", Offset = "0x25B8070", VA = "0x1825B9A70")]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000B63 RID: 2915 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B64 RID: 2916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		[Nullable(2)]
		public event NotifyCollectionChangedEventHandler CollectionChanged
		{
			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x25B9B50", Offset = "0x25B8150", VA = "0x1825B9B50", Slot = "73")]
			[NullableContext(2)]
			add
			{
			}
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x25B9C30", Offset = "0x25B8230", VA = "0x1825B9C30", Slot = "74")]
			[NullableContext(2)]
			remove
			{
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000B65 RID: 2917
		[Token(Token = "0x170001D9")]
		protected abstract IList<JToken> ChildrenTokens { [Token(Token = "0x6000B65")] get; }

		// Token: 0x06000B66 RID: 2918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x25B9D10", Offset = "0x25B8310", VA = "0x1825B9D10")]
		internal JContainer()
		{
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x25B9D50", Offset = "0x25B8350", VA = "0x1825B9D50")]
		internal JContainer(JContainer other, [Nullable(2)] JsonCloneSettings settings)
		{
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x25BA000", Offset = "0x25B8600", VA = "0x1825BA000")]
		internal void CheckReentrancy()
		{
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x25BA0B0", Offset = "0x25B86B0", VA = "0x1825BA0B0", Slot = "76")]
		internal virtual IList<JToken> CreateChildrenCollection()
		{
			return null;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x25BA110", Offset = "0x25B8710", VA = "0x1825BA110", Slot = "77")]
		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x25BA130", Offset = "0x25B8730", VA = "0x1825BA130", Slot = "78")]
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x25BA1A0", Offset = "0x25B87A0", VA = "0x1825BA1A0", Slot = "79")]
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x170001DA")]
		public override bool HasValues
		{
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0x25BA210", Offset = "0x25B8810", VA = "0x1825BA210", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x25BA280", Offset = "0x25B8880", VA = "0x1825BA280")]
		internal bool ContentsEqual(JContainer container)
		{
			return default(bool);
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001DB")]
		[Nullable(2)]
		public override JToken First
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x25BA3E0", Offset = "0x25B89E0", VA = "0x1825BA3E0", Slot = "20")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001DC")]
		[Nullable(2)]
		public override JToken Last
		{
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x25BA470", Offset = "0x25B8A70", VA = "0x1825BA470", Slot = "21")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x25BA500", Offset = "0x25B8B00", VA = "0x1825BA500", Slot = "22")]
		public override JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B72")]
		[NullableContext(2)]
		public override IEnumerable<T> Values<T>()
		{
			return null;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x25BA610", Offset = "0x25B8C10", VA = "0x1825BA610")]
		public IEnumerable<JToken> Descendants()
		{
			return null;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x25BA620", Offset = "0x25B8C20", VA = "0x1825BA620")]
		public IEnumerable<JToken> DescendantsAndSelf()
		{
			return null;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x25BA630", Offset = "0x25B8C30", VA = "0x1825BA630")]
		internal IEnumerable<JToken> GetDescendants(bool self)
		{
			return null;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x25BA6F0", Offset = "0x25B8CF0", VA = "0x1825BA6F0")]
		[NullableContext(2)]
		internal bool IsMultiContent([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] object content)
		{
			return default(bool);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x25BA7C0", Offset = "0x25B8DC0", VA = "0x1825BA7C0")]
		internal JToken EnsureParentToken([Nullable(2)] JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			return null;
		}

		// Token: 0x06000B78 RID: 2936
		[Token(Token = "0x6000B78")]
		[NullableContext(2)]
		internal abstract int IndexOfItem(JToken item);

		// Token: 0x06000B79 RID: 2937 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x25BA900", Offset = "0x25B8F00", VA = "0x1825BA900", Slot = "81")]
		[NullableContext(2)]
		internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			return default(bool);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x25BACF0", Offset = "0x25B92F0", VA = "0x1825BACF0", Slot = "82")]
		internal virtual void RemoveItemAt(int index)
		{
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x25BB060", Offset = "0x25B9660", VA = "0x1825BB060", Slot = "83")]
		[NullableContext(2)]
		internal virtual bool RemoveItem(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x25BB0B0", Offset = "0x25B96B0", VA = "0x1825BB0B0", Slot = "84")]
		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x25BB120", Offset = "0x25B9720", VA = "0x1825BB120", Slot = "85")]
		[NullableContext(2)]
		internal virtual void SetItem(int index, JToken item)
		{
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x25BB580", Offset = "0x25B9B80", VA = "0x1825BB580", Slot = "86")]
		internal virtual void ClearItems()
		{
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x25BBA00", Offset = "0x25BA000", VA = "0x1825BBA00", Slot = "87")]
		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00005A30 File Offset: 0x00003C30
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x25BBA60", Offset = "0x25BA060", VA = "0x1825BBA60", Slot = "88")]
		[NullableContext(2)]
		internal virtual bool ContainsItem(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x25BBA90", Offset = "0x25BA090", VA = "0x1825BBA90", Slot = "89")]
		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00005A48 File Offset: 0x00003C48
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x25BBD70", Offset = "0x25BA370", VA = "0x1825BBD70")]
		internal static bool IsTokenUnchanged(JToken currentValue, [Nullable(2)] JToken newValue)
		{
			return default(bool);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x25BBE20", Offset = "0x25BA420", VA = "0x1825BBE20", Slot = "90")]
		internal virtual void ValidateToken(JToken o, [Nullable(2)] JToken existing)
		{
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x25BBF80", Offset = "0x25BA580", VA = "0x1825BBF80", Slot = "91")]
		[NullableContext(2)]
		public virtual void Add(object content)
		{
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00005A60 File Offset: 0x00003C60
		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x25BC010", Offset = "0x25BA610", VA = "0x1825BC010")]
		[NullableContext(2)]
		internal bool TryAdd(object content)
		{
			return default(bool);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x25BC0A0", Offset = "0x25BA6A0", VA = "0x1825BC0A0")]
		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x25BC130", Offset = "0x25BA730", VA = "0x1825BC130")]
		[NullableContext(2)]
		public void AddFirst(object content)
		{
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00005A78 File Offset: 0x00003C78
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x25BC160", Offset = "0x25BA760", VA = "0x1825BC160")]
		[NullableContext(2)]
		internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations)
		{
			return default(bool);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x25BC420", Offset = "0x25BAA20", VA = "0x1825BC420")]
		internal static JToken CreateFromContent([Nullable(2)] object content)
		{
			return null;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x25BC4D0", Offset = "0x25BAAD0", VA = "0x1825BC4D0")]
		public JsonWriter CreateWriter()
		{
			return null;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x25BC670", Offset = "0x25BAC70", VA = "0x1825BC670")]
		public void ReplaceAll(object content)
		{
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x25B5FB0", Offset = "0x25B45B0", VA = "0x1825B5FB0")]
		public void RemoveAll()
		{
		}

		// Token: 0x06000B8D RID: 2957
		[Token(Token = "0x6000B8D")]
		internal abstract void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings);

		// Token: 0x06000B8E RID: 2958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x25BC6C0", Offset = "0x25BACC0", VA = "0x1825BC6C0")]
		[NullableContext(2)]
		public void Merge(object content)
		{
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x25BC710", Offset = "0x25BAD10", VA = "0x1825BC710")]
		[NullableContext(2)]
		public void Merge(object content, JsonMergeSettings settings)
		{
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x25BC760", Offset = "0x25BAD60", VA = "0x1825BC760")]
		private void ValidateContent(object content)
		{
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x25BC920", Offset = "0x25BAF20", VA = "0x1825BC920")]
		internal void ReadTokenFrom(JsonReader reader, [Nullable(2)] JsonLoadSettings options)
		{
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x25BCAE0", Offset = "0x25BB0E0", VA = "0x1825BCAE0")]
		internal void ReadContentFrom(JsonReader r, [Nullable(2)] JsonLoadSettings settings)
		{
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x25BD190", Offset = "0x25BB790", VA = "0x1825BD190")]
		[NullableContext(2)]
		private static JProperty ReadProperty([Nullable(1)] JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, [Nullable(1)] JContainer parent)
		{
			return null;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00005A90 File Offset: 0x00003C90
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x25BD3F0", Offset = "0x25BB9F0", VA = "0x1825BD3F0")]
		internal int ContentsHashCode()
		{
			return 0;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x25BD5E0", Offset = "0x25BBBE0", VA = "0x1825BD5E0", Slot = "39")]
		private string GetListName(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x25BD620", Offset = "0x25BBC20", VA = "0x1825BD620", Slot = "40")]
		private PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x25B5EC0", Offset = "0x25B44C0", VA = "0x1825B5EC0", Slot = "29")]
		private int IndexOf(JToken item)
		{
			return 0;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x25B5EE0", Offset = "0x25B44E0", VA = "0x1825B5EE0", Slot = "30")]
		private void Insert(int index, JToken item)
		{
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x25B5F10", Offset = "0x25B4510", VA = "0x1825B5F10", Slot = "31")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DD")]
		private JToken Item
		{
			[Token(Token = "0x6000B9A")]
			[Address(RVA = "0x25B5CE0", Offset = "0x25B42E0", VA = "0x1825B5CE0", Slot = "27")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x25B5D00", Offset = "0x25B4300", VA = "0x1825B5D00", Slot = "28")]
			set
			{
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x25B5F90", Offset = "0x25B4590", VA = "0x1825B5F90", Slot = "34")]
		private void Add(JToken item)
		{
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x25B5FB0", Offset = "0x25B45B0", VA = "0x1825B5FB0", Slot = "35")]
		private void Clear()
		{
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x25B5FD0", Offset = "0x25B45D0", VA = "0x1825B5FD0", Slot = "36")]
		private bool Contains(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x25B5FF0", Offset = "0x25B45F0", VA = "0x1825B5FF0", Slot = "37")]
		private void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x170001DE")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x25B6010", Offset = "0x25B4610", VA = "0x1825B6010", Slot = "38")]
		private bool Remove(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x25BD6E0", Offset = "0x25BBCE0", VA = "0x1825BD6E0")]
		[NullableContext(2)]
		private JToken EnsureValue(object value)
		{
			return null;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x25BD790", Offset = "0x25BBD90", VA = "0x1825BD790", Slot = "58")]
		[NullableContext(2)]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x25B5FB0", Offset = "0x25B45B0", VA = "0x1825B5FB0", Slot = "60")]
		private void Clear()
		{
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x25BD810", Offset = "0x25BBE10", VA = "0x1825BD810", Slot = "59")]
		[NullableContext(2)]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x25BD840", Offset = "0x25BBE40", VA = "0x1825BD840", Slot = "63")]
		[NullableContext(2)]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x25BD870", Offset = "0x25BBE70", VA = "0x1825BD870", Slot = "64")]
		[NullableContext(2)]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x170001DF")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x170001E0")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x25BD8C0", Offset = "0x25BBEC0", VA = "0x1825BD8C0", Slot = "65")]
		[NullableContext(2)]
		private void Remove(object value)
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x25B5F10", Offset = "0x25B4510", VA = "0x1825B5F10", Slot = "66")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E1")]
		[Nullable(2)]
		private object Item
		{
			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0x25B5CE0", Offset = "0x25B42E0", VA = "0x1825B5CE0", Slot = "56")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0x25BD8F0", Offset = "0x25BBEF0", VA = "0x1825BD8F0", Slot = "57")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x25B5FF0", Offset = "0x25B45F0", VA = "0x1825B5FF0", Slot = "67")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x170001E2")]
		public int Count
		{
			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0x25BD930", Offset = "0x25BBF30", VA = "0x1825BD930", Slot = "68")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x170001E3")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001E4")]
		private object SyncRoot
		{
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x25BD990", Offset = "0x25BBF90", VA = "0x1825BD990", Slot = "69")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "51")]
		private void AddIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x25BDA30", Offset = "0x25BC030", VA = "0x1825BDA30", Slot = "42")]
		private object AddNew()
		{
			return null;
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x170001E5")]
		private bool AllowEdit
		{
			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Token(Token = "0x170001E6")]
		private bool AllowNew
		{
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x170001E7")]
		private bool AllowRemove
		{
			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x25BDC60", Offset = "0x25BC260", VA = "0x1825BDC60", Slot = "52")]
		private void ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x25BDCA0", Offset = "0x25BC2A0", VA = "0x1825BDCA0", Slot = "53")]
		private int Find(PropertyDescriptor property, object key)
		{
			return 0;
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x170001E8")]
		private bool IsSorted
		{
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "54")]
		private void RemoveIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x25BDCE0", Offset = "0x25BC2E0", VA = "0x1825BDCE0", Slot = "55")]
		private void RemoveSort()
		{
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x170001E9")]
		private ListSortDirection SortDirection
		{
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "50")]
			get
			{
				return ListSortDirection.Ascending;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001EA")]
		[Nullable(2)]
		private PropertyDescriptor SortProperty
		{
			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "49")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x170001EB")]
		private bool SupportsChangeNotification
		{
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x170001EC")]
		private bool SupportsSearching
		{
			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "46")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x170001ED")]
		private bool SupportsSorting
		{
			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "47")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x25BDD20", Offset = "0x25BC320", VA = "0x1825BDD20")]
		internal static void MergeEnumerableContent(JContainer target, IEnumerable content, [Nullable(2)] JsonMergeSettings settings)
		{
		}

		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Nullable(2)]
		internal ListChangedEventHandler _listChanged;

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Nullable(2)]
		internal AddingNewEventHandler _addingNew;

		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Nullable(2)]
		internal NotifyCollectionChangedEventHandler _collectionChanged;

		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Nullable(2)]
		private object _syncRoot;

		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _busy;
	}
}

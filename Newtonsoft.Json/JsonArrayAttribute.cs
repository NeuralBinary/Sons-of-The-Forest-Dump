using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonArrayAttribute : JsonContainerAttribute
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public bool AllowNullItems
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x15771E0", Offset = "0x15757E0", VA = "0x1815771E0")]
			set
			{
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public JsonArrayAttribute()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x15771E0", Offset = "0x15757E0", VA = "0x1815771E0")]
		public JsonArrayAttribute(bool allowNullItems)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		[NullableContext(1)]
		public JsonArrayAttribute(string id)
		{
		}

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x68")]
		private bool _allowNullItems;
	}
}

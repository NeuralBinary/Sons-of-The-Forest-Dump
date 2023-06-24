using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class NamingStrategy
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x000051A8 File Offset: 0x000033A8
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000170")]
		public bool ProcessDictionaryKeys
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x000051C0 File Offset: 0x000033C0
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000171")]
		public bool ProcessExtensionDataNames
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x5FD500", Offset = "0x5FBB00", VA = "0x1805FD500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x5FD510", Offset = "0x5FBB10", VA = "0x1805FD510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x000051D8 File Offset: 0x000033D8
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000172")]
		public bool OverrideSpecifiedNames
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x5FD520", Offset = "0x5FBB20", VA = "0x1805FD520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x5FD530", Offset = "0x5FBB30", VA = "0x1805FD530")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x25A3130", Offset = "0x25A1730", VA = "0x1825A3130", Slot = "4")]
		public virtual string GetPropertyName(string name, bool hasSpecifiedName)
		{
			return null;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x25A3160", Offset = "0x25A1760", VA = "0x1825A3160", Slot = "5")]
		public virtual string GetExtensionDataName(string name)
		{
			return null;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x25A3180", Offset = "0x25A1780", VA = "0x1825A3180", Slot = "6")]
		public virtual string GetDictionaryKey(string key)
		{
			return null;
		}

		// Token: 0x06000984 RID: 2436
		[Token(Token = "0x6000984")]
		protected abstract string ResolvePropertyName(string name);

		// Token: 0x06000985 RID: 2437 RVA: 0x000051F0 File Offset: 0x000033F0
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x25A31A0", Offset = "0x25A17A0", VA = "0x1825A31A0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00005208 File Offset: 0x00003408
		[Token(Token = "0x6000986")]
		[Address(RVA = "0x25A3210", Offset = "0x25A1810", VA = "0x1825A3210", Slot = "0")]
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x25A3320", Offset = "0x25A1920", VA = "0x1825A3320")]
		[NullableContext(2)]
		protected bool Equals(NamingStrategy other)
		{
			return default(bool);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected NamingStrategy()
		{
		}
	}
}

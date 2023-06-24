using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	internal class NetworkStorage : BitSet, IBoltListNode
	{
		// Token: 0x0600054D RID: 1357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x8ECBC0", Offset = "0x8EB1C0", VA = "0x1808ECBC0")]
		public NetworkStorage(int size)
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x8ECC70", Offset = "0x8EB270", VA = "0x1808ECC70")]
		public void PropertyChanged(int property)
		{
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000104")]
		private object prev
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x8ECC90", Offset = "0x8EB290", VA = "0x1808ECC90", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000105")]
		private object next
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x7849C0", Offset = "0x782FC0", VA = "0x1807849C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x7849D0", Offset = "0x782FD0", VA = "0x1807849D0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000106")]
		private object list
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x784A40", Offset = "0x783040", VA = "0x180784A40", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0xA8")]
		public int Frame;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0xB0")]
		public NetworkObj Root;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0xB8")]
		public NetworkValue[] Values;
	}
}

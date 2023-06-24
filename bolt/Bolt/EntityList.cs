using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class EntityList : IEnumerable<BoltEntity>, IEnumerable
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x170000AE")]
		public int Count
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x8DA210", Offset = "0x8D8810", VA = "0x1808DA210")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		internal EntityList(List<Entity> l)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x8DA250", Offset = "0x8D8850", VA = "0x1808DA250", Slot = "4")]
		public IEnumerator<BoltEntity> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x8DA250", Offset = "0x8D8850", VA = "0x1808DA250", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Entity> _list;
	}
}

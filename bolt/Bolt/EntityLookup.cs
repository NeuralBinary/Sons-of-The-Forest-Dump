using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	public class EntityLookup : IEnumerable<BoltEntity>, IEnumerable
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x170000B1")]
		public int Count
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x8DA700", Offset = "0x8D8D00", VA = "0x1808DA700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		internal EntityLookup(Dictionary<NetworkId, EntityProxy> d)
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x8DA740", Offset = "0x8D8D40", VA = "0x1808DA740")]
		public bool TryGet(NetworkId id, out BoltEntity entity)
		{
			return default(bool);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x8DA8F0", Offset = "0x8D8EF0", VA = "0x1808DA8F0", Slot = "4")]
		public IEnumerator<BoltEntity> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x8DA8F0", Offset = "0x8D8EF0", VA = "0x1808DA8F0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<NetworkId, EntityProxy> _dict;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable
	{
		// Token: 0x06001009 RID: 4105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001009")]
		[Address(RVA = "0x260CD80", Offset = "0x260B380", VA = "0x18260CD80")]
		public void Add(BsonToken token)
		{
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x170002B4")]
		public override BsonType Type
		{
			[Token(Token = "0x600100A")]
			[Address(RVA = "0x260CE70", Offset = "0x260B470", VA = "0x18260CE70", Slot = "4")]
			get
			{
				return (BsonType)0;
			}
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600100B")]
		[Address(RVA = "0x260CE80", Offset = "0x260B480", VA = "0x18260CE80", Slot = "5")]
		public IEnumerator<BsonToken> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600100C")]
		[Address(RVA = "0x260CF60", Offset = "0x260B560", VA = "0x18260CF60", Slot = "6")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x260CF70", Offset = "0x260B570", VA = "0x18260CF70")]
		public BsonArray()
		{
		}

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<BsonToken> _children;
	}
}

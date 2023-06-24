using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001DB RID: 475
	[Token(Token = "0x20001DB")]
	internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable
	{
		// Token: 0x06001004 RID: 4100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x260C980", Offset = "0x260AF80", VA = "0x18260C980")]
		public void Add(string name, BsonToken token)
		{
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x00007278 File Offset: 0x00005478
		[Token(Token = "0x170002B3")]
		public override BsonType Type
		{
			[Token(Token = "0x6001005")]
			[Address(RVA = "0x260CBD0", Offset = "0x260B1D0", VA = "0x18260CBD0", Slot = "4")]
			get
			{
				return (BsonType)0;
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x260CBE0", Offset = "0x260B1E0", VA = "0x18260CBE0", Slot = "5")]
		public IEnumerator<BsonProperty> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x260CCC0", Offset = "0x260B2C0", VA = "0x18260CCC0", Slot = "6")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001008")]
		[Address(RVA = "0x260CCD0", Offset = "0x260B2D0", VA = "0x18260CCD0")]
		public BsonObject()
		{
		}

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<BsonProperty> _children;
	}
}

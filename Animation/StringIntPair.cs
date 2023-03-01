using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008B4 RID: 2228
	[Token(Token = "0x20008B4")]
	[Serializable]
	public class StringIntPair
	{
		// Token: 0x06003C11 RID: 15377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C11")]
		[Address(RVA = "0x6AD9D0", Offset = "0x6AC9D0", VA = "0x1806AD9D0")]
		public StringIntPair(string stringValue, int intValue)
		{
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06003C12 RID: 15378 RVA: 0x00011790 File Offset: 0x0000F990
		[Token(Token = "0x17000760")]
		public int IntValue
		{
			[Token(Token = "0x6003C12")]
			[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06003C13 RID: 15379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000761")]
		public string StringValue
		{
			[Token(Token = "0x6003C13")]
			[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04004055 RID: 16469
		[Token(Token = "0x4004055")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _string;

		// Token: 0x04004056 RID: 16470
		[Token(Token = "0x4004056")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _int;
	}
}

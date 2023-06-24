using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000926 RID: 2342
	[Token(Token = "0x2000926")]
	[Serializable]
	public class StringIntPair
	{
		// Token: 0x06004342 RID: 17218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004342")]
		[Address(RVA = "0x753680", Offset = "0x751C80", VA = "0x180753680")]
		public StringIntPair(string stringValue, int intValue)
		{
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06004343 RID: 17219 RVA: 0x00014628 File Offset: 0x00012828
		[Token(Token = "0x17000885")]
		public int IntValue
		{
			[Token(Token = "0x6004343")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06004344 RID: 17220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000886")]
		public string StringValue
		{
			[Token(Token = "0x6004344")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x04004684 RID: 18052
		[Token(Token = "0x4004684")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _string;

		// Token: 0x04004685 RID: 18053
		[Token(Token = "0x4004685")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _int;
	}
}

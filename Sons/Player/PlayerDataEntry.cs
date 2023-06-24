using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Player
{
	// Token: 0x0200065E RID: 1630
	[Token(Token = "0x200065E")]
	[Serializable]
	public class PlayerDataEntry
	{
		// Token: 0x06002A4A RID: 10826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4A")]
		[Address(RVA = "0x33F9D40", Offset = "0x33F8340", VA = "0x1833F9D40")]
		public PlayerDataEntry(string key, bool value)
		{
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		[Token(Token = "0x17000589")]
		public bool IsBool
		{
			[Token(Token = "0x6002A4B")]
			[Address(RVA = "0x26000D0", Offset = "0x25FE6D0", VA = "0x1826000D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4C")]
		[Address(RVA = "0x33F9DB0", Offset = "0x33F83B0", VA = "0x1833F9DB0")]
		public void SetBool(bool value)
		{
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		[Token(Token = "0x6002A4D")]
		[Address(RVA = "0x33F9E40", Offset = "0x33F8440", VA = "0x1833F9E40")]
		public bool GetBool(bool defaultValue = false)
		{
			return default(bool);
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x0000C708 File Offset: 0x0000A908
		[Token(Token = "0x6002A4E")]
		[Address(RVA = "0xA6DE70", Offset = "0xA6C470", VA = "0x180A6DE70")]
		public bool Matches(string key)
		{
			return default(bool);
		}

		// Token: 0x04002595 RID: 9621
		[Token(Token = "0x4002595")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _key;

		// Token: 0x04002596 RID: 9622
		[Token(Token = "0x4002596")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _boolValue;

		// Token: 0x04002597 RID: 9623
		[Token(Token = "0x4002597")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _isBool;
	}
}

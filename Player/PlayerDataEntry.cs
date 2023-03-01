using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Player
{
	// Token: 0x02000753 RID: 1875
	[Token(Token = "0x2000753")]
	[Serializable]
	public class PlayerDataEntry
	{
		// Token: 0x060030D9 RID: 12505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030D9")]
		[Address(RVA = "0x2E4CDF0", Offset = "0x2E4BDF0", VA = "0x182E4CDF0")]
		public PlayerDataEntry(string key, bool value)
		{
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060030DA RID: 12506 RVA: 0x0000DE30 File Offset: 0x0000C030
		[Token(Token = "0x1700061E")]
		public bool IsBool
		{
			[Token(Token = "0x60030DA")]
			[Address(RVA = "0x21F5130", Offset = "0x21F4130", VA = "0x1821F5130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030DB")]
		[Address(RVA = "0x2E4CD60", Offset = "0x2E4BD60", VA = "0x182E4CD60")]
		public void SetBool(bool value)
		{
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x0000DE48 File Offset: 0x0000C048
		[Token(Token = "0x60030DC")]
		[Address(RVA = "0x2E4CCC0", Offset = "0x2E4BCC0", VA = "0x182E4CCC0")]
		public bool GetBool(bool defaultValue = false)
		{
			return default(bool);
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x0000DE60 File Offset: 0x0000C060
		[Token(Token = "0x60030DD")]
		[Address(RVA = "0x909E40", Offset = "0x908E40", VA = "0x180909E40")]
		public bool Matches(string key)
		{
			return default(bool);
		}

		// Token: 0x04002AC5 RID: 10949
		[Token(Token = "0x4002AC5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _key;

		// Token: 0x04002AC6 RID: 10950
		[Token(Token = "0x4002AC6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _boolValue;

		// Token: 0x04002AC7 RID: 10951
		[Token(Token = "0x4002AC7")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _isBool;
	}
}

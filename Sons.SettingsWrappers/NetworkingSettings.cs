using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Settings
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public class NetworkingSettings : MonoBehaviour
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public NetworkingSettings()
		{
		}

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		public const string ConnectionTimeoutSettingKey = "Networking.ConnectionTimeout";

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		public const string ConnectionRequestAttemptsSettingKey = "Networking.ConnectionRequestAttempts";

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		public const string ConnectionRequestTimeoutSettingKey = "Networking.ConnectionRequestTimeout";

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		public const int ConnectionTimeoutDefault = 90000;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		public const int ConnectionRequestAttemptsDefault = 60;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		public const int ConnectionRequestTimeoutDefault = 1000;
	}
}

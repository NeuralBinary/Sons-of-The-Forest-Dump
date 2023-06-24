using System;
using Il2CppDummyDll;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000029")]
public enum BoltNetworkModes
{
	// Token: 0x040000CC RID: 204
	[Token(Token = "0x40000CC")]
	None,
	// Token: 0x040000CD RID: 205
	[Token(Token = "0x40000CD")]
	Host,
	// Token: 0x040000CE RID: 206
	[Token(Token = "0x40000CE")]
	[Obsolete("Use BoltNetworkModes.Host instead")]
	Server = 1,
	// Token: 0x040000CF RID: 207
	[Token(Token = "0x40000CF")]
	Client,
	// Token: 0x040000D0 RID: 208
	[Token(Token = "0x40000D0")]
	Shutdown
}

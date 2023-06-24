using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public interface ISimpleUnderwaterData
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1
	[Token(Token = "0x17000001")]
	Material WaterSurfaceMaterial { [Token(Token = "0x6000001")] get; }

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000002 RID: 2
	[Token(Token = "0x17000002")]
	bool UseWaterHeight { [Token(Token = "0x6000002")] get; }
}

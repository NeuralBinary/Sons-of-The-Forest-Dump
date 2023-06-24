using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000024 RID: 36
[Token(Token = "0x2000024")]
public interface IWeaponFire : IState, IDisposable
{
	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060000C1 RID: 193
	// (set) Token: 0x060000C2 RID: 194
	[Token(Token = "0x1700004E")]
	BoltEntity TargetPlayer { [Token(Token = "0x60000C1")] get; [Token(Token = "0x60000C2")] set; }

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060000C3 RID: 195
	// (set) Token: 0x060000C4 RID: 196
	[Token(Token = "0x1700004F")]
	Vector3 Position { [Token(Token = "0x60000C3")] get; [Token(Token = "0x60000C4")] set; }

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060000C5 RID: 197
	// (set) Token: 0x060000C6 RID: 198
	[Token(Token = "0x17000050")]
	Quaternion Rotation { [Token(Token = "0x60000C5")] get; [Token(Token = "0x60000C6")] set; }
}

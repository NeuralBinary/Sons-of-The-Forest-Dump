using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AB RID: 171
[Token(Token = "0x20000AB")]
public interface IProjectileState : IRigidbodyState, IState, IDisposable
{
	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x060007B9 RID: 1977
	// (set) Token: 0x060007BA RID: 1978
	[Token(Token = "0x17000442")]
	bool StickToTarget { [Token(Token = "0x60007B9")] get; [Token(Token = "0x60007BA")] set; }

	// Token: 0x17000443 RID: 1091
	// (get) Token: 0x060007BB RID: 1979
	// (set) Token: 0x060007BC RID: 1980
	[Token(Token = "0x17000443")]
	BoltEntity ParentEntity { [Token(Token = "0x60007BB")] get; [Token(Token = "0x60007BC")] set; }

	// Token: 0x17000444 RID: 1092
	// (get) Token: 0x060007BD RID: 1981
	[Token(Token = "0x17000444")]
	NetworkArray_Integer ChildIndexTraversal { [Token(Token = "0x60007BD")] get; }

	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x060007BE RID: 1982
	// (set) Token: 0x060007BF RID: 1983
	[Token(Token = "0x17000445")]
	Quaternion ParentOffsetRot { [Token(Token = "0x60007BE")] get; [Token(Token = "0x60007BF")] set; }

	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x060007C0 RID: 1984
	// (set) Token: 0x060007C1 RID: 1985
	[Token(Token = "0x17000446")]
	Vector3 ParentOffsetPos { [Token(Token = "0x60007C0")] get; [Token(Token = "0x60007C1")] set; }
}

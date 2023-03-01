using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009B RID: 155
[Token(Token = "0x200009B")]
public class FollowPlayer : MonoBehaviour
{
	// Token: 0x06000523 RID: 1315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000523")]
	[Address(RVA = "0x2D50D40", Offset = "0x2D4FD40", VA = "0x182D50D40")]
	private void Start()
	{
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000524")]
	[Address(RVA = "0x2D50D90", Offset = "0x2D4FD90", VA = "0x182D50D90")]
	private void Update()
	{
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000525")]
	[Address(RVA = "0x2D50E30", Offset = "0x2D4FE30", VA = "0x182D50E30")]
	public FollowPlayer()
	{
	}

	// Token: 0x040004C4 RID: 1220
	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_player;

	// Token: 0x040004C5 RID: 1221
	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 uvOffset;

	// Token: 0x040004C6 RID: 1222
	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 uvAnimationRate;

	// Token: 0x040004C7 RID: 1223
	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 lastPos;

	// Token: 0x040004C8 RID: 1224
	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 currPos;

	// Token: 0x040004C9 RID: 1225
	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 viewDir;

	// Token: 0x040004CA RID: 1226
	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 moveDir;

	// Token: 0x040004CB RID: 1227
	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 targetSideDir;

	// Token: 0x040004CC RID: 1228
	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x6C")]
	public float strafe;
}

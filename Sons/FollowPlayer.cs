using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009B RID: 155
[Token(Token = "0x200009B")]
public class FollowPlayer : MonoBehaviour
{
	// Token: 0x0600054D RID: 1357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054D")]
	[Address(RVA = "0x3501310", Offset = "0x34FF910", VA = "0x183501310")]
	private void Start()
	{
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054E")]
	[Address(RVA = "0x35013F0", Offset = "0x34FF9F0", VA = "0x1835013F0")]
	private void Update()
	{
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054F")]
	[Address(RVA = "0x3501590", Offset = "0x34FFB90", VA = "0x183501590")]
	public FollowPlayer()
	{
	}

	// Token: 0x040004E1 RID: 1249
	[Token(Token = "0x40004E1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_player;

	// Token: 0x040004E2 RID: 1250
	[Token(Token = "0x40004E2")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 uvOffset;

	// Token: 0x040004E3 RID: 1251
	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 uvAnimationRate;

	// Token: 0x040004E4 RID: 1252
	[Token(Token = "0x40004E4")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 lastPos;

	// Token: 0x040004E5 RID: 1253
	[Token(Token = "0x40004E5")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 currPos;

	// Token: 0x040004E6 RID: 1254
	[Token(Token = "0x40004E6")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 viewDir;

	// Token: 0x040004E7 RID: 1255
	[Token(Token = "0x40004E7")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 moveDir;

	// Token: 0x040004E8 RID: 1256
	[Token(Token = "0x40004E8")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 targetSideDir;

	// Token: 0x040004E9 RID: 1257
	[Token(Token = "0x40004E9")]
	[FieldOffset(Offset = "0x6C")]
	public float strafe;
}

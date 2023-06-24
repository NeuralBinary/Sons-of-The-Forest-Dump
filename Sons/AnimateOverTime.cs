using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public class AnimateOverTime : MonoBehaviour
{
	// Token: 0x06000014 RID: 20 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2F63000", Offset = "0x2F61600", VA = "0x182F63000")]
	private void Awake()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2F63130", Offset = "0x2F61730", VA = "0x182F63130")]
	private void Update()
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2F63380", Offset = "0x2F61980", VA = "0x182F63380")]
	public AnimateOverTime()
	{
	}

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 _startPosition;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x2C")]
	private float _randomness;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 _moveAmount;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _randomAmount;
}

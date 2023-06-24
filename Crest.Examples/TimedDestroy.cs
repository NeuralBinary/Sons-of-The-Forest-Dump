using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
public class TimedDestroy : MonoBehaviour
{
	// Token: 0x0600001D RID: 29 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x9F3990", Offset = "0x9F1F90", VA = "0x1809F3990")]
	private void Start()
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x9F3AB0", Offset = "0x9F20B0", VA = "0x1809F3AB0")]
	private void Update()
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x9F3D80", Offset = "0x9F2380", VA = "0x1809F3D80")]
	public TimedDestroy()
	{
	}

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x20")]
	public float m_lifeTime;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x24")]
	public float m_scaleToZeroDuration;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_scale;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x34")]
	private float m_birthTime;
}

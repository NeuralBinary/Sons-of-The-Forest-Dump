using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000280 RID: 640
[Token(Token = "0x2000280")]
[Serializable]
public class TimedExplosive : MonoBehaviour
{
	// Token: 0x0600109B RID: 4251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109B")]
	[Address(RVA = "0x2FBB5C0", Offset = "0x2FBA5C0", VA = "0x182FBB5C0", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109C")]
	[Address(RVA = "0x2FBB590", Offset = "0x2FBA590", VA = "0x182FBB590", Slot = "5")]
	public virtual void Explode()
	{
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109D")]
	[Address(RVA = "0x2FBB610", Offset = "0x2FBA610", VA = "0x182FBB610")]
	public TimedExplosive()
	{
	}

	// Token: 0x04001020 RID: 4128
	[Token(Token = "0x4001020")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MyExplosion;

	// Token: 0x04001021 RID: 4129
	[Token(Token = "0x4001021")]
	[FieldOffset(Offset = "0x28")]
	public int WaitTime;
}

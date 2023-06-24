using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200027B RID: 635
[Token(Token = "0x200027B")]
[Serializable]
public class TimedExplosive : MonoBehaviour
{
	// Token: 0x060010E9 RID: 4329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E9")]
	[Address(RVA = "0x3740360", Offset = "0x373E960", VA = "0x183740360", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EA")]
	[Address(RVA = "0x37403B0", Offset = "0x373E9B0", VA = "0x1837403B0", Slot = "5")]
	public virtual void Explode()
	{
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EB")]
	[Address(RVA = "0x3740420", Offset = "0x373EA20", VA = "0x183740420")]
	public TimedExplosive()
	{
	}

	// Token: 0x04001046 RID: 4166
	[Token(Token = "0x4001046")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MyExplosion;

	// Token: 0x04001047 RID: 4167
	[Token(Token = "0x4001047")]
	[FieldOffset(Offset = "0x28")]
	public int WaitTime;
}

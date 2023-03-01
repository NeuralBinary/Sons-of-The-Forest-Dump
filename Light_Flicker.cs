using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000214 RID: 532
[Token(Token = "0x2000214")]
[Serializable]
public class Light_Flicker : MonoBehaviour
{
	// Token: 0x06000E18 RID: 3608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E18")]
	[Address(RVA = "0x2F9AAD0", Offset = "0x2F99AD0", VA = "0x182F9AAD0", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E19")]
	[Address(RVA = "0x2F9AA90", Offset = "0x2F99A90", VA = "0x182F9AA90", Slot = "5")]
	public virtual void OneLightChange()
	{
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1A")]
	[Address(RVA = "0x2F9AC40", Offset = "0x2F99C40", VA = "0x182F9AC40", Slot = "6")]
	public virtual void Update()
	{
	}

	// Token: 0x06000E1B RID: 3611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1B")]
	[Address(RVA = "0x2F9AD80", Offset = "0x2F99D80", VA = "0x182F9AD80")]
	public Light_Flicker()
	{
	}

	// Token: 0x04000D2F RID: 3375
	[Token(Token = "0x4000D2F")]
	[FieldOffset(Offset = "0x20")]
	public float time;

	// Token: 0x04000D30 RID: 3376
	[Token(Token = "0x4000D30")]
	[FieldOffset(Offset = "0x24")]
	public float min;

	// Token: 0x04000D31 RID: 3377
	[Token(Token = "0x4000D31")]
	[FieldOffset(Offset = "0x28")]
	public float max;

	// Token: 0x04000D32 RID: 3378
	[Token(Token = "0x4000D32")]
	[FieldOffset(Offset = "0x2C")]
	public bool useSmooth;

	// Token: 0x04000D33 RID: 3379
	[Token(Token = "0x4000D33")]
	[FieldOffset(Offset = "0x30")]
	public float smoothTime;

	// Token: 0x04000D34 RID: 3380
	[Token(Token = "0x4000D34")]
	[FieldOffset(Offset = "0x38")]
	public Light _light;
}

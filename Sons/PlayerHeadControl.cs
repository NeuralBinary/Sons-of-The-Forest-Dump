using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000237 RID: 567
[Token(Token = "0x2000237")]
[Serializable]
public class PlayerHeadControl : MonoBehaviour
{
	// Token: 0x06000FF7 RID: 4087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0x3732920", Offset = "0x3730F20", VA = "0x183732920", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
	public virtual void Start()
	{
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0x3732AF0", Offset = "0x37310F0", VA = "0x183732AF0", Slot = "6")]
	public virtual void LateUpdate()
	{
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public PlayerHeadControl()
	{
	}

	// Token: 0x04000EBD RID: 3773
	[Token(Token = "0x4000EBD")]
	[FieldOffset(Offset = "0x20")]
	private Transform MyTransform;

	// Token: 0x04000EBE RID: 3774
	[Token(Token = "0x4000EBE")]
	[FieldOffset(Offset = "0x28")]
	private Transform Head;
}

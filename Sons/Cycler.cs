using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CA RID: 458
[Token(Token = "0x20001CA")]
[Serializable]
public class Cycler : MonoBehaviour
{
	// Token: 0x06000D50 RID: 3408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D50")]
	[Address(RVA = "0x36FF140", Offset = "0x36FD740", VA = "0x1836FF140", Slot = "4")]
	public virtual void onScrollChangeObject()
	{
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D51")]
	[Address(RVA = "0x36FF540", Offset = "0x36FDB40", VA = "0x1836FF540", Slot = "5")]
	public virtual void Update()
	{
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D52")]
	[Address(RVA = "0x36FF670", Offset = "0x36FDC70", VA = "0x1836FF670", Slot = "6")]
	public virtual void OnGUI()
	{
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D53")]
	[Address(RVA = "0x268E470", Offset = "0x268CA70", VA = "0x18268E470", Slot = "7")]
	public virtual void Start()
	{
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D54")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public Cycler()
	{
	}

	// Token: 0x04000C23 RID: 3107
	[Token(Token = "0x4000C23")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] childObject;

	// Token: 0x04000C24 RID: 3108
	[Token(Token = "0x4000C24")]
	[FieldOffset(Offset = "0x28")]
	public int changeObj;

	// Token: 0x04000C25 RID: 3109
	[Token(Token = "0x4000C25")]
	[FieldOffset(Offset = "0x30")]
	public GameObject currObjAlive;
}

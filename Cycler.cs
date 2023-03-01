using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CB RID: 459
[Token(Token = "0x20001CB")]
[Serializable]
public class Cycler : MonoBehaviour
{
	// Token: 0x06000CF5 RID: 3317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF5")]
	[Address(RVA = "0x2F84520", Offset = "0x2F83520", VA = "0x182F84520", Slot = "4")]
	public virtual void onScrollChangeObject()
	{
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0x2F84460", Offset = "0x2F83460", VA = "0x182F84460", Slot = "5")]
	public virtual void Update()
	{
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x2F842F0", Offset = "0x2F832F0", VA = "0x182F842F0", Slot = "6")]
	public virtual void OnGUI()
	{
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x2258370", Offset = "0x2257370", VA = "0x182258370", Slot = "7")]
	public virtual void Start()
	{
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public Cycler()
	{
	}

	// Token: 0x04000BF4 RID: 3060
	[Token(Token = "0x4000BF4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] childObject;

	// Token: 0x04000BF5 RID: 3061
	[Token(Token = "0x4000BF5")]
	[FieldOffset(Offset = "0x28")]
	public int changeObj;

	// Token: 0x04000BF6 RID: 3062
	[Token(Token = "0x4000BF6")]
	[FieldOffset(Offset = "0x30")]
	public GameObject currObjAlive;
}

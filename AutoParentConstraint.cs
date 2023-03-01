using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
public class AutoParentConstraint : MonoBehaviour
{
	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
	public string GetName()
	{
		return null;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x299C7B0", Offset = "0x299B7B0", VA = "0x18299C7B0")]
	public void SetTarget(Transform target)
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public AutoParentConstraint()
	{
	}

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string _targetName;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ParentConstraint _constraint;
}

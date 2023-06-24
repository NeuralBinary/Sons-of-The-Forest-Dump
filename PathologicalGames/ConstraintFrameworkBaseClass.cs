using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
[AddComponentMenu("")]
[ExecuteInEditMode]
public class ConstraintFrameworkBaseClass : MonoBehaviour
{
	// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x28B2630", Offset = "0x28B0C30", VA = "0x1828B2630", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x7AAC00", Offset = "0x7A9200", VA = "0x1807AAC00", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x28B26E0", Offset = "0x28B0CE0", VA = "0x1828B26E0", Slot = "6")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x28B2760", Offset = "0x28B0D60", VA = "0x1828B2760", Slot = "7")]
	protected virtual void InitConstraint()
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x28B27A0", Offset = "0x28B0DA0", VA = "0x1828B27A0", Slot = "8")]
	protected virtual IEnumerator Constrain()
	{
		return null;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x28B2830", Offset = "0x28B0E30", VA = "0x1828B2830", Slot = "9")]
	protected virtual void OnConstraintUpdate()
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public ConstraintFrameworkBaseClass()
	{
	}

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Transform xform;
}

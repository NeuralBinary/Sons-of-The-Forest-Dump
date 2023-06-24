using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
public class TailRotorSpin : MonoBehaviour
{
	// Token: 0x06000036 RID: 54 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2F65BB0", Offset = "0x2F641B0", VA = "0x182F65BB0")]
	private void Awake()
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2F65C90", Offset = "0x2F64290", VA = "0x182F65C90")]
	private void Update()
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2F65FF0", Offset = "0x2F645F0", VA = "0x182F65FF0")]
	private void ValidateSpin()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2F660F0", Offset = "0x2F646F0", VA = "0x182F660F0")]
	private void ValidateRotationValue(ref float rotationComponent, float maxRotation)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2F66150", Offset = "0x2F64750", VA = "0x182F66150")]
	public void StopRotor()
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public TailRotorSpin()
	{
	}

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	private const float RotationModulo = 360000f;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Quaternion _offset;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("spinAmount")]
	[SerializeField]
	private Vector3 _spinAmount;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 _spin;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x48")]
	private bool _stopping;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x4C")]
	private float _stopSpeed;
}

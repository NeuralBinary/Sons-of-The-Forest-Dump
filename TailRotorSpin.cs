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
	[Address(RVA = "0x29B1B60", Offset = "0x29B0B60", VA = "0x1829B1B60")]
	private void Awake()
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x29B1BA0", Offset = "0x29B0BA0", VA = "0x1829B1BA0")]
	private void Update()
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x29B1E20", Offset = "0x29B0E20", VA = "0x1829B1E20")]
	private void ValidateSpin()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x29B1DC0", Offset = "0x29B0DC0", VA = "0x1829B1DC0")]
	private void ValidateRotationValue(ref float rotationComponent, float maxRotation)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
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
}

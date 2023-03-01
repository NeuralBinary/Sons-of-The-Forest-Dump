using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000230 RID: 560
[Token(Token = "0x2000230")]
public class SimpleMouseRotator : MonoBehaviour
{
	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06000F58 RID: 3928 RVA: 0x00005B38 File Offset: 0x00003D38
	// (set) Token: 0x06000F59 RID: 3929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C7")]
	public bool ResetOriginalRotation
	{
		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x8FF740", Offset = "0x8FE740", VA = "0x1808FF740")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F59")]
		[Address(RVA = "0x8FF760", Offset = "0x8FE760", VA = "0x1808FF760")]
		set
		{
		}
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5A")]
	[Address(RVA = "0x2FA53B0", Offset = "0x2FA43B0", VA = "0x182FA53B0")]
	private void Start()
	{
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5B")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void enableMouse()
	{
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5C")]
	[Address(RVA = "0x2FA58C0", Offset = "0x2FA48C0", VA = "0x182FA58C0")]
	private void Update()
	{
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5D")]
	[Address(RVA = "0x2FA4D90", Offset = "0x2FA3D90", VA = "0x182FA4D90")]
	public void ForceResetRotation()
	{
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5E")]
	[Address(RVA = "0x2FA5300", Offset = "0x2FA4300", VA = "0x182FA5300")]
	public void GrabCurrentRotation()
	{
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5F")]
	[Address(RVA = "0x2FA57C0", Offset = "0x2FA47C0", VA = "0x182FA57C0")]
	private void UpdateRotation()
	{
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F60")]
	[Address(RVA = "0x2FA49E0", Offset = "0x2FA39E0", VA = "0x182FA49E0")]
	private void ApplyInputOffset(Vector2 input)
	{
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x2FA4A10", Offset = "0x2FA3A10", VA = "0x182FA4A10")]
	private void CheckResetOriginalRotation()
	{
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x2FA5470", Offset = "0x2FA4470", VA = "0x182FA5470")]
	private void UpdateCameraRotation(Vector2 modAngles)
	{
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x2FA4C40", Offset = "0x2FA3C40", VA = "0x182FA4C40")]
	private void ClampAngles()
	{
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x00005B50 File Offset: 0x00003D50
	[Token(Token = "0x6000F64")]
	[Address(RVA = "0x2FA4DB0", Offset = "0x2FA3DB0", VA = "0x182FA4DB0")]
	private Vector2 GetInput()
	{
		return default(Vector2);
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x00005B68 File Offset: 0x00003D68
	[Token(Token = "0x6000F65")]
	[Address(RVA = "0x2FA51F0", Offset = "0x2FA41F0", VA = "0x182FA51F0")]
	private float GetLookSensitivityY()
	{
		return default(float);
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x00005B80 File Offset: 0x00003D80
	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x2FA50E0", Offset = "0x2FA40E0", VA = "0x182FA50E0")]
	private float GetLookSensitivityX()
	{
		return default(float);
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x2FA53A0", Offset = "0x2FA43A0", VA = "0x182FA53A0")]
	public void SetTargetAngles(float xAngle, float yAngle)
	{
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F68")]
	[Address(RVA = "0x2FA5380", Offset = "0x2FA4380", VA = "0x182FA5380")]
	public void OffsetTargetAngles(float xAngle, float yAngle)
	{
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F69")]
	[Address(RVA = "0x2FA5360", Offset = "0x2FA4360", VA = "0x182FA5360")]
	public void OffsetFollowAngles(float xAngle, float yAngle)
	{
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x00005B98 File Offset: 0x00003D98
	[Token(Token = "0x6000F6A")]
	[Address(RVA = "0x28B7AE0", Offset = "0x28B6AE0", VA = "0x1828B7AE0")]
	public Vector3 GetFollowAngles()
	{
		return default(Vector3);
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0x2FA58D0", Offset = "0x2FA48D0", VA = "0x182FA58D0")]
	public SimpleMouseRotator()
	{
	}

	// Token: 0x04000E5C RID: 3676
	[Token(Token = "0x4000E5C")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("useRigidbody")]
	public bool _useRigidbody;

	// Token: 0x04000E5D RID: 3677
	[Token(Token = "0x4000E5D")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 rotationRange;

	// Token: 0x04000E5E RID: 3678
	[Token(Token = "0x4000E5E")]
	[FieldOffset(Offset = "0x2C")]
	public float rotationSpeed;

	// Token: 0x04000E5F RID: 3679
	[Token(Token = "0x4000E5F")]
	[FieldOffset(Offset = "0x30")]
	public float dampingTime;

	// Token: 0x04000E60 RID: 3680
	[Token(Token = "0x4000E60")]
	[FieldOffset(Offset = "0x34")]
	public float dampingOverride;

	// Token: 0x04000E61 RID: 3681
	[Token(Token = "0x4000E61")]
	[FieldOffset(Offset = "0x38")]
	public bool lockRotation;

	// Token: 0x04000E62 RID: 3682
	[Token(Token = "0x4000E62")]
	[FieldOffset(Offset = "0x39")]
	public bool fixCameraRotation;

	// Token: 0x04000E63 RID: 3683
	[Token(Token = "0x4000E63")]
	[FieldOffset(Offset = "0x3A")]
	public bool stopInput;

	// Token: 0x04000E64 RID: 3684
	[Token(Token = "0x4000E64")]
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("targetAngles")]
	[SerializeField]
	private Vector3 _targetAngles;

	// Token: 0x04000E65 RID: 3685
	[Token(Token = "0x4000E65")]
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("followAngles")]
	[SerializeField]
	private Vector3 _followAngles;

	// Token: 0x04000E66 RID: 3686
	[Token(Token = "0x4000E66")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool _invertXRotation;

	// Token: 0x04000E67 RID: 3687
	[Token(Token = "0x4000E67")]
	[FieldOffset(Offset = "0x55")]
	[SerializeField]
	private bool _invertYRotation;

	// Token: 0x04000E68 RID: 3688
	[Token(Token = "0x4000E68")]
	[FieldOffset(Offset = "0x56")]
	[SerializeField]
	private bool _assignOriginalRotationFromTransform;

	// Token: 0x04000E69 RID: 3689
	[Token(Token = "0x4000E69")]
	[FieldOffset(Offset = "0x58")]
	public float yOffset;

	// Token: 0x04000E6A RID: 3690
	[Token(Token = "0x4000E6A")]
	[FieldOffset(Offset = "0x5C")]
	public float xOffset;

	// Token: 0x04000E6B RID: 3691
	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0x60")]
	public bool debugEfficiency;

	// Token: 0x04000E6C RID: 3692
	[Token(Token = "0x4000E6C")]
	[FieldOffset(Offset = "0x61")]
	public bool cameraRotator;

	// Token: 0x04000E6D RID: 3693
	[Token(Token = "0x4000E6D")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 _followVelocity;

	// Token: 0x04000E6E RID: 3694
	[Token(Token = "0x4000E6E")]
	[FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("originalRotation")]
	public Quaternion _originalRotation;

	// Token: 0x04000E6F RID: 3695
	[Token(Token = "0x4000E6F")]
	[FieldOffset(Offset = "0x80")]
	public float prevSpeed;

	// Token: 0x04000E70 RID: 3696
	[Token(Token = "0x4000E70")]
	[FieldOffset(Offset = "0x84")]
	public Vector2 prevRange;

	// Token: 0x04000E71 RID: 3697
	[Token(Token = "0x4000E71")]
	[FieldOffset(Offset = "0x90")]
	[FormerlySerializedAs("rb")]
	public Rigidbody _rigidbody;

	// Token: 0x04000E72 RID: 3698
	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[FormerlySerializedAs("resetOriginalRotation")]
	private bool _resetOriginalRotation;
}

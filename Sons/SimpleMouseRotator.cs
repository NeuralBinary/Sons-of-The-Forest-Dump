using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200022F RID: 559
[Token(Token = "0x200022F")]
public class SimpleMouseRotator : MonoBehaviour
{
	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x06000FBE RID: 4030 RVA: 0x00005DF0 File Offset: 0x00003FF0
	// (set) Token: 0x06000FBF RID: 4031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D4")]
	public bool ResetOriginalRotation
	{
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0xA53170", Offset = "0xA51770", VA = "0x180A53170")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0xA53180", Offset = "0xA51780", VA = "0x180A53180")]
		set
		{
		}
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC0")]
	[Address(RVA = "0x372DF30", Offset = "0x372C530", VA = "0x18372DF30")]
	private void Start()
	{
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC1")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void enableMouse()
	{
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC2")]
	[Address(RVA = "0x372E0B0", Offset = "0x372C6B0", VA = "0x18372E0B0")]
	private void Update()
	{
	}

	// Token: 0x06000FC3 RID: 4035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC3")]
	[Address(RVA = "0x372E0C0", Offset = "0x372C6C0", VA = "0x18372E0C0")]
	public void ForceResetRotation()
	{
	}

	// Token: 0x06000FC4 RID: 4036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC4")]
	[Address(RVA = "0x372E0E0", Offset = "0x372C6E0", VA = "0x18372E0E0")]
	public void GrabCurrentRotation()
	{
	}

	// Token: 0x06000FC5 RID: 4037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC5")]
	[Address(RVA = "0x372E1E0", Offset = "0x372C7E0", VA = "0x18372E1E0")]
	private void UpdateRotation()
	{
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0x372E2E0", Offset = "0x372C8E0", VA = "0x18372E2E0")]
	private void ApplyInputOffset(Vector2 input)
	{
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC7")]
	[Address(RVA = "0x372E310", Offset = "0x372C910", VA = "0x18372E310")]
	private void CheckResetOriginalRotation()
	{
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0x372E5D0", Offset = "0x372CBD0", VA = "0x18372E5D0")]
	private void UpdateCameraRotation(Vector2 modAngles)
	{
	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FC9")]
	[Address(RVA = "0x372E900", Offset = "0x372CF00", VA = "0x18372E900")]
	private void ClampAngles()
	{
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x00005E08 File Offset: 0x00004008
	[Token(Token = "0x6000FCA")]
	[Address(RVA = "0x372EA50", Offset = "0x372D050", VA = "0x18372EA50")]
	private Vector2 GetInput()
	{
		return default(Vector2);
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x00005E20 File Offset: 0x00004020
	[Token(Token = "0x6000FCB")]
	[Address(RVA = "0x372ED80", Offset = "0x372D380", VA = "0x18372ED80")]
	private float GetLookSensitivityY()
	{
		return 0f;
	}

	// Token: 0x06000FCC RID: 4044 RVA: 0x00005E38 File Offset: 0x00004038
	[Token(Token = "0x6000FCC")]
	[Address(RVA = "0x372EEA0", Offset = "0x372D4A0", VA = "0x18372EEA0")]
	private float GetLookSensitivityX()
	{
		return 0f;
	}

	// Token: 0x06000FCD RID: 4045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FCD")]
	[Address(RVA = "0x372EF70", Offset = "0x372D570", VA = "0x18372EF70")]
	public void SetTargetAngles(float xAngle, float yAngle)
	{
	}

	// Token: 0x06000FCE RID: 4046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FCE")]
	[Address(RVA = "0x372EF80", Offset = "0x372D580", VA = "0x18372EF80")]
	public void OffsetTargetAngles(float xAngle, float yAngle)
	{
	}

	// Token: 0x06000FCF RID: 4047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FCF")]
	[Address(RVA = "0x372EFA0", Offset = "0x372D5A0", VA = "0x18372EFA0")]
	public void OffsetFollowAngles(float xAngle, float yAngle)
	{
	}

	// Token: 0x06000FD0 RID: 4048 RVA: 0x00005E50 File Offset: 0x00004050
	[Token(Token = "0x6000FD0")]
	[Address(RVA = "0x2DDE4E0", Offset = "0x2DDCAE0", VA = "0x182DDE4E0")]
	public Vector3 GetFollowAngles()
	{
		return default(Vector3);
	}

	// Token: 0x06000FD1 RID: 4049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD1")]
	[Address(RVA = "0x372EFC0", Offset = "0x372D5C0", VA = "0x18372EFC0")]
	public SimpleMouseRotator()
	{
	}

	// Token: 0x04000E91 RID: 3729
	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("useRigidbody")]
	public bool _useRigidbody;

	// Token: 0x04000E92 RID: 3730
	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 rotationRange;

	// Token: 0x04000E93 RID: 3731
	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0x2C")]
	public float rotationSpeed;

	// Token: 0x04000E94 RID: 3732
	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0x30")]
	public float dampingTime;

	// Token: 0x04000E95 RID: 3733
	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x34")]
	public float dampingOverride;

	// Token: 0x04000E96 RID: 3734
	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0x38")]
	public bool lockRotation;

	// Token: 0x04000E97 RID: 3735
	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x39")]
	public bool fixCameraRotation;

	// Token: 0x04000E98 RID: 3736
	[Token(Token = "0x4000E98")]
	[FieldOffset(Offset = "0x3A")]
	public bool stopInput;

	// Token: 0x04000E99 RID: 3737
	[Token(Token = "0x4000E99")]
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("targetAngles")]
	[SerializeField]
	private Vector3 _targetAngles;

	// Token: 0x04000E9A RID: 3738
	[Token(Token = "0x4000E9A")]
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("followAngles")]
	[SerializeField]
	private Vector3 _followAngles;

	// Token: 0x04000E9B RID: 3739
	[Token(Token = "0x4000E9B")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool _invertXRotation;

	// Token: 0x04000E9C RID: 3740
	[Token(Token = "0x4000E9C")]
	[FieldOffset(Offset = "0x55")]
	[SerializeField]
	private bool _invertYRotation;

	// Token: 0x04000E9D RID: 3741
	[Token(Token = "0x4000E9D")]
	[FieldOffset(Offset = "0x56")]
	[SerializeField]
	private bool _assignOriginalRotationFromTransform;

	// Token: 0x04000E9E RID: 3742
	[Token(Token = "0x4000E9E")]
	[FieldOffset(Offset = "0x58")]
	public float yOffset;

	// Token: 0x04000E9F RID: 3743
	[Token(Token = "0x4000E9F")]
	[FieldOffset(Offset = "0x5C")]
	public float xOffset;

	// Token: 0x04000EA0 RID: 3744
	[Token(Token = "0x4000EA0")]
	[FieldOffset(Offset = "0x60")]
	public bool debugEfficiency;

	// Token: 0x04000EA1 RID: 3745
	[Token(Token = "0x4000EA1")]
	[FieldOffset(Offset = "0x61")]
	public bool cameraRotator;

	// Token: 0x04000EA2 RID: 3746
	[Token(Token = "0x4000EA2")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 _followVelocity;

	// Token: 0x04000EA3 RID: 3747
	[Token(Token = "0x4000EA3")]
	[FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("originalRotation")]
	public Quaternion _originalRotation;

	// Token: 0x04000EA4 RID: 3748
	[Token(Token = "0x4000EA4")]
	[FieldOffset(Offset = "0x80")]
	public float prevSpeed;

	// Token: 0x04000EA5 RID: 3749
	[Token(Token = "0x4000EA5")]
	[FieldOffset(Offset = "0x84")]
	public Vector2 prevRange;

	// Token: 0x04000EA6 RID: 3750
	[Token(Token = "0x4000EA6")]
	[FieldOffset(Offset = "0x90")]
	[FormerlySerializedAs("rb")]
	public Rigidbody _rigidbody;

	// Token: 0x04000EA7 RID: 3751
	[Token(Token = "0x4000EA7")]
	[FieldOffset(Offset = "0x98")]
	[FormerlySerializedAs("resetOriginalRotation")]
	[SerializeField]
	private bool _resetOriginalRotation;
}

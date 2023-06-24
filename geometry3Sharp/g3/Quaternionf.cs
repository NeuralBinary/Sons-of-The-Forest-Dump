using System;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x020001EF RID: 495
	[Token(Token = "0x20001EF")]
	public struct Quaternionf : IComparable<Quaternionf>, IEquatable<Quaternionf>
	{
		// Token: 0x06001016 RID: 4118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001016")]
		[Address(RVA = "0x1E1F030", Offset = "0x1E1D630", VA = "0x181E1F030")]
		public Quaternionf(float x, float y, float z, float w)
		{
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x1E1F140", Offset = "0x1E1D740", VA = "0x181E1F140")]
		public Quaternionf(float[] v2)
		{
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001018")]
		[Address(RVA = "0x1E1F190", Offset = "0x1E1D790", VA = "0x181E1F190")]
		public Quaternionf(Quaternionf q2)
		{
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001019")]
		[Address(RVA = "0x1E3F830", Offset = "0x1E3DE30", VA = "0x181E3F830")]
		public Quaternionf(Vector3f axis, float AngleDeg)
		{
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600101A")]
		[Address(RVA = "0x1E3F870", Offset = "0x1E3DE70", VA = "0x181E3F870")]
		public Quaternionf(Vector3f vFrom, Vector3f vTo)
		{
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x1E3F8C0", Offset = "0x1E3DEC0", VA = "0x181E3F8C0")]
		public Quaternionf(Quaternionf p, Quaternionf q, float t)
		{
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600101C")]
		[Address(RVA = "0x1E3F900", Offset = "0x1E3DF00", VA = "0x181E3F900")]
		public Quaternionf(Matrix3f mat)
		{
		}

		// Token: 0x17000296 RID: 662
		[Token(Token = "0x17000296")]
		public float this[int key]
		{
			[Token(Token = "0x600101D")]
			[Address(RVA = "0x1E1F1F0", Offset = "0x1E1D7F0", VA = "0x181E1F1F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600101E")]
			[Address(RVA = "0x1E1F220", Offset = "0x1E1D820", VA = "0x181E1F220")]
			set
			{
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x0000C08C File Offset: 0x0000A28C
		[Token(Token = "0x17000297")]
		public float LengthSquared
		{
			[Token(Token = "0x600101F")]
			[Address(RVA = "0x1E3F940", Offset = "0x1E3DF40", VA = "0x181E3F940")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		[Token(Token = "0x17000298")]
		public float Length
		{
			[Token(Token = "0x6001020")]
			[Address(RVA = "0x1E3F970", Offset = "0x1E3DF70", VA = "0x181E3F970")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0000C0BC File Offset: 0x0000A2BC
		[Token(Token = "0x6001021")]
		[Address(RVA = "0x1E3FA40", Offset = "0x1E3E040", VA = "0x181E3FA40")]
		public float Normalize(float epsilon = 0f)
		{
			return 0f;
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		[Token(Token = "0x17000299")]
		public Quaternionf Normalized
		{
			[Token(Token = "0x6001022")]
			[Address(RVA = "0x1E3FAA0", Offset = "0x1E3E0A0", VA = "0x181E3FAA0")]
			get
			{
				return default(Quaternionf);
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		[Token(Token = "0x6001023")]
		[Address(RVA = "0xCA5AF0", Offset = "0xCA40F0", VA = "0x180CA5AF0")]
		public float Dot(Quaternionf q2)
		{
			return 0f;
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0000C104 File Offset: 0x0000A304
		[Token(Token = "0x6001024")]
		[Address(RVA = "0x1E3FB20", Offset = "0x1E3E120", VA = "0x181E3FB20")]
		public static Quaternionf operator *(Quaternionf a, Quaternionf b)
		{
			return default(Quaternionf);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0000C11C File Offset: 0x0000A31C
		[Token(Token = "0x6001025")]
		[Address(RVA = "0x1E1F460", Offset = "0x1E1DA60", VA = "0x181E1F460")]
		public static Quaternionf operator -(Quaternionf q1, Quaternionf q2)
		{
			return default(Quaternionf);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0000C134 File Offset: 0x0000A334
		[Token(Token = "0x6001026")]
		[Address(RVA = "0x1E3FC60", Offset = "0x1E3E260", VA = "0x181E3FC60")]
		public static Vector3f operator *(Quaternionf q, Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0000C14C File Offset: 0x0000A34C
		[Token(Token = "0x6001027")]
		[Address(RVA = "0x1E3FE00", Offset = "0x1E3E400", VA = "0x181E3FE00")]
		public static Vector3d operator *(Quaternionf q, Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0000C164 File Offset: 0x0000A364
		[Token(Token = "0x6001028")]
		[Address(RVA = "0x1E40010", Offset = "0x1E3E610", VA = "0x181E40010")]
		public Vector3f InverseMultiply(ref Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0000C17C File Offset: 0x0000A37C
		[Token(Token = "0x6001029")]
		[Address(RVA = "0x1E402A0", Offset = "0x1E3E8A0", VA = "0x181E402A0")]
		public Vector3d InverseMultiply(ref Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x0000C194 File Offset: 0x0000A394
		[Token(Token = "0x1700029A")]
		public Vector3f AxisX
		{
			[Token(Token = "0x600102A")]
			[Address(RVA = "0x1E405B0", Offset = "0x1E3EBB0", VA = "0x181E405B0")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x0000C1AC File Offset: 0x0000A3AC
		[Token(Token = "0x1700029B")]
		public Vector3f AxisY
		{
			[Token(Token = "0x600102B")]
			[Address(RVA = "0x1E40620", Offset = "0x1E3EC20", VA = "0x181E40620")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x0000C1C4 File Offset: 0x0000A3C4
		[Token(Token = "0x1700029C")]
		public Vector3f AxisZ
		{
			[Token(Token = "0x600102C")]
			[Address(RVA = "0x1E406B0", Offset = "0x1E3ECB0", VA = "0x181E406B0")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0000C1DC File Offset: 0x0000A3DC
		[Token(Token = "0x600102D")]
		[Address(RVA = "0x1E40750", Offset = "0x1E3ED50", VA = "0x181E40750")]
		public Quaternionf Inverse()
		{
			return default(Quaternionf);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0000C1F4 File Offset: 0x0000A3F4
		[Token(Token = "0x600102E")]
		[Address(RVA = "0x1E40860", Offset = "0x1E3EE60", VA = "0x181E40860")]
		public static Quaternionf Inverse(Quaternionf q)
		{
			return default(Quaternionf);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0000C20C File Offset: 0x0000A40C
		[Token(Token = "0x600102F")]
		[Address(RVA = "0x1E40890", Offset = "0x1E3EE90", VA = "0x181E40890")]
		public Matrix3f ToRotationMatrix()
		{
			return default(Matrix3f);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001030")]
		[Address(RVA = "0x1E40A70", Offset = "0x1E3F070", VA = "0x181E40A70")]
		public void SetAxisAngleD(Vector3f axis, float AngleDeg)
		{
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0000C224 File Offset: 0x0000A424
		[Token(Token = "0x6001031")]
		[Address(RVA = "0x1E40B50", Offset = "0x1E3F150", VA = "0x181E40B50")]
		public static Quaternionf AxisAngleD(Vector3f axis, float angleDeg)
		{
			return default(Quaternionf);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0000C23C File Offset: 0x0000A43C
		[Token(Token = "0x6001032")]
		[Address(RVA = "0x1E40B90", Offset = "0x1E3F190", VA = "0x181E40B90")]
		public static Quaternionf AxisAngleR(Vector3f axis, float angleRad)
		{
			return default(Quaternionf);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001033")]
		[Address(RVA = "0x1E40BE0", Offset = "0x1E3F1E0", VA = "0x181E40BE0")]
		public void SetFromTo(Vector3f vFrom, Vector3f vTo)
		{
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0000C254 File Offset: 0x0000A454
		[Token(Token = "0x6001034")]
		[Address(RVA = "0x1E40FD0", Offset = "0x1E3F5D0", VA = "0x181E40FD0")]
		public static Quaternionf FromTo(Vector3f vFrom, Vector3f vTo)
		{
			return default(Quaternionf);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0000C26C File Offset: 0x0000A46C
		[Token(Token = "0x6001035")]
		[Address(RVA = "0x1E41030", Offset = "0x1E3F630", VA = "0x181E41030")]
		public static Quaternionf FromToConstrained(Vector3f vFrom, Vector3f vTo, Vector3f vAround)
		{
			return default(Quaternionf);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001036")]
		[Address(RVA = "0x1E411F0", Offset = "0x1E3F7F0", VA = "0x181E411F0")]
		public void SetToSlerp(Quaternionf p, Quaternionf q, float t)
		{
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0000C284 File Offset: 0x0000A484
		[Token(Token = "0x6001037")]
		[Address(RVA = "0x1E41410", Offset = "0x1E3FA10", VA = "0x181E41410")]
		public static Quaternionf Slerp(Quaternionf p, Quaternionf q, float t)
		{
			return default(Quaternionf);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001038")]
		[Address(RVA = "0x1E41460", Offset = "0x1E3FA60", VA = "0x181E41460")]
		public void SetFromRotationMatrix(Matrix3f rot)
		{
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0000C29C File Offset: 0x0000A49C
		[Token(Token = "0x6001039")]
		[Address(RVA = "0x1E1F4F0", Offset = "0x1E1DAF0", VA = "0x181E1F4F0")]
		public static bool operator ==(Quaternionf a, Quaternionf b)
		{
			return default(bool);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0000C2B4 File Offset: 0x0000A4B4
		[Token(Token = "0x600103A")]
		[Address(RVA = "0x8DB570", Offset = "0x8D9B70", VA = "0x1808DB570")]
		public static bool operator !=(Quaternionf a, Quaternionf b)
		{
			return default(bool);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0000C2CC File Offset: 0x0000A4CC
		[Token(Token = "0x600103B")]
		[Address(RVA = "0x1E41A60", Offset = "0x1E40060", VA = "0x181E41A60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
		[Token(Token = "0x600103C")]
		[Address(RVA = "0x1E41B40", Offset = "0x1E40140", VA = "0x181E41B40", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		[Token(Token = "0x600103D")]
		[Address(RVA = "0x1E1F650", Offset = "0x1E1DC50", VA = "0x181E1F650", Slot = "4")]
		public int CompareTo(Quaternionf other)
		{
			return 0;
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0000C314 File Offset: 0x0000A514
		[Token(Token = "0x600103E")]
		[Address(RVA = "0x1E1F4F0", Offset = "0x1E1DAF0", VA = "0x181E1F4F0", Slot = "5")]
		public bool Equals(Quaternionf other)
		{
			return default(bool);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0000C32C File Offset: 0x0000A52C
		[Token(Token = "0x600103F")]
		[Address(RVA = "0x1E41C00", Offset = "0x1E40200", VA = "0x181E41C00")]
		public bool EpsilonEqual(Quaternionf q2, float epsilon)
		{
			return default(bool);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001040")]
		[Address(RVA = "0x1E41D10", Offset = "0x1E40310", VA = "0x181E41D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001041")]
		[Address(RVA = "0x1E41F10", Offset = "0x1E40510", VA = "0x181E41F10")]
		public string ToString(string fmt)
		{
			return null;
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0000C344 File Offset: 0x0000A544
		[Token(Token = "0x6001042")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public static implicit operator Quaternionf(Quaternion q)
		{
			return default(Quaternionf);
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0000C35C File Offset: 0x0000A55C
		[Token(Token = "0x6001043")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public static implicit operator Quaternion(Quaternionf q)
		{
			return default(Quaternion);
		}

		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0xC")]
		public float w;

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Quaternionf Zero;

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Quaternionf Identity;
	}
}

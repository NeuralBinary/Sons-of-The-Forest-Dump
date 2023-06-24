using System;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x020001EE RID: 494
	[Token(Token = "0x20001EE")]
	public struct Quaterniond
	{
		// Token: 0x06000FE8 RID: 4072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x1E3D500", Offset = "0x1E3BB00", VA = "0x181E3D500")]
		public Quaterniond(double x, double y, double z, double w)
		{
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0x1E3D520", Offset = "0x1E3BB20", VA = "0x181E3D520")]
		public Quaterniond(double[] v2)
		{
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0x1E3D580", Offset = "0x1E3BB80", VA = "0x181E3D580")]
		public Quaterniond(Quaterniond q2)
		{
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0x1E3D5A0", Offset = "0x1E3BBA0", VA = "0x181E3D5A0")]
		public Quaterniond(Vector3d axis, double AngleDeg)
		{
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x1E3D5F0", Offset = "0x1E3BBF0", VA = "0x181E3D5F0")]
		public Quaterniond(Vector3d vFrom, Vector3d vTo)
		{
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FED")]
		[Address(RVA = "0x1E3D650", Offset = "0x1E3BC50", VA = "0x181E3D650")]
		public Quaterniond(Quaterniond p, Quaterniond q, double t)
		{
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x1E3D6B0", Offset = "0x1E3BCB0", VA = "0x181E3D6B0")]
		public Quaterniond(Matrix3d mat)
		{
		}

		// Token: 0x1700028F RID: 655
		[Token(Token = "0x1700028F")]
		public double this[int key]
		{
			[Token(Token = "0x6000FEF")]
			[Address(RVA = "0x1E3D710", Offset = "0x1E3BD10", VA = "0x181E3D710")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000FF0")]
			[Address(RVA = "0x1E3D740", Offset = "0x1E3BD40", VA = "0x181E3D740")]
			set
			{
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0000BDBC File Offset: 0x00009FBC
		[Token(Token = "0x17000290")]
		public double LengthSquared
		{
			[Token(Token = "0x6000FF1")]
			[Address(RVA = "0x1E3D770", Offset = "0x1E3BD70", VA = "0x181E3D770")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0000BDD4 File Offset: 0x00009FD4
		[Token(Token = "0x17000291")]
		public double Length
		{
			[Token(Token = "0x6000FF2")]
			[Address(RVA = "0x1E3D7A0", Offset = "0x1E3BDA0", VA = "0x181E3D7A0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0000BDEC File Offset: 0x00009FEC
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x1E3D860", Offset = "0x1E3BE60", VA = "0x181E3D860")]
		public double Normalize(double epsilon = 0.0)
		{
			return 0.0;
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0000BE04 File Offset: 0x0000A004
		[Token(Token = "0x17000292")]
		public Quaterniond Normalized
		{
			[Token(Token = "0x6000FF4")]
			[Address(RVA = "0x1E3D8E0", Offset = "0x1E3BEE0", VA = "0x181E3D8E0")]
			get
			{
				return default(Quaterniond);
			}
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0000BE1C File Offset: 0x0000A01C
		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x1E3D930", Offset = "0x1E3BF30", VA = "0x181E3D930")]
		public double Dot(Quaterniond q2)
		{
			return 0.0;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0000BE34 File Offset: 0x0000A034
		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0x1E3D970", Offset = "0x1E3BF70", VA = "0x181E3D970")]
		public static Quaterniond operator -(Quaterniond q2)
		{
			return default(Quaterniond);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0000BE4C File Offset: 0x0000A04C
		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0x1E3D990", Offset = "0x1E3BF90", VA = "0x181E3D990")]
		public static Quaterniond operator *(Quaterniond a, Quaterniond b)
		{
			return default(Quaterniond);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0000BE64 File Offset: 0x0000A064
		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x1E3DB80", Offset = "0x1E3C180", VA = "0x181E3DB80")]
		public static Quaterniond operator *(Quaterniond q1, double d)
		{
			return default(Quaterniond);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0000BE7C File Offset: 0x0000A07C
		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0x1E3DBA0", Offset = "0x1E3C1A0", VA = "0x181E3DBA0")]
		public static Quaterniond operator *(double d, Quaterniond q1)
		{
			return default(Quaterniond);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0000BE94 File Offset: 0x0000A094
		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x1E3DBC0", Offset = "0x1E3C1C0", VA = "0x181E3DBC0")]
		public static Quaterniond operator -(Quaterniond q1, Quaterniond q2)
		{
			return default(Quaterniond);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0000BEAC File Offset: 0x0000A0AC
		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x1E3DC10", Offset = "0x1E3C210", VA = "0x181E3DC10")]
		public static Quaterniond operator +(Quaterniond q1, Quaterniond q2)
		{
			return default(Quaterniond);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x1E3DC60", Offset = "0x1E3C260", VA = "0x181E3DC60")]
		public static Vector3d operator *(Quaterniond q, Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x0000BEDC File Offset: 0x0000A0DC
		[Token(Token = "0x17000293")]
		public Vector3d AxisX
		{
			[Token(Token = "0x6000FFD")]
			[Address(RVA = "0x1E3DE60", Offset = "0x1E3C460", VA = "0x181E3DE60")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
		[Token(Token = "0x17000294")]
		public Vector3d AxisY
		{
			[Token(Token = "0x6000FFE")]
			[Address(RVA = "0x1E3DED0", Offset = "0x1E3C4D0", VA = "0x181E3DED0")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x0000BF0C File Offset: 0x0000A10C
		[Token(Token = "0x17000295")]
		public Vector3d AxisZ
		{
			[Token(Token = "0x6000FFF")]
			[Address(RVA = "0x1E3DF60", Offset = "0x1E3C560", VA = "0x181E3DF60")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0000BF24 File Offset: 0x0000A124
		[Token(Token = "0x6001000")]
		[Address(RVA = "0x1E3E000", Offset = "0x1E3C600", VA = "0x181E3E000")]
		public Quaterniond Inverse()
		{
			return default(Quaterniond);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0000BF3C File Offset: 0x0000A13C
		[Token(Token = "0x6001001")]
		[Address(RVA = "0x1E3E110", Offset = "0x1E3C710", VA = "0x181E3E110")]
		public static Quaterniond Inverse(Quaterniond q)
		{
			return default(Quaterniond);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0000BF54 File Offset: 0x0000A154
		[Token(Token = "0x6001002")]
		[Address(RVA = "0x1E3E140", Offset = "0x1E3C740", VA = "0x181E3E140")]
		public Quaterniond Conjugate()
		{
			return default(Quaterniond);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0000BF6C File Offset: 0x0000A16C
		[Token(Token = "0x6001003")]
		[Address(RVA = "0x1E3E170", Offset = "0x1E3C770", VA = "0x181E3E170")]
		public Matrix3d ToRotationMatrix()
		{
			return default(Matrix3d);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x1E3E2D0", Offset = "0x1E3C8D0", VA = "0x181E3E2D0")]
		public void SetAxisAngleD(Vector3d axis, double AngleDeg)
		{
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0000BF84 File Offset: 0x0000A184
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x1E3E390", Offset = "0x1E3C990", VA = "0x181E3E390")]
		public static Quaterniond AxisAngleD(Vector3d axis, double angleDeg)
		{
			return default(Quaterniond);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0000BF9C File Offset: 0x0000A19C
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x1E3E3E0", Offset = "0x1E3C9E0", VA = "0x181E3E3E0")]
		public static Quaterniond AxisAngleR(Vector3d axis, double angleRad)
		{
			return default(Quaterniond);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x1E3E440", Offset = "0x1E3CA40", VA = "0x181E3E440")]
		public void SetFromTo(Vector3d vFrom, Vector3d vTo)
		{
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		[Token(Token = "0x6001008")]
		[Address(RVA = "0x1E3E830", Offset = "0x1E3CE30", VA = "0x181E3E830")]
		public static Quaterniond FromTo(Vector3d vFrom, Vector3d vTo)
		{
			return default(Quaterniond);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		[Token(Token = "0x6001009")]
		[Address(RVA = "0x1E3E8A0", Offset = "0x1E3CEA0", VA = "0x181E3E8A0")]
		public static Quaterniond FromToConstrained(Vector3d vFrom, Vector3d vTo, Vector3d vAround)
		{
			return default(Quaterniond);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600100A")]
		[Address(RVA = "0x1E3EA30", Offset = "0x1E3D030", VA = "0x181E3EA30")]
		public void SetToSlerp(Quaterniond p, Quaterniond q, double t)
		{
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
		[Token(Token = "0x600100B")]
		[Address(RVA = "0x1E3EC10", Offset = "0x1E3D210", VA = "0x181E3EC10")]
		public static Quaterniond Slerp(Quaterniond p, Quaterniond q, double t)
		{
			return default(Quaterniond);
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600100C")]
		[Address(RVA = "0x1E3EC80", Offset = "0x1E3D280", VA = "0x181E3EC80")]
		public void SetFromRotationMatrix(Matrix3d rot)
		{
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x1E3ECA0", Offset = "0x1E3D2A0", VA = "0x181E3ECA0")]
		public void SetFromRotationMatrix(ref Matrix3d rot)
		{
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0000BFFC File Offset: 0x0000A1FC
		[Token(Token = "0x600100E")]
		[Address(RVA = "0x1E3F240", Offset = "0x1E3D840", VA = "0x181E3F240")]
		public bool EpsilonEqual(Quaterniond q2, double epsilon)
		{
			return default(bool);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0000C014 File Offset: 0x0000A214
		[Token(Token = "0x600100F")]
		[Address(RVA = "0x1E3F390", Offset = "0x1E3D990", VA = "0x181E3F390")]
		public static implicit operator Quaterniond(Quaternionf q)
		{
			return default(Quaterniond);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0000C02C File Offset: 0x0000A22C
		[Token(Token = "0x6001010")]
		[Address(RVA = "0x1E3F3D0", Offset = "0x1E3D9D0", VA = "0x181E3F3D0")]
		public static explicit operator Quaternionf(Quaterniond q)
		{
			return default(Quaternionf);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001011")]
		[Address(RVA = "0x1E3F410", Offset = "0x1E3DA10", VA = "0x181E3F410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001012")]
		[Address(RVA = "0x1E3F610", Offset = "0x1E3DC10", VA = "0x181E3F610")]
		public string ToString(string fmt)
		{
			return null;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0000C044 File Offset: 0x0000A244
		[Token(Token = "0x6001013")]
		[Address(RVA = "0x1E3F390", Offset = "0x1E3D990", VA = "0x181E3F390")]
		public static implicit operator Quaterniond(Quaternion q)
		{
			return default(Quaterniond);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0000C05C File Offset: 0x0000A25C
		[Token(Token = "0x6001014")]
		[Address(RVA = "0x1E3F3D0", Offset = "0x1E3D9D0", VA = "0x181E3F3D0")]
		public static explicit operator Quaternion(Quaterniond q)
		{
			return default(Quaternion);
		}

		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x0")]
		public double x;

		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0x8")]
		public double y;

		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		[FieldOffset(Offset = "0x10")]
		public double z;

		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x18")]
		public double w;

		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Quaterniond Zero;

		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Quaterniond Identity;
	}
}

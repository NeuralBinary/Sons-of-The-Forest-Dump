using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000212 RID: 530
	[Token(Token = "0x2000212")]
	public struct Vector4d : IComparable<Vector4d>, IEquatable<Vector4d>
	{
		// Token: 0x06001284 RID: 4740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x1E74F30", Offset = "0x1E73530", VA = "0x181E74F30")]
		public Vector4d(double f)
		{
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x1E3D500", Offset = "0x1E3BB00", VA = "0x181E3D500")]
		public Vector4d(double x, double y, double z, double w)
		{
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001286")]
		[Address(RVA = "0x1E3D520", Offset = "0x1E3BB20", VA = "0x181E3D520")]
		public Vector4d(double[] v2)
		{
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x1E3D580", Offset = "0x1E3BB80", VA = "0x181E3D580")]
		public Vector4d(Vector4d copy)
		{
		}

		// Token: 0x170002F9 RID: 761
		[Token(Token = "0x170002F9")]
		public double this[int key]
		{
			[Token(Token = "0x6001288")]
			[Address(RVA = "0x1E74F40", Offset = "0x1E73540", VA = "0x181E74F40")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6001289")]
			[Address(RVA = "0x1E74F70", Offset = "0x1E73570", VA = "0x181E74F70")]
			set
			{
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x0000E84C File Offset: 0x0000CA4C
		[Token(Token = "0x170002FA")]
		public double LengthSquared
		{
			[Token(Token = "0x600128A")]
			[Address(RVA = "0x1E3D770", Offset = "0x1E3BD70", VA = "0x181E3D770")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x0000E864 File Offset: 0x0000CA64
		[Token(Token = "0x170002FB")]
		public double Length
		{
			[Token(Token = "0x600128B")]
			[Address(RVA = "0x1E74FA0", Offset = "0x1E735A0", VA = "0x181E74FA0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x0000E87C File Offset: 0x0000CA7C
		[Token(Token = "0x170002FC")]
		public double LengthL1
		{
			[Token(Token = "0x600128C")]
			[Address(RVA = "0x1E75040", Offset = "0x1E73640", VA = "0x181E75040")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0000E894 File Offset: 0x0000CA94
		[Token(Token = "0x600128D")]
		[Address(RVA = "0x1E750C0", Offset = "0x1E736C0", VA = "0x181E750C0")]
		public double Normalize(double epsilon = 2.220446049250313E-16)
		{
			return 0.0;
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x0000E8AC File Offset: 0x0000CAAC
		[Token(Token = "0x170002FD")]
		public Vector4d Normalized
		{
			[Token(Token = "0x600128E")]
			[Address(RVA = "0x1E75140", Offset = "0x1E73740", VA = "0x181E75140")]
			get
			{
				return default(Vector4d);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
		[Token(Token = "0x170002FE")]
		public bool IsNormalized
		{
			[Token(Token = "0x600128F")]
			[Address(RVA = "0x1E75220", Offset = "0x1E73820", VA = "0x181E75220")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x0000E8DC File Offset: 0x0000CADC
		[Token(Token = "0x170002FF")]
		public bool IsFinite
		{
			[Token(Token = "0x6001290")]
			[Address(RVA = "0x1E752E0", Offset = "0x1E738E0", VA = "0x181E752E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001291")]
		[Address(RVA = "0x1E75340", Offset = "0x1E73940", VA = "0x181E75340")]
		public void Round(int nDecimals)
		{
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0000E8F4 File Offset: 0x0000CAF4
		[Token(Token = "0x6001292")]
		[Address(RVA = "0x1E3D930", Offset = "0x1E3BF30", VA = "0x181E3D930")]
		public double Dot(Vector4d v2)
		{
			return 0.0;
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0000E90C File Offset: 0x0000CB0C
		[Token(Token = "0x6001293")]
		[Address(RVA = "0x1E3D930", Offset = "0x1E3BF30", VA = "0x181E3D930")]
		public double Dot(ref Vector4d v2)
		{
			return 0.0;
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0000E924 File Offset: 0x0000CB24
		[Token(Token = "0x6001294")]
		[Address(RVA = "0x1E754C0", Offset = "0x1E73AC0", VA = "0x181E754C0")]
		public static double Dot(Vector4d v1, Vector4d v2)
		{
			return 0.0;
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0000E93C File Offset: 0x0000CB3C
		[Token(Token = "0x6001295")]
		[Address(RVA = "0x1E75500", Offset = "0x1E73B00", VA = "0x181E75500")]
		public double AngleD(Vector4d v2)
		{
			return 0.0;
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0000E954 File Offset: 0x0000CB54
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x1E755E0", Offset = "0x1E73BE0", VA = "0x181E755E0")]
		public static double AngleD(Vector4d v1, Vector4d v2)
		{
			return 0.0;
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0000E96C File Offset: 0x0000CB6C
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x1E75610", Offset = "0x1E73C10", VA = "0x181E75610")]
		public double AngleR(Vector4d v2)
		{
			return 0.0;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0000E984 File Offset: 0x0000CB84
		[Token(Token = "0x6001298")]
		[Address(RVA = "0x1E756F0", Offset = "0x1E73CF0", VA = "0x181E756F0")]
		public static double AngleR(Vector4d v1, Vector4d v2)
		{
			return 0.0;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0000E99C File Offset: 0x0000CB9C
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x1E75720", Offset = "0x1E73D20", VA = "0x181E75720")]
		public double DistanceSquared(Vector4d v2)
		{
			return 0.0;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0000E9B4 File Offset: 0x0000CBB4
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x1E75770", Offset = "0x1E73D70", VA = "0x181E75770")]
		public double DistanceSquared(ref Vector4d v2)
		{
			return 0.0;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0000E9CC File Offset: 0x0000CBCC
		[Token(Token = "0x600129B")]
		[Address(RVA = "0x1E757C0", Offset = "0x1E73DC0", VA = "0x181E757C0")]
		public double Distance(Vector4d v2)
		{
			return 0.0;
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0000E9E4 File Offset: 0x0000CBE4
		[Token(Token = "0x600129C")]
		[Address(RVA = "0x1E758B0", Offset = "0x1E73EB0", VA = "0x181E758B0")]
		public double Distance(ref Vector4d v2)
		{
			return 0.0;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x1E3D970", Offset = "0x1E3BF70", VA = "0x181E3D970")]
		public static Vector4d operator -(Vector4d v)
		{
			return default(Vector4d);
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0000EA14 File Offset: 0x0000CC14
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x1E3DBA0", Offset = "0x1E3C1A0", VA = "0x181E3DBA0")]
		public static Vector4d operator *(double f, Vector4d v)
		{
			return default(Vector4d);
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0000EA2C File Offset: 0x0000CC2C
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x1E3DB80", Offset = "0x1E3C180", VA = "0x181E3DB80")]
		public static Vector4d operator *(Vector4d v, double f)
		{
			return default(Vector4d);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0000EA44 File Offset: 0x0000CC44
		[Token(Token = "0x60012A0")]
		[Address(RVA = "0x1E75990", Offset = "0x1E73F90", VA = "0x181E75990")]
		public static Vector4d operator /(Vector4d v, double f)
		{
			return default(Vector4d);
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0000EA5C File Offset: 0x0000CC5C
		[Token(Token = "0x60012A1")]
		[Address(RVA = "0x1E759B0", Offset = "0x1E73FB0", VA = "0x181E759B0")]
		public static Vector4d operator /(double f, Vector4d v)
		{
			return default(Vector4d);
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0000EA74 File Offset: 0x0000CC74
		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x1E759F0", Offset = "0x1E73FF0", VA = "0x181E759F0")]
		public static Vector4d operator *(Vector4d a, Vector4d b)
		{
			return default(Vector4d);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0000EA8C File Offset: 0x0000CC8C
		[Token(Token = "0x60012A3")]
		[Address(RVA = "0x1E75A40", Offset = "0x1E74040", VA = "0x181E75A40")]
		public static Vector4d operator /(Vector4d a, Vector4d b)
		{
			return default(Vector4d);
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0000EAA4 File Offset: 0x0000CCA4
		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x1E3DC10", Offset = "0x1E3C210", VA = "0x181E3DC10")]
		public static Vector4d operator +(Vector4d v0, Vector4d v1)
		{
			return default(Vector4d);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0000EABC File Offset: 0x0000CCBC
		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x1E75A90", Offset = "0x1E74090", VA = "0x181E75A90")]
		public static Vector4d operator +(Vector4d v0, double f)
		{
			return default(Vector4d);
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x1E3DBC0", Offset = "0x1E3C1C0", VA = "0x181E3DBC0")]
		public static Vector4d operator -(Vector4d v0, Vector4d v1)
		{
			return default(Vector4d);
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0000EAEC File Offset: 0x0000CCEC
		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x1E75AB0", Offset = "0x1E740B0", VA = "0x181E75AB0")]
		public static Vector4d operator -(Vector4d v0, double f)
		{
			return default(Vector4d);
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0000EB04 File Offset: 0x0000CD04
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x1E75AD0", Offset = "0x1E740D0", VA = "0x181E75AD0")]
		public static bool operator ==(Vector4d a, Vector4d b)
		{
			return default(bool);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0000EB1C File Offset: 0x0000CD1C
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x1E75B20", Offset = "0x1E74120", VA = "0x181E75B20")]
		public static bool operator !=(Vector4d a, Vector4d b)
		{
			return default(bool);
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0000EB34 File Offset: 0x0000CD34
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x1E75B70", Offset = "0x1E74170", VA = "0x181E75B70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0000EB4C File Offset: 0x0000CD4C
		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x1E75C60", Offset = "0x1E74260", VA = "0x181E75C60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0000EB64 File Offset: 0x0000CD64
		[Token(Token = "0x60012AC")]
		[Address(RVA = "0x1E75D50", Offset = "0x1E74350", VA = "0x181E75D50", Slot = "4")]
		public int CompareTo(Vector4d other)
		{
			return 0;
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0000EB7C File Offset: 0x0000CD7C
		[Token(Token = "0x60012AD")]
		[Address(RVA = "0x1E75DE0", Offset = "0x1E743E0", VA = "0x181E75DE0", Slot = "5")]
		public bool Equals(Vector4d other)
		{
			return default(bool);
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0000EB94 File Offset: 0x0000CD94
		[Token(Token = "0x60012AE")]
		[Address(RVA = "0x1E75E30", Offset = "0x1E74430", VA = "0x181E75E30")]
		public bool EpsilonEqual(Vector4d v2, double epsilon)
		{
			return default(bool);
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60012AF")]
		[Address(RVA = "0x1E75F80", Offset = "0x1E74580", VA = "0x181E75F80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0x1E76180", Offset = "0x1E74780", VA = "0x181E76180")]
		public string ToString(string fmt)
		{
			return null;
		}

		// Token: 0x04000892 RID: 2194
		[Token(Token = "0x4000892")]
		[FieldOffset(Offset = "0x0")]
		public double x;

		// Token: 0x04000893 RID: 2195
		[Token(Token = "0x4000893")]
		[FieldOffset(Offset = "0x8")]
		public double y;

		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4000894")]
		[FieldOffset(Offset = "0x10")]
		public double z;

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		[FieldOffset(Offset = "0x18")]
		public double w;

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector4d Zero;

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Vector4d One;
	}
}

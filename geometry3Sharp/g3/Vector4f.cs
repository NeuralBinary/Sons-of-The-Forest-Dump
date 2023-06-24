using System;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	public struct Vector4f : IComparable<Vector4f>, IEquatable<Vector4f>
	{
		// Token: 0x060012B2 RID: 4786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012B2")]
		[Address(RVA = "0x1E763A0", Offset = "0x1E749A0", VA = "0x181E763A0")]
		public Vector4f(float f)
		{
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x1E1F030", Offset = "0x1E1D630", VA = "0x181E1F030")]
		public Vector4f(float x, float y, float z, float w)
		{
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012B4")]
		[Address(RVA = "0x1E1F140", Offset = "0x1E1D740", VA = "0x181E1F140")]
		public Vector4f(float[] v2)
		{
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x1E1F190", Offset = "0x1E1D790", VA = "0x181E1F190")]
		public Vector4f(Vector4f copy)
		{
		}

		// Token: 0x17000300 RID: 768
		[Token(Token = "0x17000300")]
		public float this[int key]
		{
			[Token(Token = "0x60012B6")]
			[Address(RVA = "0x1E763B0", Offset = "0x1E749B0", VA = "0x181E763B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60012B7")]
			[Address(RVA = "0x1E763E0", Offset = "0x1E749E0", VA = "0x181E763E0")]
			set
			{
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
		[Token(Token = "0x17000301")]
		public float LengthSquared
		{
			[Token(Token = "0x60012B8")]
			[Address(RVA = "0x1E3F940", Offset = "0x1E3DF40", VA = "0x181E3F940")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x0000EBDC File Offset: 0x0000CDDC
		[Token(Token = "0x17000302")]
		public float Length
		{
			[Token(Token = "0x60012B9")]
			[Address(RVA = "0x1E76410", Offset = "0x1E74A10", VA = "0x181E76410")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x0000EBF4 File Offset: 0x0000CDF4
		[Token(Token = "0x17000303")]
		public float LengthL1
		{
			[Token(Token = "0x60012BA")]
			[Address(RVA = "0x1E764C0", Offset = "0x1E74AC0", VA = "0x181E764C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0000EC0C File Offset: 0x0000CE0C
		[Token(Token = "0x60012BB")]
		[Address(RVA = "0x1E76540", Offset = "0x1E74B40", VA = "0x181E76540")]
		public float Normalize(float epsilon = 1.1920929E-07f)
		{
			return 0f;
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x0000EC24 File Offset: 0x0000CE24
		[Token(Token = "0x17000304")]
		public Vector4f Normalized
		{
			[Token(Token = "0x60012BC")]
			[Address(RVA = "0x1E765A0", Offset = "0x1E74BA0", VA = "0x181E765A0")]
			get
			{
				return default(Vector4f);
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x0000EC3C File Offset: 0x0000CE3C
		[Token(Token = "0x17000305")]
		public bool IsNormalized
		{
			[Token(Token = "0x60012BD")]
			[Address(RVA = "0x1E76650", Offset = "0x1E74C50", VA = "0x181E76650")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x0000EC54 File Offset: 0x0000CE54
		[Token(Token = "0x17000306")]
		public bool IsFinite
		{
			[Token(Token = "0x60012BE")]
			[Address(RVA = "0x1E76720", Offset = "0x1E74D20", VA = "0x181E76720")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x1E76770", Offset = "0x1E74D70", VA = "0x181E76770")]
		public void Round(int nDecimals)
		{
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0000EC6C File Offset: 0x0000CE6C
		[Token(Token = "0x60012C0")]
		[Address(RVA = "0xCA5AF0", Offset = "0xCA40F0", VA = "0x180CA5AF0")]
		public float Dot(Vector4f v2)
		{
			return 0f;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0000EC84 File Offset: 0x0000CE84
		[Token(Token = "0x60012C1")]
		[Address(RVA = "0xCA5AF0", Offset = "0xCA40F0", VA = "0x180CA5AF0")]
		public float Dot(ref Vector4f v2)
		{
			return 0f;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0000EC9C File Offset: 0x0000CE9C
		[Token(Token = "0x60012C2")]
		[Address(RVA = "0x1E76920", Offset = "0x1E74F20", VA = "0x181E76920")]
		public static float Dot(Vector4f v1, Vector4f v2)
		{
			return 0f;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0000ECB4 File Offset: 0x0000CEB4
		[Token(Token = "0x60012C3")]
		[Address(RVA = "0x1E76960", Offset = "0x1E74F60", VA = "0x181E76960")]
		public float AngleD(Vector4f v2)
		{
			return 0f;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0000ECCC File Offset: 0x0000CECC
		[Token(Token = "0x60012C4")]
		[Address(RVA = "0x1E76A50", Offset = "0x1E75050", VA = "0x181E76A50")]
		public static float AngleD(Vector4f v1, Vector4f v2)
		{
			return 0f;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0000ECE4 File Offset: 0x0000CEE4
		[Token(Token = "0x60012C5")]
		[Address(RVA = "0x1E76A70", Offset = "0x1E75070", VA = "0x181E76A70")]
		public float AngleR(Vector4f v2)
		{
			return 0f;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0000ECFC File Offset: 0x0000CEFC
		[Token(Token = "0x60012C6")]
		[Address(RVA = "0x1E76B50", Offset = "0x1E75150", VA = "0x181E76B50")]
		public static float AngleR(Vector4f v1, Vector4f v2)
		{
			return 0f;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0000ED14 File Offset: 0x0000CF14
		[Token(Token = "0x60012C7")]
		[Address(RVA = "0x1E76B70", Offset = "0x1E75170", VA = "0x181E76B70")]
		public float DistanceSquared(Vector4f v2)
		{
			return 0f;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0000ED2C File Offset: 0x0000CF2C
		[Token(Token = "0x60012C8")]
		[Address(RVA = "0x1E76B70", Offset = "0x1E75170", VA = "0x181E76B70")]
		public float DistanceSquared(ref Vector4f v2)
		{
			return 0f;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0000ED44 File Offset: 0x0000CF44
		[Token(Token = "0x60012C9")]
		[Address(RVA = "0x1E76BC0", Offset = "0x1E751C0", VA = "0x181E76BC0")]
		public float Distance(Vector4f v2)
		{
			return 0f;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0000ED5C File Offset: 0x0000CF5C
		[Token(Token = "0x60012CA")]
		[Address(RVA = "0x1E76CB0", Offset = "0x1E752B0", VA = "0x181E76CB0")]
		public float Distance(ref Vector4f v2)
		{
			return 0f;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0000ED74 File Offset: 0x0000CF74
		[Token(Token = "0x60012CB")]
		[Address(RVA = "0x1E1F390", Offset = "0x1E1D990", VA = "0x181E1F390")]
		public static Vector4f operator -(Vector4f v)
		{
			return default(Vector4f);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0000ED8C File Offset: 0x0000CF8C
		[Token(Token = "0x60012CC")]
		[Address(RVA = "0x1E1F3B0", Offset = "0x1E1D9B0", VA = "0x181E1F3B0")]
		public static Vector4f operator *(float f, Vector4f v)
		{
			return default(Vector4f);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x1E1F3D0", Offset = "0x1E1D9D0", VA = "0x181E1F3D0")]
		public static Vector4f operator *(Vector4f v, float f)
		{
			return default(Vector4f);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0000EDBC File Offset: 0x0000CFBC
		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x1E76DA0", Offset = "0x1E753A0", VA = "0x181E76DA0")]
		public static Vector4f operator /(Vector4f v, float f)
		{
			return default(Vector4f);
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0000EDD4 File Offset: 0x0000CFD4
		[Token(Token = "0x60012CF")]
		[Address(RVA = "0x1E76DC0", Offset = "0x1E753C0", VA = "0x181E76DC0")]
		public static Vector4f operator /(float f, Vector4f v)
		{
			return default(Vector4f);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0000EDEC File Offset: 0x0000CFEC
		[Token(Token = "0x60012D0")]
		[Address(RVA = "0x1E76E00", Offset = "0x1E75400", VA = "0x181E76E00")]
		public static Vector4f operator *(Vector4f a, Vector4f b)
		{
			return default(Vector4f);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0000EE04 File Offset: 0x0000D004
		[Token(Token = "0x60012D1")]
		[Address(RVA = "0x1E76E50", Offset = "0x1E75450", VA = "0x181E76E50")]
		public static Vector4f operator /(Vector4f a, Vector4f b)
		{
			return default(Vector4f);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0000EE1C File Offset: 0x0000D01C
		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x1E1F3F0", Offset = "0x1E1D9F0", VA = "0x181E1F3F0")]
		public static Vector4f operator +(Vector4f v0, Vector4f v1)
		{
			return default(Vector4f);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0000EE34 File Offset: 0x0000D034
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x1E1F440", Offset = "0x1E1DA40", VA = "0x181E1F440")]
		public static Vector4f operator +(Vector4f v0, float f)
		{
			return default(Vector4f);
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0000EE4C File Offset: 0x0000D04C
		[Token(Token = "0x60012D4")]
		[Address(RVA = "0x1E1F460", Offset = "0x1E1DA60", VA = "0x181E1F460")]
		public static Vector4f operator -(Vector4f v0, Vector4f v1)
		{
			return default(Vector4f);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0000EE64 File Offset: 0x0000D064
		[Token(Token = "0x60012D5")]
		[Address(RVA = "0x1E76EA0", Offset = "0x1E754A0", VA = "0x181E76EA0")]
		public static Vector4f operator -(Vector4f v0, float f)
		{
			return default(Vector4f);
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0000EE7C File Offset: 0x0000D07C
		[Token(Token = "0x60012D6")]
		[Address(RVA = "0x1E1F4F0", Offset = "0x1E1DAF0", VA = "0x181E1F4F0")]
		public static bool operator ==(Vector4f a, Vector4f b)
		{
			return default(bool);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0000EE94 File Offset: 0x0000D094
		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x8DB570", Offset = "0x8D9B70", VA = "0x1808DB570")]
		public static bool operator !=(Vector4f a, Vector4f b)
		{
			return default(bool);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0000EEAC File Offset: 0x0000D0AC
		[Token(Token = "0x60012D8")]
		[Address(RVA = "0x1E76EC0", Offset = "0x1E754C0", VA = "0x181E76EC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x1E41B40", Offset = "0x1E40140", VA = "0x181E41B40", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0000EEDC File Offset: 0x0000D0DC
		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x1E1F650", Offset = "0x1E1DC50", VA = "0x181E1F650", Slot = "4")]
		public int CompareTo(Vector4f other)
		{
			return 0;
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x1E1F4F0", Offset = "0x1E1DAF0", VA = "0x181E1F4F0", Slot = "5")]
		public bool Equals(Vector4f other)
		{
			return default(bool);
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x0000EF0C File Offset: 0x0000D10C
		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x1E76FA0", Offset = "0x1E755A0", VA = "0x181E76FA0")]
		public bool EpsilonEqual(Vector4f v2, float epsilon)
		{
			return default(bool);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60012DD")]
		[Address(RVA = "0x1E770B0", Offset = "0x1E756B0", VA = "0x181E770B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x1E772B0", Offset = "0x1E758B0", VA = "0x181E772B0")]
		public string ToString(string fmt)
		{
			return null;
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0000EF24 File Offset: 0x0000D124
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public static implicit operator Vector4f(Vector4 v)
		{
			return default(Vector4f);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0000EF3C File Offset: 0x0000D13C
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public static implicit operator Vector4(Vector4f v)
		{
			return default(Vector4);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0000EF54 File Offset: 0x0000D154
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public static implicit operator Color(Vector4f v)
		{
			return default(Color);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0000EF6C File Offset: 0x0000D16C
		[Token(Token = "0x60012E2")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public static implicit operator Vector4f(Color c)
		{
			return default(Vector4f);
		}

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x04000899 RID: 2201
		[Token(Token = "0x4000899")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x0400089A RID: 2202
		[Token(Token = "0x400089A")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x0400089B RID: 2203
		[Token(Token = "0x400089B")]
		[FieldOffset(Offset = "0xC")]
		public float w;

		// Token: 0x0400089C RID: 2204
		[Token(Token = "0x400089C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector4f Zero;

		// Token: 0x0400089D RID: 2205
		[Token(Token = "0x400089D")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Vector4f One;
	}
}

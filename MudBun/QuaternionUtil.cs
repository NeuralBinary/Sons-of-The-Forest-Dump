using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	public class QuaternionUtil
	{
		// Token: 0x060007EC RID: 2028 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x244EAA0", Offset = "0x244D0A0", VA = "0x18244EAA0")]
		public static float Magnitude(Quaternion q)
		{
			return 0f;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1E3F940", Offset = "0x1E3DF40", VA = "0x181E3F940")]
		public static float MagnitudeSqr(Quaternion q)
		{
			return 0f;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x244EAF0", Offset = "0x244D0F0", VA = "0x18244EAF0")]
		public static Quaternion Normalize(Quaternion q)
		{
			return default(Quaternion);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x244EB80", Offset = "0x244D180", VA = "0x18244EB80")]
		public static Quaternion AngularVector(Vector3 v)
		{
			return default(Quaternion);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x244ECC0", Offset = "0x244D2C0", VA = "0x18244ECC0")]
		public static Quaternion AxisAngle(Vector3 axis, float angle)
		{
			return default(Quaternion);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x244ED30", Offset = "0x244D330", VA = "0x18244ED30")]
		public static Vector3 GetAxis(Quaternion q)
		{
			return default(Vector3);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x244EE60", Offset = "0x244D460", VA = "0x18244EE60")]
		public static float GetAngle(Quaternion q)
		{
			return 0f;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x244EEA0", Offset = "0x244D4A0", VA = "0x18244EEA0")]
		public static Quaternion Pow(Quaternion q, float exp)
		{
			return default(Quaternion);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x244F080", Offset = "0x244D680", VA = "0x18244F080")]
		public static Quaternion Integrate(Quaternion q, Quaternion v, float dt)
		{
			return default(Quaternion);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x244F340", Offset = "0x244D940", VA = "0x18244F340")]
		public static Quaternion Integrate(Quaternion q, Vector3 omega, float dt)
		{
			return default(Quaternion);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public static Vector4 ToVector4(Quaternion q)
		{
			return default(Vector4);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x244F590", Offset = "0x244DB90", VA = "0x18244F590")]
		public static Quaternion FromVector4(Vector4 v, bool normalize = true)
		{
			return default(Quaternion);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x244F730", Offset = "0x244DD30", VA = "0x18244F730")]
		public static void DecomposeSwingTwist(Quaternion q, Vector3 twistAxis, out Quaternion swing, out Quaternion twist)
		{
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x244FBA0", Offset = "0x244E1A0", VA = "0x18244FBA0")]
		public static Quaternion Sterp(Quaternion a, Quaternion b, Vector3 twistAxis, float t, QuaternionUtil.SterpMode mode = QuaternionUtil.SterpMode.Slerp)
		{
			return default(Quaternion);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x244FC50", Offset = "0x244E250", VA = "0x18244FC50")]
		public static Quaternion Sterp(Quaternion a, Quaternion b, Vector3 twistAxis, float t, out Quaternion swing, out Quaternion twist, QuaternionUtil.SterpMode mode = QuaternionUtil.SterpMode.Slerp)
		{
			return default(Quaternion);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x244FCF0", Offset = "0x244E2F0", VA = "0x18244FCF0")]
		public static Quaternion Sterp(Quaternion a, Quaternion b, Vector3 twistAxis, float tSwing, float tTwist, QuaternionUtil.SterpMode mode = QuaternionUtil.SterpMode.Slerp)
		{
			return default(Quaternion);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x244FDA0", Offset = "0x244E3A0", VA = "0x18244FDA0")]
		public static Quaternion Sterp(Quaternion a, Quaternion b, Vector3 twistAxis, float tSwing, float tTwist, out Quaternion swing, out Quaternion twist, QuaternionUtil.SterpMode mode)
		{
			return default(Quaternion);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public QuaternionUtil()
		{
		}

		// Token: 0x0200013E RID: 318
		[Token(Token = "0x200013E")]
		public enum SterpMode
		{
			// Token: 0x040004B8 RID: 1208
			[Token(Token = "0x40004B8")]
			Nlerp,
			// Token: 0x040004B9 RID: 1209
			[Token(Token = "0x40004B9")]
			Slerp
		}
	}
}

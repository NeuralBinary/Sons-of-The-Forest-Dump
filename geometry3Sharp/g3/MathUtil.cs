using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	public static class MathUtil
	{
		// Token: 0x06000EF3 RID: 3827 RVA: 0x0000B0CC File Offset: 0x000092CC
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x1E31010", Offset = "0x1E2F610", VA = "0x181E31010")]
		public static bool IsFinite(double d)
		{
			return default(bool);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0000B0E4 File Offset: 0x000092E4
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x1E31050", Offset = "0x1E2F650", VA = "0x181E31050")]
		public static bool IsFinite(float d)
		{
			return default(bool);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0000B0FC File Offset: 0x000092FC
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x1E31080", Offset = "0x1E2F680", VA = "0x181E31080")]
		public static bool EpsilonEqual(double a, double b, double epsilon = 2.220446049250313E-16)
		{
			return default(bool);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0000B114 File Offset: 0x00009314
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x1E31100", Offset = "0x1E2F700", VA = "0x181E31100")]
		public static bool EpsilonEqual(float a, float b, float epsilon = 1.1920929E-07f)
		{
			return default(bool);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000EF7")]
		public static T Clamp<T>(T f, T low, T high) where T : IComparable
		{
			return null;
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0000B12C File Offset: 0x0000932C
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x1E31180", Offset = "0x1E2F780", VA = "0x181E31180")]
		public static float Clamp(float f, float low, float high)
		{
			return 0f;
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0000B144 File Offset: 0x00009344
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x1E311A0", Offset = "0x1E2F7A0", VA = "0x181E311A0")]
		public static double Clamp(double f, double low, double high)
		{
			return 0.0;
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0000B15C File Offset: 0x0000935C
		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x1E311C0", Offset = "0x1E2F7C0", VA = "0x181E311C0")]
		public static int Clamp(int f, int low, int high)
		{
			return 0;
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0000B174 File Offset: 0x00009374
		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0x1E311E0", Offset = "0x1E2F7E0", VA = "0x181E311E0")]
		public static int ModuloClamp(int f, int N)
		{
			return 0;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0000B18C File Offset: 0x0000938C
		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0x1E31200", Offset = "0x1E2F800", VA = "0x181E31200")]
		public static float RangeClamp(float fValue, float fMinMaxValue)
		{
			return 0f;
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0000B1A4 File Offset: 0x000093A4
		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0x1E312A0", Offset = "0x1E2F8A0", VA = "0x181E312A0")]
		public static double RangeClamp(double fValue, double fMinMaxValue)
		{
			return 0.0;
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0000B1BC File Offset: 0x000093BC
		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x1E31340", Offset = "0x1E2F940", VA = "0x181E31340")]
		public static float SignedClamp(float f, float fMax)
		{
			return 0f;
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0000B1D4 File Offset: 0x000093D4
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x1E31400", Offset = "0x1E2FA00", VA = "0x181E31400")]
		public static double SignedClamp(double f, double fMax)
		{
			return 0.0;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0000B1EC File Offset: 0x000093EC
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x1E314D0", Offset = "0x1E2FAD0", VA = "0x181E314D0")]
		public static float SignedClamp(float f, float fMin, float fMax)
		{
			return 0f;
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0000B204 File Offset: 0x00009404
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x1E31590", Offset = "0x1E2FB90", VA = "0x181E31590")]
		public static double SignedClamp(double f, double fMin, double fMax)
		{
			return 0.0;
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0000B21C File Offset: 0x0000941C
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x1E31660", Offset = "0x1E2FC60", VA = "0x181E31660")]
		public static bool InRange(float f, float low, float high)
		{
			return default(bool);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0000B234 File Offset: 0x00009434
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x1E31670", Offset = "0x1E2FC70", VA = "0x181E31670")]
		public static bool InRange(double f, double low, double high)
		{
			return default(bool);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0000B24C File Offset: 0x0000944C
		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x1E31690", Offset = "0x1E2FC90", VA = "0x181E31690")]
		public static bool InRange(int f, int low, int high)
		{
			return default(bool);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0000B264 File Offset: 0x00009464
		[Token(Token = "0x6000F05")]
		[Address(RVA = "0x1E316A0", Offset = "0x1E2FCA0", VA = "0x181E316A0")]
		public static double ClampAngleDeg(double theta, double min, double max)
		{
			return 0.0;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0000B27C File Offset: 0x0000947C
		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x1E31750", Offset = "0x1E2FD50", VA = "0x181E31750")]
		public static double ClampAngleRad(double theta, double min, double max)
		{
			return 0.0;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0000B294 File Offset: 0x00009494
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x1E311E0", Offset = "0x1E2F7E0", VA = "0x181E311E0")]
		public static int WrapSignedIndex(int val, int mod)
		{
			return 0;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x1E31800", Offset = "0x1E2FE00", VA = "0x181E31800")]
		public static void MinMax(double a, double b, double c, out double min, out double max)
		{
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0000B2AC File Offset: 0x000094AC
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x1E31940", Offset = "0x1E2FF40", VA = "0x181E31940")]
		public static double Min(double a, double b, double c)
		{
			return 0.0;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0000B2C4 File Offset: 0x000094C4
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x1E31A00", Offset = "0x1E30000", VA = "0x181E31A00")]
		public static float Min(float a, float b, float c)
		{
			return 0f;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0000B2DC File Offset: 0x000094DC
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x1E31AB0", Offset = "0x1E300B0", VA = "0x181E31AB0")]
		public static int Min(int a, int b, int c)
		{
			return 0;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0000B2F4 File Offset: 0x000094F4
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x1E31B20", Offset = "0x1E30120", VA = "0x181E31B20")]
		public static double Max(double a, double b, double c)
		{
			return 0.0;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0000B30C File Offset: 0x0000950C
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x1E31BE0", Offset = "0x1E301E0", VA = "0x181E31BE0")]
		public static float Max(float a, float b, float c)
		{
			return 0f;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0000B324 File Offset: 0x00009524
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x1E31C90", Offset = "0x1E30290", VA = "0x181E31C90")]
		public static int Max(int a, int b, int c)
		{
			return 0;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0000B33C File Offset: 0x0000953C
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x1E31D00", Offset = "0x1E30300", VA = "0x181E31D00")]
		public static double InvSqrt(double f)
		{
			return 0.0;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0000B354 File Offset: 0x00009554
		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x1E31D80", Offset = "0x1E30380", VA = "0x181E31D80")]
		public static double Atan2Positive(double y, double x)
		{
			return 0.0;
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0000B36C File Offset: 0x0000956C
		[Token(Token = "0x6000F11")]
		[Address(RVA = "0x1E31DF0", Offset = "0x1E303F0", VA = "0x181E31DF0")]
		public static float PlaneAngleD(Vector3f a, Vector3f b, int nPlaneNormalIdx = 1)
		{
			return 0f;
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0000B384 File Offset: 0x00009584
		[Token(Token = "0x6000F12")]
		[Address(RVA = "0x1E31F70", Offset = "0x1E30570", VA = "0x181E31F70")]
		public static double PlaneAngleD(Vector3d a, Vector3d b, int nPlaneNormalIdx = 1)
		{
			return 0.0;
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0000B39C File Offset: 0x0000959C
		[Token(Token = "0x6000F13")]
		[Address(RVA = "0x1E320F0", Offset = "0x1E306F0", VA = "0x181E320F0")]
		public static float PlaneAngleSignedD(Vector3f vFrom, Vector3f vTo, int nPlaneNormalIdx = 1)
		{
			return 0f;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0000B3B4 File Offset: 0x000095B4
		[Token(Token = "0x6000F14")]
		[Address(RVA = "0x1E32380", Offset = "0x1E30980", VA = "0x181E32380")]
		public static double PlaneAngleSignedD(Vector3d vFrom, Vector3d vTo, int nPlaneNormalIdx = 1)
		{
			return 0.0;
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0000B3CC File Offset: 0x000095CC
		[Token(Token = "0x6000F15")]
		[Address(RVA = "0x1E32620", Offset = "0x1E30C20", VA = "0x181E32620")]
		public static float PlaneAngleSignedD(Vector3f vFrom, Vector3f vTo, Vector3f planeN)
		{
			return 0f;
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0000B3E4 File Offset: 0x000095E4
		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x1E32A40", Offset = "0x1E31040", VA = "0x181E32A40")]
		public static double PlaneAngleSignedD(Vector3d vFrom, Vector3d vTo, Vector3d planeN)
		{
			return 0.0;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0000B3FC File Offset: 0x000095FC
		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x1E32DD0", Offset = "0x1E313D0", VA = "0x181E32DD0")]
		public static float PlaneAngleSignedD(Vector2f vFrom, Vector2f vTo)
		{
			return 0f;
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0000B414 File Offset: 0x00009614
		[Token(Token = "0x6000F18")]
		[Address(RVA = "0x1E32F60", Offset = "0x1E31560", VA = "0x181E32F60")]
		public static double PlaneAngleSignedD(Vector2d vFrom, Vector2d vTo)
		{
			return 0.0;
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0000B42C File Offset: 0x0000962C
		[Token(Token = "0x6000F19")]
		[Address(RVA = "0x1E33140", Offset = "0x1E31740", VA = "0x181E33140")]
		public static int MostParallelAxis(Frame3f f, Vector3f vDir)
		{
			return 0;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0000B444 File Offset: 0x00009644
		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x1E33410", Offset = "0x1E31A10", VA = "0x181E33410")]
		public static float Lerp(float a, float b, float t)
		{
			return 0f;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0000B45C File Offset: 0x0000965C
		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0x1E33430", Offset = "0x1E31A30", VA = "0x181E33430")]
		public static double Lerp(double a, double b, double t)
		{
			return 0.0;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0000B474 File Offset: 0x00009674
		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0x1E33450", Offset = "0x1E31A50", VA = "0x181E33450")]
		public static float SmoothStep(float a, float b, float t)
		{
			return 0f;
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0000B48C File Offset: 0x0000968C
		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0x1E33490", Offset = "0x1E31A90", VA = "0x181E33490")]
		public static double SmoothStep(double a, double b, double t)
		{
			return 0.0;
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0000B4A4 File Offset: 0x000096A4
		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x1E334D0", Offset = "0x1E31AD0", VA = "0x181E334D0")]
		public static float SmoothInterp(float a, float b, float t)
		{
			return 0f;
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0000B4BC File Offset: 0x000096BC
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x1E335B0", Offset = "0x1E31BB0", VA = "0x181E335B0")]
		public static double SmoothInterp(double a, double b, double t)
		{
			return 0.0;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0000B4D4 File Offset: 0x000096D4
		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x1E33690", Offset = "0x1E31C90", VA = "0x181E33690")]
		public static float SmoothRise0To1(float fX, float yshift, float xZero, float speed)
		{
			return 0f;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0000B4EC File Offset: 0x000096EC
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x1E33790", Offset = "0x1E31D90", VA = "0x181E33790")]
		public static float WyvillRise01(float fX)
		{
			return 0f;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0000B504 File Offset: 0x00009704
		[Token(Token = "0x6000F22")]
		[Address(RVA = "0x1E33810", Offset = "0x1E31E10", VA = "0x181E33810")]
		public static double WyvillRise01(double fX)
		{
			return 0.0;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0000B51C File Offset: 0x0000971C
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x1E33890", Offset = "0x1E31E90", VA = "0x181E33890")]
		public static float WyvillFalloff01(float fX)
		{
			return 0f;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0000B534 File Offset: 0x00009734
		[Token(Token = "0x6000F24")]
		[Address(RVA = "0x1E338C0", Offset = "0x1E31EC0", VA = "0x181E338C0")]
		public static double WyvillFalloff01(double fX)
		{
			return 0.0;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0000B54C File Offset: 0x0000974C
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0x1E338F0", Offset = "0x1E31EF0", VA = "0x181E338F0")]
		public static float WyvillFalloff(float fD, float fInnerRad, float fOuterRad)
		{
			return 0f;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0000B564 File Offset: 0x00009764
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x1E339F0", Offset = "0x1E31FF0", VA = "0x181E339F0")]
		public static double WyvillFalloff(double fD, double fInnerRad, double fOuterRad)
		{
			return 0.0;
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0000B57C File Offset: 0x0000977C
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x1E33B00", Offset = "0x1E32100", VA = "0x181E33B00")]
		public static float LinearRampT(float R, float deadzoneR, float x)
		{
			return 0f;
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0000B594 File Offset: 0x00009794
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x1E33BF0", Offset = "0x1E321F0", VA = "0x181E33BF0")]
		public static double Area(ref Vector3d v1, ref Vector3d v2, ref Vector3d v3)
		{
			return 0.0;
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0000B5AC File Offset: 0x000097AC
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x1E33D90", Offset = "0x1E32390", VA = "0x181E33D90")]
		public static double Area(Vector3d v1, Vector3d v2, Vector3d v3)
		{
			return 0.0;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0000B5C4 File Offset: 0x000097C4
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x1E33F10", Offset = "0x1E32510", VA = "0x181E33F10")]
		public static Vector3d Normal(ref Vector3d v1, ref Vector3d v2, ref Vector3d v3)
		{
			return default(Vector3d);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0000B5DC File Offset: 0x000097DC
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x1E34220", Offset = "0x1E32820", VA = "0x181E34220")]
		public static Vector3d Normal(Vector3d v1, Vector3d v2, Vector3d v3)
		{
			return default(Vector3d);
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0000B5F4 File Offset: 0x000097F4
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x1E342C0", Offset = "0x1E328C0", VA = "0x181E342C0")]
		public static Vector3d FastNormalDirection(ref Vector3d v1, ref Vector3d v2, ref Vector3d v3)
		{
			return default(Vector3d);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0000B60C File Offset: 0x0000980C
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x1E34400", Offset = "0x1E32A00", VA = "0x181E34400")]
		public static Vector3d FastNormalArea(ref Vector3d v1, ref Vector3d v2, ref Vector3d v3, out double area)
		{
			return default(Vector3d);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0000B624 File Offset: 0x00009824
		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x1E34580", Offset = "0x1E32B80", VA = "0x181E34580")]
		public static double AspectRatio(ref Vector3d v1, ref Vector3d v2, ref Vector3d v3)
		{
			return 0.0;
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0000B63C File Offset: 0x0000983C
		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0x1E34630", Offset = "0x1E32C30", VA = "0x181E34630")]
		public static double AspectRatio(Vector3d v1, Vector3d v2, Vector3d v3)
		{
			return 0.0;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0000B654 File Offset: 0x00009854
		[Token(Token = "0x6000F30")]
		[Address(RVA = "0x1E346A0", Offset = "0x1E32CA0", VA = "0x181E346A0")]
		public static double VectorCot(Vector3d v1, Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0000B66C File Offset: 0x0000986C
		[Token(Token = "0x6000F31")]
		[Address(RVA = "0x1E34800", Offset = "0x1E32E00", VA = "0x181E34800")]
		public static double VectorTan(Vector3d v1, Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0000B684 File Offset: 0x00009884
		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x1E34950", Offset = "0x1E32F50", VA = "0x181E34950")]
		public static bool IsObtuse(Vector3d v1, Vector3d v2, Vector3d v3)
		{
			return default(bool);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0000B69C File Offset: 0x0000989C
		[Token(Token = "0x6000F33")]
		[Address(RVA = "0x1E34A30", Offset = "0x1E33030", VA = "0x181E34A30")]
		public static double IsLeft(Vector2d P0, Vector2d P1, Vector2d P2)
		{
			return 0.0;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0000B6B4 File Offset: 0x000098B4
		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x1E34B00", Offset = "0x1E33100", VA = "0x181E34B00")]
		public static double IsLeft(ref Vector2d P0, ref Vector2d P1, ref Vector2d P2)
		{
			return 0.0;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0000B6CC File Offset: 0x000098CC
		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x1E34BF0", Offset = "0x1E331F0", VA = "0x181E34BF0")]
		public static Vector3d BarycentricCoords(ref Vector3d vPoint, ref Vector3d V0, ref Vector3d V1, ref Vector3d V2)
		{
			return default(Vector3d);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0000B6E4 File Offset: 0x000098E4
		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x1E34E60", Offset = "0x1E33460", VA = "0x181E34E60")]
		public static Vector3d BarycentricCoords(Vector3d vPoint, Vector3d V0, Vector3d V1, Vector3d V2)
		{
			return default(Vector3d);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0000B6FC File Offset: 0x000098FC
		[Token(Token = "0x6000F37")]
		[Address(RVA = "0x1E34F10", Offset = "0x1E33510", VA = "0x181E34F10")]
		public static Vector3d BarycentricCoords(Vector2d vPoint, Vector2d V0, Vector2d V1, Vector2d V2)
		{
			return default(Vector3d);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0000B714 File Offset: 0x00009914
		[Token(Token = "0x6000F38")]
		[Address(RVA = "0x1E350D0", Offset = "0x1E336D0", VA = "0x181E350D0")]
		public static double TriSolidAngle(Vector3d a, Vector3d b, Vector3d c, ref Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0000B72C File Offset: 0x0000992C
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x1E353D0", Offset = "0x1E339D0", VA = "0x181E353D0")]
		public static bool SolveQuadratic(double a, double b, double c, out double minT, out double maxT)
		{
			return default(bool);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0000B744 File Offset: 0x00009944
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x1E35520", Offset = "0x1E33B20", VA = "0x181E35520")]
		public static int PowerOf10(int n)
		{
			return 0;
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x1E35590", Offset = "0x1E33B90", VA = "0x181E35590")]
		public static IEnumerable<int> ModuloIteration(int nMaxExclusive, int nPrime = 31337)
		{
			return null;
		}

		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		public const double Deg2Rad = 0.017453292519943295;

		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		public const double Rad2Deg = 57.29577951308232;

		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		public const double TwoPI = 6.283185307179586;

		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		public const double FourPI = 12.566370614359172;

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		public const double HalfPI = 1.5707963267948966;

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		public const double ZeroTolerance = 1E-08;

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		public const double Epsilon = 2.220446049250313E-16;

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		public const double SqrtTwo = 1.4142135623730951;

		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		public const double SqrtTwoInv = 0.7071067811865475;

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		public const double SqrtThree = 1.7320508075688772;

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		public const float Deg2Radf = 0.017453292f;

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		public const float Rad2Degf = 57.29578f;

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		public const float PIf = 3.1415927f;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		public const float TwoPIf = 6.2831855f;

		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		public const float HalfPIf = 1.5707964f;

		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		public const float SqrtTwof = 1.4142135f;

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		public const float ZeroTolerancef = 1E-06f;

		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		public const float Epsilonf = 1.1920929E-07f;

		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x40007D5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] powers_of_10;
	}
}
